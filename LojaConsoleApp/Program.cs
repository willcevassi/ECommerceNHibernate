using LojaConsoleApp.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando o Schema de Banco de Dados");
            NHibernateHelper.GerarSchema();
            Console.Read();
        }
    }
}
