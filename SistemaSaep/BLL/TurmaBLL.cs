using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TurmaBLL
    {
        public void Cadastrar(Turma turma)
        {
            new TurmaDAL().Cadastrar(turma);
        }

        public List<Turma> BuscarTodasTurmas(int numeroprofessor)
        {
            return new TurmaDAL().BuscarTodasTurmas(numeroprofessor);
        }


        public void Excluir(int numeroTurma)
        {
            new TurmaDAL().Excluir(numeroTurma);
        }
    }
}
