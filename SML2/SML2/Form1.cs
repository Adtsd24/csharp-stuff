using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SML2
{
    public partial class SML2 : Form
    {
        private String javaMinMem;
        private String javaMaxMem;
        private String username;
        private String arguments;
        private String exePath;
        private String rootPath;
        private Boolean isDebug = false;
        public SML2()
        {
            InitializeComponent();
        }
        private void SML2_Load(object sender, EventArgs e)
        {
            ohKórva();
            exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (File.Exists(exePath + "\\portable.txt") || File.Exists(exePath + "\\portable.txt.txt"))
            {
                rootPath = exePath + "\\";
            }
            else
            {
                rootPath = "C:\\SML2\\";
            }
            List<string> versions = new List<string>();
            Array versionsIni = File.ReadAllLines(rootPath + "versions.ini");
            foreach (string item in versionsIni)
            {
                if (item.StartsWith(";") || item.StartsWith("["))
                {
                    continue;
                } else {
                    var temporaryString = item.Split('=');
                    versions.Add(temporaryString[0]);
                }
            }
            
            var config = File.ReadAllLines(rootPath + "config.ini");
            /*
            var javaMinMemIni = config[2].Split('=');
            var javaMaxMemIni = config[3].Split('=');
            var usernameIni = config[4].Split('=');
            javaMinMem = javaMinMemIni[1];
            javaMaxMem = javaMaxMemIni[1];
            username = usernameIni[1];
            */
            foreach (string conf in config)
            {
                if (conf.Split('=')[0] == "JavaMinMem")
                {
                    javaMinMem = conf.Split('=')[1];
                }
                if (conf.Split('=')[0] == "JavaMaxMem")
                {
                    javaMaxMem = conf.Split('=')[1];
                }
                if (conf.Split('=')[0] == "Username")
                {
                    username = conf.Split('=')[1];
                }
                if (conf.Split('=')[0] == "Debug")
                {
                    try { isDebug = Convert.ToBoolean(conf.Split('=')[1]); }
                    catch (System.FormatException) { MessageBox.Show(null, "Your \"Debug\" variable has an invalid value. It can only be either \"true\" or \"false\". SML2 will now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
                }
            }
            if (javaMinMem == "" || javaMaxMem == "" || username == "") {
                MessageBox.Show(null, "Configuration file not properly set up or corrupted. Please make sure it is set up correctly and restart SML2.\n(Check config.ini in installation directory for config file!)", "Error!");
                Application.Exit();
            }
            label2.Text = username;
            object[] versionsArray = versions.ToArray();
            comboBox1.Items.AddRange(versionsArray);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String versionName = comboBox1.SelectedItem.ToString();
            String jarPath = "";
            String libPath = "";
            String[] instanceConfig = File.ReadAllLines(rootPath + "Versions\\" + versionName + "\\version.ini");
            String extraClassPath = "";
            String entryName = "";
            foreach (string conf in instanceConfig)
            {
                if (conf.Split('=')[0] == "JarFile")
                {
                    jarPath = conf.Split('=')[1];
                }
                if (conf.Split('=')[0] == "Libraries")
                {
                    libPath = conf.Split('=')[1] + "\\*";
                }
                if (conf.Split('=')[0] == "CustomExtraClassPath")
                {
                    extraClassPath = conf.Split('=')[1];
                    var filesInDir = Directory.GetFiles(extraClassPath);
                    foreach (string file in filesInDir)
                    {
                        if (file.EndsWith(".zip"))
                        {
                            MessageBox.Show(String.Format("File {0} ends with .zip. It will not be loaded by Java. Please rename it to have a .jar extension for Java to properly load it. This message will appear for every file with such issues.", file));
                        }
                    }
                }
                if (conf.Split('=')[0] == "CustomEntryName")
                {
                    entryName = conf.Split('=')[1];
                }
            }
            String nativesPath = String.Format(rootPath + "Versions\\{0}\\natives", versionName);
            if (libPath == "") { libPath = String.Format(rootPath + "Versions\\{0}\\libraries\\*", versionName); }
            String classPath = String.Format("{0}{1}{2}", libPath, Path.PathSeparator, jarPath);
            if (extraClassPath != "") { classPath += ";" + extraClassPath; }
            String assetsPath = String.Format(rootPath + "Versions\\{0}\\assets", versionName);
            if (entryName == "") { entryName = "net.minecraft.client.Minecraft"; }
            arguments = String.Format("-Xms{0} -Xmx{1} -Djava.library.path=\"{2}\" -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Dhttp.proxyHost=betacraft.uk -Djava.util.Arrays.useLegacyMergeSort=true -cp \"{3}\" {4} {5} --gameDir \"C:\\SML2\\Versions\\{6}\" --assetsDir {7}", javaMinMem, javaMaxMem, nativesPath, classPath, entryName, username, versionName, assetsPath);
            arguments += " -noverify";
            if (isDebug == true) MessageBox.Show(arguments);
            launchGame();
        }

        private void launchGame()
        {
            textBox1.Clear();
            ProcessStartInfo javaGameProcess = new ProcessStartInfo();
            javaGameProcess.FileName = "java.exe";
            javaGameProcess.Arguments = arguments;
            String workPath = String.Format(rootPath + "Versions\\{0}\\", comboBox1.SelectedItem.ToString());
            javaGameProcess.EnvironmentVariables["APPDATA"] = String.Format(rootPath + "Versions\\{0}", comboBox1.SelectedItem.ToString());
            javaGameProcess.UseShellExecute = false;
            javaGameProcess.WorkingDirectory = workPath;
            javaGameProcess.RedirectStandardOutput = true;
            javaGameProcess.RedirectStandardError = true;
            javaGameProcess.CreateNoWindow = true;
            Process game = new Process();
            game.StartInfo = javaGameProcess;
            game.OutputDataReceived += (s, args) => appendToLog(args.Data);
            game.ErrorDataReceived += (s, args) => appendToLog(args.Data);
            game.Start();
            game.BeginOutputReadLine();
            game.BeginErrorReadLine();
            // Process.Start(javaGameProcess); // WHAT THE FUCK do you MEAN there is a THIRD WAY TO DO IT?! RIP 2025-2026
            // Process.Start("java.exe", arguments); // sorry, you are going. RIP legacy Process.Start in SML2 2025-2025
        }
        private void appendToLog(String text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(appendToLog), new object[] { text }); // idk what the fuck this does
                return;
            }
            if (!String.IsNullOrEmpty(text))
            {
                textBox1.AppendText(text + Environment.NewLine);
                textBox1.ScrollToCaret();
            }
        }
        private void ohKórva() {
            String[] blacklist = {"WeMod", "Wand", "WeModAuxiliaryService"};
            foreach (string a in blacklist)
            {
                Process[] IsDetected = Process.GetProcessesByName(a); // screw you
                foreach (Process b in IsDetected)
                {
                    MessageBox.Show("Access denied.\nAre you trying to search for the following terms:\n- What is Reddit\n- How do I uninstall a cheat client\n- SML2 access denied error how to fix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }
        }
    }
}
