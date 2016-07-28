using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exercice01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool CheckNumber(string nombre)
        {
            string check = "0123456789.";
            int controle = 0;

            for (int i = 0; i < nombre.Length; i++)
            {
                if (check.IndexOf(nombre.Substring(i, 1)) == -1)
                {
                    controle++;
                }
            }

            if (controle == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool CheckLetter(string nom)
        {
            string check = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int controle = 0;

            for (int i = 0; i < nom.Length; i++)
            {
                if (check.IndexOf(nom.Substring(i, 1)) == -1)
                {
                    controle++;
                }
            }

            if (controle == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool test = true;
            //Test du txtNom
            if (CheckLetter(txtNom.Text) && txtNom.Text.Length !=0)
            {
                
                txtNom.BackColor = Color.White;
            }
            else
            {
                test = false;
                txtNom.BackColor = Color.Red;
            }
            //Test de la date
            if (Regex.IsMatch(txtDate.Text, @"^[0-3][0-9]\/[0-1][0-9]\/[0-9][0-9]([0-9][0-9])?$") && txtDate.Text.Length == 10)
            {
                
                txtDate.BackColor = Color.White;
            }
            else
            {
                test = false;
                txtDate.BackColor = Color.Red;
            }
            //Test du montant
            if (Regex.IsMatch(txtMontant.Text, @"^[0-9]+\.[0-9][0-9]?$"))
            {                
                txtMontant.BackColor = Color.White;
            }
            else
            {
                test = false;
                txtMontant.BackColor = Color.Red;
            }
            //Test du code postal
            if (Regex.IsMatch(txtCP.Text, @"^[0-9][0-9][0-9][0-9][0-9]?$"))
            {            
                txtCP.BackColor = Color.White;
            }
            else
            {
                test = false;
                txtCP.BackColor = Color.Red;
            }

            if (test)
            {
                txtMontant.BackColor = Color.White;
                txtCP.BackColor = Color.White;
                txtDate.BackColor = Color.White;
                txtNom.BackColor = Color.White;
                MessageBox.Show("Nom : "+txtNom.Text + "\nDate : "+txtDate.Text + "\nMontant : "+txtMontant.Text+"\nCode : "+txtCP.Text, "Validation effectuée", MessageBoxButtons.OK);
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtCP.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtNom.Clear();
            txtCP.BackColor = Color.White;
            txtDate.BackColor = Color.White;
            txtMontant.BackColor = Color.White;
            txtNom.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
