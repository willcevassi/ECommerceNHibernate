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

            //CategoriaDAL categoriaDAL = new CategoriaDAL();
            //Categoria recuperada = categoriaDAL.getCategoria(3);
            //Produto prod1 = new Produto()
            //{
            //    Nome = "Camiseta Batman",
            //    Preco = 12.5M,
            //    Categoria = recuperada,
            //    DataUltimaCompra = new DateTime(2017, 12, 21)
            //};

            //Produto prod2 = new Produto()
            //{
            //    Nome = "Camiseta Superman",
            //    Preco = 45M,
            //    Categoria = recuperada,
            //    DataUltimaCompra = new DateTime(2017, 12, 21)
            //};

            //Produto prod3 = new Produto()
            //{
            //    Nome = "Camiseta Batman",
            //    Preco = 12.5M,
            //    Categoria = recuperada,
            //    DataUltimaCompra = new DateTime(2017, 12, 21)
            //};


            //ProdutoDAL dal = new ProdutoDAL();

            //dal.Adiciona(prod1);
            //dal.Adiciona(prod2);
            //dal.Adiciona(prod3);

            //// Console.WriteLine("Dados do produto gravado: " + prod1.ToString());

            // Console.WriteLine("Produtos da Cadatrados na Categoria 3");
            // recuperada = categoriaDAL.getCategoria(3);
            // foreach (var prod in recuperada.Produtos)
            // {
            //     Console.WriteLine("Dados do produto: " + prod.ToString());
            // }


            //Testando os cache de 1 e segundo nivel do NHibernate
            //CategoriaDAL dal = new CategoriaDAL();
            //ISession sessao1 = NHibernateHelper.AbrirSessao();
            //ISession sessao2 = NHibernateHelper.AbrirSessao();
            //Categoria cat1 = dal.GetCategoria(3,sessao1);
            //Categoria cat2 = dal.GetCategoria(3,sessao2);
            //Console.WriteLine(cat1);
            //Console.WriteLine(cat2);

            //GerarBanco();


            //ISession sessao = NHibernateHelper.AbrirSessao();
            //ITransaction tx = sessao.BeginTransaction();
            //Grupo grp1 = new Grupo() { Nome = "Administradores" };
            //sessao.SaveOrUpdate(grp1);
            //tx.Commit();

            //Console.WriteLine(grp1);
            //GrupoDAL grupoDAL = new GrupoDAL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            ISession sessao = NHibernateHelper.AbrirSessao();
            //ITransaction tx = sessao.BeginTransaction();

            //Grupo grp = grupoDAL.get(1);

            //Usuario usr1 = new Usuario()
            //{
            //    Nome = "Willian"
            //};
            //usr1.AssociarGrupo(grp);

            //Usuario// usr1 = usuarioDAL.Adiciona(usr1);

            //Usuario recuperado = usuarioDAL.get(1, sessao);
            //Console.WriteLine(recuperado.Nome);
            //Console.WriteLine();
            //Console.WriteLine("Grupos");
            //foreach (var item in recuperado.Grupos)
            //{
            //    Console.WriteLine(String.Format("{0} - {1}",item.Id,item.Nome) );
            //};

            // recuperado = usuarioDAL.get(2, sessao);
            // Console.WriteLine(recuperado.Nome);
            // Console.WriteLine();
            // Console.WriteLine("Grupos");
            // foreach (var item in recuperado.Grupos)
            // {
            //     Console.WriteLine(String.Format("{0} - {1}", item.Id, item.Nome));
            // }

            //tx.Commit();
            //Usuario usr = usuarioDAL.get(1, sessao);
            //IList<UsuarioGrupo> grupos = usuarioDAL.getInfoGrupos(usr,sessao);
            //Console.WriteLine("Informacoes do Grupo do usuario");
            //foreach (var item in grupos)
            //{
            //    Console.WriteLine(String.Format("Grupo:{0} - Ativo: {1}",item.Id.Grupo.Nome,item.Ativo));
            //}
            ITransaction tx = sessao.BeginTransaction();

            Usuario usr = usuarioDAL.get(1, sessao);
            Grupo grp = new GrupoDAL().get(3, sessao);
            usuarioDAL.AssociarGrupo(usr,grp,sessao);
            tx.Commit();

            IList<UsuarioGrupo> grupos = usuarioDAL.getInfoGrupos(usr, sessao);
            Console.WriteLine("Informacoes do Grupo do usuario");
            foreach (var item in grupos)
            {
                Console.WriteLine(String.Format("Grupo:{0} - Ativo: {1}", item.Id.Grupo.Nome, item.Ativo));
            }

            sessao.Close();



            Console.Read();
        }

        private static void GerarBanco()
        {
            Console.WriteLine("Gerando o Banco de dados...");
            NHibernateHelper.GerarSchema();
            Console.WriteLine("Geração Concluida...");
            Console.Read();
        }
    }
}
