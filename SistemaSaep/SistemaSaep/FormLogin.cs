using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSaep
{
    
    public partial class FormLogin : Form
    {
        public bool Logou = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor();
                if(String.IsNullOrEmpty(txtEmailUsuario.Text) || String.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Insira o Usuario e/ou Senha.");
                    txtEmailUsuario.Focus();
                    return;
                }

                professor = new ProfessorBLL().ValidarLogin(txtEmailUsuario.Text, txtSenha.Text);

                if(professor.Numero > 0)
                {
                    Constantes.UsuarioLogado = professor.Nome;
                    Constantes.IdUsuarioLogado = professor.Numero;
                    Logou = false;
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
