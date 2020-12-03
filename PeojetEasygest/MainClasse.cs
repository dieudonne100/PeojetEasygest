using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeojetEasygest
{
    class MainClasse
    {
       
        public static void ShowWindow(Form opeWin,Form CloseWin , Form MDI)
        {
            CloseWin.Close();
            opeWin.WindowState = FormWindowState.Maximized;
            opeWin.MdiParent = MDI;
            opeWin.Show();
        }
        public static void ShowWindow(Form opeWin, Form MDI)
        {
            opeWin.WindowState = FormWindowState.Maximized;
            opeWin.MdiParent = MDI;
            opeWin.Show();
        }
        public static void ShowMessaage(string msg, string type)
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type == "erreur")
            {
                MessageBox.Show(msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
