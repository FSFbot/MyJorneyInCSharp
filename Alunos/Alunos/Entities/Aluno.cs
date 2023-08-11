using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos.Entities
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; }

        public double Media()
        {
            double soma = 0;
            foreach(double nota in Notas)
            {
                soma += nota;
            }
            return soma / Notas.Count;
        }
    }
}

