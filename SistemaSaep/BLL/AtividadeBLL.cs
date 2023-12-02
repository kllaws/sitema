using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AtividadeBLL
    {
        public void Cadastrar(Atividade atividade, int numeroTurma)
        {
            new AtividadeDAL().Cadastrar(atividade, numeroTurma);
        }

        public List<Atividade> BuscarTodasAtividades(int numeroTurma)
        {
            return new AtividadeDAL().BuscarTodasAtividades(numeroTurma);
        }
    }
}
