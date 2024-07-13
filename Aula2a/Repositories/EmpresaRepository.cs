using Aula2a.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2a.Repositories
{
    public class EmpresaRepository
    {
        public void ExportarDados(Empresa empresa)
        {
            var json = JsonConvert.SerializeObject(empresa, Formatting.Indented);

            var streamWriter = new StreamWriter($"c:\\temp\\testes\\empresa_{empresa.Id}.json");
            streamWriter.WriteLine(json);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
