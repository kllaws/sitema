using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessorBLL
    {
        public Professor ValidarLogin(string email, string senha)
        {
            Professor professor = new Professor();
            professor = new ProfessorDAL().ValidarLogin(email, senha);
            if(String.IsNullOrEmpty(professor.Nome) || professor.Numero < 1)
            {
                throw new Exception("Usuário ou Senha inválido");
            }
            return professor;
        }
    }
}
