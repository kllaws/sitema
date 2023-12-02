using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSaep
{
    public partial class FormCadastrarTurma : Form
    {
        public FormCadastrarTurma()
        {
            InitializeComponent();
        }

        private void FormCadastrarTurma_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor(a): " + Constantes.UsuarioLogado;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomedaTurma.Text))
                {
                    MessageBox.Show("Digite o nome da turma.");
                    return;
                }
                Turma turma = new Turma();
                turma.Nome = txtNomedaTurma.Text;
                new TurmaBLL().Cadastrar(turma);
                MessageBox.Show("Turma cadastrada com sucesso");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
