using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Media Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "x");
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    //TODO: Adicionar Aluno
                        break;
                    case "2":
                    //TODO: listar Alunos
                        break;
                    case "3":
                    //TODO: Calcular Media Total
                        break;
                        
                        default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Media Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

        }
    }
}
