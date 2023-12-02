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
    public partial class FormCadastrarAtividade : Form
    {
        private Turma Turma = new Turma();
        public FormCadastrarAtividade(Turma turma)
        {
            InitializeComponent();
            Turma = turma;
        }

        private void FormCadastrarAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor(a): " + Constantes.UsuarioLogado;
                lblTurma.Text = Turma.Nome;

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCadastrarAtividade.Text))
                {
                    MessageBox.Show("Digite a descrição da atividade.");
                    return;
                }
                Atividade atividade = new Atividade();
                atividade.Descricao = txtCadastrarAtividade.Text;
                new AtividadeBLL().Cadastrar(atividade, Turma.Numero);
                MessageBox.Show("Atividade cadastrada com sucesso");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
