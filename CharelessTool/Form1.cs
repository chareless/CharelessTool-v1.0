using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharelessTool
{
    public partial class CharelessTool : Form
    {
        public CharelessTool()
        {
            InitializeComponent();

            surumLabel.Text = surum;

            InternetKontrol();
        }

        public static string surum = "1.0";
        private void InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                netLabel.Text = "Bağlantı Mevcut";
                netLabel.ForeColor = Color.LimeGreen;
                updateToolStripButton.Enabled = true;
            }
            catch (Exception e)
            {
                netLabel.Text = "Bağlantı Yok";
                netLabel.ForeColor = Color.DarkRed;
                updateToolStripButton.Enabled = false;
            }
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf");
        }

        private void contactToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/#contact");
        }

        private void versionToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/charelesstool.html#version");
        }

        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            Update f1 = new Update();
            f1.Show();
        }

        private void diaryButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "//DigitalDiary//Digital Diary.exe");
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "//RandomTools//SomeGames.exe");
        }
    }
}
