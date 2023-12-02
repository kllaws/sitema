using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AtividadeDAL
    {
        public void Cadastrar(Atividade atividade, int numeroTurma)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Atividade(Descricao_Atividade,Turma_ID) values (@Descricao,@NumeroTurma)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", atividade.Descricao);
                cmd.Parameters.AddWithValue("@NumeroTurma", numeroTurma);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar cadastrar Atividade no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Atividade> BuscarTodasAtividades(int numeroTurma)
        {
            List<Atividade> atividades = new List<Atividade>();
            Atividade atividade;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT ID_Atividade, Descricao_Atividade FROM Atividade WHERE Turma_ID = @Numero";

                cmd.CommandType = System.Data.CommandType.Text;

              
                cmd.Parameters.AddWithValue("@Numero", numeroTurma);

                cn.Open();

                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        atividade = new Atividade();
                        atividade.Numero = Convert.ToInt32(rd["ID_Atividade"]);
                        atividade.Descricao = Convert.ToString(rd["Descricao_Atividade"]);
                        atividades.Add(atividade);
                    }
                }

                return atividades;
                
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar buscar Atividade no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
