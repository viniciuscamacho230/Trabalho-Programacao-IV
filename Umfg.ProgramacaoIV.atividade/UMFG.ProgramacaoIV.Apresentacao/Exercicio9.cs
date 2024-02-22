using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Exercicio9
    {

    }
    struct livro

    {
        public string Titulo;
        public string Autor;
        public double Valor;

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Valor: {Valor:C}";
        }
    }

}
