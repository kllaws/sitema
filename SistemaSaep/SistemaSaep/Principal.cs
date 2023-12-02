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
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                using(FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (frm.Logou)
                    {
                        Application.Exit();
                    }
                    

                   
                }

                lblUsuarioLogado.Text = "Professor(a):" + Constantes.UsuarioLogado;

                turmaBindingSource.DataSource = new TurmaBLL().BuscarTodasTurmas(Constantes.IdUsuarioLogado);

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

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            try
            {
               using(FormCadastrarTurma frm = new FormCadastrarTurma())
                {
                    frm.ShowDialog();
                }
                turmaBindingSource.DataSource = new TurmaBLL().BuscarTodasTurmas(Constantes.IdUsuarioLogado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void turmaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Turma turma = new Turma();
                turma = ((Turma)turmaBindingSource.Current);

                if (turmaDataGridView.Columns[e.ColumnIndex].Name == "Excluir")

                {

                    if (turma.Numero < 1 || String.IsNullOrEmpty(turma.Nome)) // verifica se foi selecionad turma
                    {
                        MessageBox.Show("Selecione uma Turma");
                        return;
                    }
                    // Mensagem de confirmação
                    if (MessageBox.Show("Número: " + turma.Numero + " Turma: " + turma.Nome + "\nDeseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        MessageBox.Show("Exclusão de turma cancelada");
                        return;

                    }

                    List<Atividade> atividades = new List<Atividade>();
                    atividades = new AtividadeBLL().BuscarTodasAtividades(turma.Numero);

                    if (atividades.Count() > 0)
                    {
                        MessageBox.Show("Você não pode excluir uma turma com atividades cadastradas");
                        return;
                    }


                    new TurmaBLL().Excluir(turma.Numero);
                    MessageBox.Show("Turma excluída com sucesso!");
                    turmaBindingSource.RemoveCurrent();

                }

                if (turmaDataGridView.Columns[e.ColumnIndex].Name == "Visualizar")
                {

                    using (FormVisualizarAtividade frm = new FormVisualizarAtividade(turma))
                    {
                        frm.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
