using Aula2a.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2a.Inputs
{
    public class FuncionarioInput
    {
        public static string LerNome()
        {
            Console.Write("Informe o nome do funcionário.........: ");
            return Console.ReadLine();
        }

        public static string LerCpf()
        {
            Console.Write("Informe o cpf do funcionário.........: ");
            return Console.ReadLine();
        }

        public static string LerMatricula()
        {
            Console.Write("Informe a matricula do funcionário.........: ");
            return Console.ReadLine();
        }

        public static DateTime LerDataAdmissao()
        {
            Console.Write("Informe a data de admissão.........: ");
            return DateTime.Parse(Console.ReadLine());
        }

        public static TipoDeContratacao LerTipoDeContratacao()
        {
            Console.Write("(1) ESTÁGIO\n");
            Console.Write("(2) CLT\n");
            Console.Write("(3) TERCEIRIZADO\n");
            Console.Write("Informe o tipo de contratação........: ");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    return TipoDeContratacao.Estagio;
                case 2:
                    return TipoDeContratacao.CLT;
                case 3:
                    return TipoDeContratacao.Terceirizado;
                default:
                    throw new Exception("Tipo de contratação inválida.");
            }
        }
    }
}
