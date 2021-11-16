using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionDeStock.PL
{
    public partial class FRM_Connexion : Form
    {
        private dbstockContext db;
        private Form frmmenu;
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmmenu = Menu;
            db = new dbstockContext();
        }

        String TestObligatoire()
        {
            if(textBox1.Text=="" || textBox1.Text=="Nom d'utilisateur")
            {
                return "Entrer le nom d'utilisateur";

            }
            if(textBox2.Text=="" || textBox2.Text=="Mot de passe")
            {
                return "Entrer le mot de passe";
            }
            return null;
        }
        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text== "Nom d'utilisateur")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = false;
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.WhiteSmoke;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "Nom d'utilisateur";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Mot de passe";
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(TestObligatoire()==null)
            {
                if(C.ConnexionValide(db,textBox1.Text,textBox2.Text)== true)
                {
                    MessageBox.Show("Connexion reussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).ActiverForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion echouée", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(TestObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
