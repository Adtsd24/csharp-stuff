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
        public SML2()
        {
            InitializeComponent();
        }
        private void SML2_Load(object sender, EventArgs e)
        {
            List<string> versions = new List<string>();
            Array versionsIni = File.ReadAllLines("C:\\SML2\\versions.ini");
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
            var config = File.ReadAllLines("C:\\SML2\\config.ini");
            var javaMinMemIni = config[2].Split('=');
            var javaMaxMemIni = config[3].Split('=');
            var usernameIni = config[4].Split('=');
            javaMinMem = javaMinMemIni[1];
            javaMaxMem = javaMaxMemIni[1];
            username = usernameIni[1];
            if (javaMinMem == "" || javaMaxMem == "" || username == "") {
                MessageBox.Show("Error: Configuration file not properly set up or corrupted. Please make sure it is set up correctly and restart SML2.\n(Check C:\\SML2\\config.ini for config file)");
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
            String jarPath = String.Format("C:\\SML2\\Versions\\{0}\\{0}.jar", versionName);
            String nativesPath = String.Format("C:\\SML2\\Versions\\{0}\\natives", versionName);
            String libPath = String.Format("C:\\SML2\\Versions\\{0}\\libraries\\*", versionName);
            String classPath = String.Format("{0}{1}{2}", libPath, Path.PathSeparator, jarPath);
            String assetsPath = String.Format("C:\\SML2\\Versions\\{0}\\assets", versionName);
            var instanceConfig = File.ReadAllLines(String.Format("C:\\SML2\\Versions\\{0}\\version.ini", versionName));
            if (instanceConfig.Length > 3)
            {
                if (instanceConfig[3] != null && instanceConfig[3].StartsWith("CustomExtraClassPath="))
                {
                    var extraClassPath = instanceConfig[3].Split('=');
                    String realExtraClassPath = extraClassPath[1];
                    classPath = classPath + String.Format(";{0}\\*", realExtraClassPath);
                    var filesInDir = Directory.GetFiles(realExtraClassPath);
                    foreach (string file in filesInDir)
                    {
                        if (file.EndsWith(".zip")) {
                            MessageBox.Show(String.Format("File {0} ends with .zip. It will not be loaded by Java. Please rename it to have a .jar extension for Java to properly load it. This message will appear for every file with such issues.", file));
                        }
                    }
                }
            }
            String entryName;
            if (instanceConfig.Length >= 5) { entryName = (instanceConfig[4].Split('='))[1]; } else { entryName = "net.minecraft.client.Minecraft"; }
            arguments = String.Format("-Xms{0} -Xmx{1} -Djava.library.path=\"{2}\" -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Dhttp.proxyHost=betacraft.uk -Djava.util.Arrays.useLegacyMergeSort=true -cp \"{3}\" {4} {5} --gameDir \"C:\\SML2\\Versions\\{6}\" --assetsDir {7}", javaMinMem, javaMaxMem, nativesPath, classPath, entryName, username, versionName, assetsPath);
            arguments += " -noverify";
            string[] config = File.ReadAllLines("C:\\SML2\\config.ini");
            var isDebugIni = config[5].Split('=');
            bool isDebug = Convert.ToBoolean(isDebugIni[1]);
            if (isDebug == true) MessageBox.Show(arguments);
            launchGame();
        }

        private void launchGame()
        {
            textBox1.Clear();
            ProcessStartInfo javaGameProcess = new ProcessStartInfo();
            javaGameProcess.FileName = "java.exe";
            javaGameProcess.Arguments = arguments;
            String workPath = String.Format("C:\\SML2\\Versions\\{0}\\", comboBox1.SelectedItem.ToString());
            javaGameProcess.EnvironmentVariables["APPDATA"] = String.Format("C:\\SML2\\Versions\\{0}", comboBox1.SelectedItem.ToString());
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
                this.Invoke(new Action<string>(appendToLog), new object[] { text });
                return;
            }
            if (!String.IsNullOrEmpty(text))
            {
                textBox1.AppendText(text + Environment.NewLine);
                textBox1.ScrollToCaret();
            }
        }
    }
}
