using LojaConsoleApp.DAL;
using LojaConsoleApp.Entidades;
using LojaConsoleApp.Infra;
using NHibernate;
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
            //Console.WriteLine("Gerando o Schema de Banco de Dados");
            //NHibernateHelper.GerarSchema();


            //Console.WriteLine("Gravando novo usuario");

            //ISession session = NHibernateHelper.AbrirSessao();

            //Usuario usuario = new Usuario();
            //usuario.Nome = "Willian";

            //ITransaction transacao = session.BeginTransaction();
            //session.SaveOrUpdate(usuario);
            //transacao.Commit();

            //session.Close();

            //Console.WriteLine("Gravando novo usuario com DAL");
            //Usuario usuario = new Usuario();
            //usuario.Nome = "Eliane";

            //UsuarioDAL dal = new UsuarioDAL();
            //dal.Adiciona(usuario);

            //Console.WriteLine("Dados do usuario gravado: " + usuario.ToString());

            Console.WriteLine("Testando as entidades Produtos e categoria");
            //Categoria categoria = new Categoria()
            //{
            //    Nome = "Vestuário"
            //};

            //CategoriaDAL categoriaDAL = new CategoriaDAL();
            //categoria = categoriaDAL.Adiciona(categoria);
            //Produto produto = new Produto()
            //{
            //    Nome = "Camiseta",
            //    Preco = 12.5M,
            //    Categoria = categoria,
            //    DataUltimaCompra = new DateTime(2017, 12, 21)
            //};

            CategoriaDAL categoriaDAL = new CategoriaDAL();
            Categoria recuperada = categoriaDAL.getCategoria(3);
            Produto prod1 = new Produto()
            {
                Nome = "Camiseta Batman",
                Preco = 12.5M,
                Categoria = recuperada,
                DataUltimaCompra = new DateTime(2017, 12, 21)
            };

            Produto prod2 = new Produto()
            {
                Nome = "Camiseta Superman",
                Preco = 45M,
                Categoria = recuperada,
                DataUltimaCompra = new DateTime(2017, 12, 21)
            };

            Produto prod3 = new Produto()
            {
                Nome = "Camiseta Batman",
                Preco = 12.5M,
                Categoria = recuperada,
                DataUltimaCompra = new DateTime(2017, 12, 21)
            };


            ProdutoDAL dal = new ProdutoDAL();

            dal.Adiciona(prod1);
            dal.Adiciona(prod2);
            dal.Adiciona(prod3);

           // Console.WriteLine("Dados do produto gravado: " + prod1.ToString());

            Console.WriteLine("Produtos da Cadatrados na Categoria 3");
            recuperada = categoriaDAL.getCategoria(3);
            foreach (var prod in recuperada.Produtos)
            {
                Console.WriteLine("Dados do produto: " + prod.ToString());
            }



            Console.Read();
        }
    }
}
