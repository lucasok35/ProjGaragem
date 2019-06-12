using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       using System.IO;
using Entidade;

namespace Utils
{
    public class GerarArquivo
    {
        #region Métodos
        public static void GerarLog(List<Cliente> lstCliente)
        {
            string nomeArquivo = @"C:\Users\andre\log" + 
                DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (var item in lstCliente)
            {
                writer.WriteLine(item.Id+";"+item.Nome+";"+item.Telefone);
            }            
            writer.Close();
        }
        #endregion Métodos
    }
}
