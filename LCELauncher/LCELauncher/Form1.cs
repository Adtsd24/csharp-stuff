using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LCELauncher
{
    public partial class Form1 : Form
    {
        String username = "";
        Boolean fullscreen = false;
        String serverName = "";
        String serverPort = "25565";
        String serverIP = "0.0.0.0";
        String serverMaxPlayers = "8";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // client launch
            ProcessStartInfo client = new ProcessStartInfo();
            client.FileName = "C:\\LCELauncher\\Minecraft.Client\\Minecraft.Client.exe";
            String args = String.Format("-name {0}", username);
            if (fullscreen) { args += " -fullscreen"; }
            client.Arguments = args;
            client.WorkingDirectory = "C:\\LCELauncher\\Minecraft.Client\\";
            Process.Start(client);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // server launch
            ProcessStartInfo server = new ProcessStartInfo();
            server.FileName = "C:\\LCELauncher\\Minecraft.Server\\Minecraft.Server.exe";
            String args = String.Format("-name {0} -port {1} -ip {2} -maxplayers {3} -loglevel info", serverName, serverPort, serverIP, serverMaxPlayers);
            server.Arguments = args;
            server.WorkingDirectory = "C:\\LCELauncher\\Minecraft.Server\\";
            Process.Start(server);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // config stuff
            String[] configClient = File.ReadAllLines("C:\\LCELauncher\\ClientConfig.ini");
            username = configClient[1].Split('=')[1];
            try { fullscreen = System.Convert.ToBoolean(configClient[2].Split('=')[1]); } catch (Exception) { MessageBox.Show("Your client config file is not properly configured!"); Application.Exit(); }
            if (username == "") { MessageBox.Show("Your client config file is not properly configured!"); Application.Exit(); }

            String[] configServer = File.ReadAllLines("C:\\LCELauncher\\ServerConfig.ini");
            serverName = configServer[1].Split('=')[1];
            serverPort = configServer[2].Split('=')[1];
            serverIP = configServer[3].Split('=')[1];
            serverMaxPlayers = configServer[4].Split('=')[1];

            label4.Text = username;
        }
    }
}
