using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TurmaDAL
    {
        public void Cadastrar(Turma turma)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO  Turmas ( Nome_turma, Professor_ID) values (@Nome, @NumeroProfessor) ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", turma.Nome);
                cmd.Parameters.AddWithValue("@NumeroProfessor", Constantes.IdUsuarioLogado);



                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar cadastrar turma no Banco de Dados ", ex);
            }
            finally
            {
                cn.Close();
            }
        }


        public List<Turma> BuscarTodasTurmas(int numeroprofessor)
        {
            List<Turma> turmas = new List<Turma>();
            Turma turma;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID_Turmas, Nome_turma FROM Turmas WHERE Professor_ID = @NumeroProfessor";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NumeroProfessor", numeroprofessor);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        turma = new Turma();
                        turma.Numero = Convert.ToInt32(rd["ID_Turmas"]);
                        turma.Nome = Convert.ToString(rd["Nome_turma"]);
                        turmas.Add(turma);

                    }
                }
                return turmas;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar acessar o banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int numeroTurma)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Turmas WHERE ID_Turmas = @Numero";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Numero", numeroTurma);

                cn.Open();

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar Excluir uma turma do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }

    }
}
