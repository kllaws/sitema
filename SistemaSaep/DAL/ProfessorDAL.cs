using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProfessorDAL
    {
        public Professor ValidarLogin(string email, string senha)
        {
            Professor professor = new Professor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT ID_Professor, nome FROM Professores WHERE email = @Email AND senha = @Senha";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        professor = new Professor();
                        professor.Numero = Convert.ToInt32(rd["ID_Professor"]);
                        professor.Nome = Convert.ToString(rd["nome"]);
                    }
                }
                return professor;





            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar validar professor no sistema ", ex);
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
