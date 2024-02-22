using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class ExercicioLivro
    {
        public void Menu()
        {
            List<Aluno> listaAlunos = new List<Aluno>();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastro de Aluno");
                Console.WriteLine("2. Cadastro de Notas");
                Console.WriteLine("3. Cadastro Total de Faltas");
                Console.WriteLine("4. Relação de Alunos, Notas, Média, Faltas e Situação");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        // Cadastro de Aluno
                        Aluno aluno = new Aluno();
                        Console.Write("Digite o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.Write("Digite o RA do aluno: ");
                        aluno.RA = Console.ReadLine();
                        listaAlunos.Add(aluno);
                        break;

                    case 2:
                        // Cadastro de Notas
                        Console.Write("Digite o RA do aluno: ");
                        string raAluno = Console.ReadLine();
                        Aluno alunoEncontrado = listaAlunos.Find(a => a.RA == raAluno);

                        if (alunoEncontrado != null)
                        {
                            Console.Write("Digite a nota da prova: ");
                            alunoEncontrado.NotaProva = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite a nota do trabalho: ");
                            alunoEncontrado.NotaTrabalho = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case 3:
                        // Cadastro Total de Faltas
                        Console.Write("Digite o RA do aluno: ");
                        string raAlunoFaltas = Console.ReadLine();
                        Aluno alunoEncontradoFaltas = listaAlunos.Find(a => a.RA == raAlunoFaltas);

                        if (alunoEncontradoFaltas != null)
                        {
                            Console.Write("Digite o total de faltas: ");
                            alunoEncontradoFaltas.TotalFaltas = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case 4:
                        // Relação de Alunos, Notas, Média, Faltas e Situação
                        foreach (Aluno a in listaAlunos)
                        {
                            Console.WriteLine($"Nome: {a.Nome}, RA: {a.RA}");
                            Console.WriteLine($"Nota da Prova: {a.NotaProva}, Nota do Trabalho: {a.NotaTrabalho}");
                            Console.WriteLine($"Média: {a.CalcularMedia()}, Faltas: {a.TotalFaltas}");
                            Console.WriteLine($"Percentual de Frequência: {a.CalcularPercentualFrequencia():F2}%");
                            Console.WriteLine($"Situação: {a.ObterSituacao()}");
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

    }
}
