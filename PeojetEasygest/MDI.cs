using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace PeojetEasygest
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Easygest_connect"))
            {
                Setting obj = new Setting();
                MainClasse.ShowWindow(obj, this);
            }
            else
            {
             LoginScreen ls = new LoginScreen();
            MainClasse.ShowWindow(ls,this);
            }
           
        }
    }
}
