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
    public partial class FormVisualizarAtividade : Form
    {
        private Turma Turma = new Turma();
        public FormVisualizarAtividade(Turma turma)
        {
            InitializeComponent();
            Turma = turma;
        }

        private void FormVisualizarAtividade_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioLogado.Text = "Professor: " + Constantes.UsuarioLogado;
                lblTurma.Text = Turma.Nome;

                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(Turma.Numero);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            try
            {
               using(FormCadastrarAtividade frm = new FormCadastrarAtividade(Turma))
                {
                    frm.ShowDialog();
                }

                atividadeBindingSource.DataSource = new AtividadeBLL().BuscarTodasAtividades(Turma.Numero);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
