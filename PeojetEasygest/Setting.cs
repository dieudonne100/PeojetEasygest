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
using System.Xml;
using System.IO;

namespace PeojetEasygest
{
    public partial class Setting : Sample
    {
        public Setting()
        {
            InitializeComponent();
        }
        //public void UpdateConfigFile(string con)
        //{
        //    XmlDocument xmlDo = new XmlDocument();
        //    xmlDo.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        //    foreach (XmlElement xmlElement in xmlDo.DocumentElement)
        //    {
        //        if (xmlElement.Name == "connectionStrings")
        //        {
        //            xmlElement.FirstChild.Attributes[2].Value = con;
        //        }
        //    }
        //    xmlDo.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        //    ConfigurationManager.RefreshSection("connectionStrings");
        //}
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (txtServer.Text == "")
            {
                lblServererror.Visible = true;

            }
            else
            {
                lblServererror .Visible = false;

            }
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

            if (txtDatabase.Text == "")
            {
                lblDatabaseerror.Visible = true;

            }
            else
            {
                lblDatabaseerror.Visible = false;

            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                lblUsererror.Visible = false;
                lblPassworderror.Visible = false;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                txtUser.Text = "";
                txtPassword.Text = "";

            }
            else
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                if (txtUser.Text == "") { lblUsererror.Visible = true; }
                else
                {
                    lblUsererror.Visible = false;
                }
            }
        }

        string connexion;
        private void SaveConnexion()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\Easygest_connect";
            File.WriteAllText(path, connexion);
        }
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                if (txtServer.Text == "")
                {
                    lblServererror.Visible = true;

                }
                else
                {
                    lblServererror.Visible = false;

                }
                if (txtDatabase.Text == "")
                {
                    lblDatabaseerror.Visible = true;

                }
                else
                {
                    lblDatabaseerror.Visible = false;

                }
                if (lblServererror.Visible || lblDatabaseerror.Visible)
                {
                    MainClasse.ShowMessaage("fields with * are mandatory.","Error");
                }
                else
                {
                    connexion = "Data Source" + txtServer.Text + ";Initial Catalog=" +
                        txtDatabase.Text + "Integrated Security=true;MultipltActiveResultSets=true";
                    SaveConnexion();
                    DialogResult dr = MessageBox.Show("Settings save successfuly.");
                    if (dr == DialogResult.OK)
                    {

                        LoginScreen f = new LoginScreen();
                        MainClasse.ShowWindow(f, this, MDI.ActiveForm); 
                    }
                }
            }
            else
            {
                if (txtServer.Text == "")
                {
                    lblServererror.Visible = true;

                }
                else
                {
                    lblServererror.Visible = false;

                }
                if (txtDatabase.Text == "")
                {
                    lblDatabaseerror.Visible = true;

                }
                else
                {
                    lblDatabaseerror.Visible = false;

                }
                if (txtUser.Text == "") { lblUsererror.Visible = true; }
                else
                {
                    lblUsererror.Visible = false;
                }
                if (txtPassword.Text == "") { lblPassworderror.Visible = true; }
                else
                {
                    lblPassworderror.Visible = false;
                }
                if (lblServererror.Visible || lblDatabaseerror.Visible|| lblPassworderror.Visible|| lblUsererror.Visible)
                {
                    MainClasse.ShowMessaage("fields with * are mandatory.", "Error");
                }
                else
                {
                    connexion = "Data Source" + txtServer.Text + ";Initial Catalog=" +
                        txtDatabase.Text + "User ID=" + txtUser.Text + "Password" + txtPassword.Text + "MultipltActiveResultRows=true";
                    SaveConnexion();
                    DialogResult dr = MessageBox.Show("Settings save successfuly.");
                    if (dr == DialogResult.OK)
                    {

                        LoginScreen f = new LoginScreen();
                        MainClasse.ShowWindow(f, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { lblPassworderror.Visible = true; }
            else
            {
                lblPassworderror.Visible = false;
            }
        }
    }
}

