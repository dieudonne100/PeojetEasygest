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
    public partial class adminHomeScreenWindows : Sample
    {
        public adminHomeScreenWindows()
        {
            InitializeComponent();
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            MainClasse.ShowWindow(r, MDI.ActiveForm);
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            Users U = new Users();
            MainClasse.ShowWindow(U, MDI.ActiveForm);
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            Customers C = new Customers();
            MainClasse.ShowWindow(C, MDI.ActiveForm);
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
           FoodCategories  fc = new FoodCategories();
            MainClasse.ShowWindow(fc, MDI.ActiveForm);
        }

        private void btnfloors_Click(object sender, EventArgs e)
        {
            Floors fr = new Floors();
            MainClasse.ShowWindow(fr, MDI.ActiveForm);
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            Oders O = new Oders();
            MainClasse.ShowWindow(O, MDI.ActiveForm);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            Tables t = new Tables();
            MainClasse.ShowWindow(t, MDI.ActiveForm);
        }

        private void btnfoodmenu_Click(object sender, EventArgs e)
        {
            FoodMenu r = new FoodMenu();
            MainClasse.ShowWindow(r, MDI.ActiveForm);
        }
    }
}
