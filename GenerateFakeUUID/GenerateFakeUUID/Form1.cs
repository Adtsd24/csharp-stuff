using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GenerateFakeUUID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            { 
                MessageBox.Show(null, "You havent even provided anything. What am I supposed to do with that?!", "FakeUUID"); 
            }
            else
            {
                MessageBox.Show(null, GenerateUUID(textBox1.Text), "Your personal UUID:");
            }

        }
        public String GenerateUUID(String username)
        {
            String input = "OfflinePlayer:" + username;
            Byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
            hash[6] &= 0x0f;
            hash[6] |= 0x30;
            hash[8] &= 0x3f;
            hash[8] |= 0x80;
            Array.Reverse(hash, 0, 4);
            Array.Reverse(hash, 4, 2);
            Array.Reverse(hash, 6, 2);
            return new Guid(hash).ToString("D");
        }

    }

}
