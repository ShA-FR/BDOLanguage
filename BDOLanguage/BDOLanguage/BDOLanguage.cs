using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDOLanguage
{
    public partial class BDOLanguage : MetroFramework.Forms.MetroForm
    {
        public BDOLanguage()
        {
            InitializeComponent();
            string CenterText = "BDOLanguage | version 1.0";
            Console.SetCursorPosition((Console.WindowWidth - CenterText.Length) / 2, Console.CursorTop);
            Console.WriteLine(CenterText);
            Console.WriteLine("");
            Console.WriteLine("Made by : ShA @https://github.com/ShA-FR");
            Console.WriteLine("");



        }

        private void BDOLanguage_Load(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nThe software is provided as it and is not responsible if a ban occurs do you agree?", "TERMS OF USAGE | BDOLanguage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Console.WriteLine("[+] - [ " + DateTime.Now + " ] You agreed to the terms.");
            }
            else
            {
                Console.WriteLine("[-] - [ " + DateTime.Now + " ] Then you can't use it.");
                Thread.Sleep(2000);
                Environment.Exit(0);

            }
        }

        private void SetPathBtn_Click(object sender, EventArgs e)
        {
            SetGamePath.ShowDialog();
            GamePathTxt.Text = SetGamePath.SelectedPath;
            if (SetGamePath.SelectedPath.Contains("Black Desert Online"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] - [ " + DateTime.Now + " ] Succesfully found Black Desert Online folder..");
                


                comboBox1.Enabled = true;
                SetLanguageBtn.Enabled = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[X] - [ " + DateTime.Now + " ] Could not find Black Desert Online folder..");
                GamePathTxt.Text = null;
            }

        }

        private void SetLanguageBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[X] - [ " + DateTime.Now + " ] You haven't selected any language to use..");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] - [ " + DateTime.Now + " ] You have selected : " + comboBox1.SelectedItem + " started the patching.. ");
                File.Copy(@comboBox1.SelectedItem+ "\\languagedata_en.loc", GamePathTxt.Text+ "\\ads\\languagedata_en.loc",true);
                Console.WriteLine("[+] - [ " + DateTime.Now + " ] Language has been patched! ");
                Thread.Sleep(1000);


                Directory.CreateDirectory(GamePathTxt.Text + "\\prestringtable");
                Directory.CreateDirectory(GamePathTxt.Text + "\\prestringtable" + "\\font");

                File.Copy(@comboBox1.SelectedItem + "\\prestringtable\\font\\pearl.ttf", GamePathTxt.Text + "\\prestringtable\\font\\pearl.ttf", true);
                Console.WriteLine("[+] - [ " + DateTime.Now + " ] Font has been patched! ");
                Thread.Sleep(1500);

                Console.WriteLine("[+] - [ " + DateTime.Now + " ] You're good to go, automaticaly exiting in 2 seconds.");
                Thread.Sleep(2000);
                Environment.Exit(0);






            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("[+] - [ " + DateTime.Now + " ] You have selected : " + comboBox1.SelectedItem + " you can now click 'Set Language'");
            comboBox1.Enabled = false;
            SetLanguageBtn.Enabled = true;

        }
    }
}
