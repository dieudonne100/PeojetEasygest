using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeojetEasygest
{
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            adminHomeScreenWindows f = new adminHomeScreenWindows();
            MainClasse.ShowWindow(f, MDI.ActiveForm);
        }
    }
}
