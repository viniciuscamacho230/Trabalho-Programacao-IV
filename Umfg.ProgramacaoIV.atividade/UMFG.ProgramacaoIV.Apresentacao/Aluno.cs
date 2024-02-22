using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Aluno
    {
        public string Nome;
        public string RA;
        public double NotaProva;
        public double NotaTrabalho;
        public int TotalFaltas;

        public double CalcularMedia()
        {
            return (NotaProva * 7 + NotaTrabalho * 3) / 10;
        }

        public double CalcularPercentualFrequencia()
        {
            return (25 - TotalFaltas) / 25.0 * 100;
        }

        public string ObterSituacao()
        {
            if (CalcularMedia() >= 7 && CalcularPercentualFrequencia() >= 75)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
    }
}
