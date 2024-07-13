using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2a.Inputs
{
    public class EmpresaInput
    {
        public static string LerNomeFantasia()
        {
            Console.Write("Informe o nome fantasia da empresa...: ");
            return Console.ReadLine();
        }

        public static string LerRazaoSocial()
        {
            Console.Write("Informe a razão social da empresa...: ");
            return Console.ReadLine();
        }

        public static string LerCnpj()
        {
            Console.Write("Informe o cnpj da empresa...: ");
            return Console.ReadLine();
        }
    }
}
