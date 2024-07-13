using Aula2a.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2a.Entities
{
    public class Funcionario : Pessoa
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        public TipoDeContratacao TipoDeContratacao { get; set; }
    }
}
