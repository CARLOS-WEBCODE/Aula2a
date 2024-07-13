using Aula2a.Entities;
using Aula2a.Inputs;
using Aula2a.Repositories;
using System;
using System.Collections.Generic;

namespace Aula2a
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n *** EXPORTADOR DE DADOS DE EMPRESA *** \n");
            Console.WriteLine("\nEntre com os dados da empresa:\n");

            var empresa = new Empresa();

            empresa.Id = Guid.NewGuid();
            empresa.NomeFantasia = EmpresaInput.LerNomeFantasia();
            empresa.RazaoSocial = EmpresaInput.LerRazaoSocial();
            empresa.Cnpj = EmpresaInput.LerCnpj();
            empresa.Funcionarios = new List<Funcionario>();

            Console.Write("Informe a quantidade de funcionários: ");
            var qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                try
                {
                    Console.WriteLine($"\nInforme o {i}º Funcionários:\n");

                    var funcionario = new Funcionario();

                    funcionario.Id = Guid.NewGuid();
                    funcionario.Nome = FuncionarioInput.LerNome();
                    funcionario.Cpf = FuncionarioInput.LerCpf();
                    funcionario.Matricula = FuncionarioInput.LerMatricula();
                    funcionario.TipoDeContratacao = FuncionarioInput.LerTipoDeContratacao();

                    empresa.Funcionarios.Add(funcionario);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}");
                }
            }

            try
            {
                var empresaRepository = new EmpresaRepository();
                empresaRepository.ExportarDados(empresa);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro ao exportar dados: {ex.Message}");
            }

            Console.ReadKey();

        }
    }
}
