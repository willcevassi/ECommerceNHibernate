using LojaConsoleApp.Entidades;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabrica = CriaSessionFactory();

        private static ISessionFactory CriaSessionFactory()
        {
            Configuration cfg = GetConfiguration();
            return fabrica = cfg.BuildSessionFactory();
        }

        public static Configuration GetConfiguration()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;
        }

        public static void GerarSchema()
        {
            Configuration cfg = GetConfiguration();
            new SchemaExport(cfg).Create(true, true);

        }

        public static ISession AbrirSessao()
        {
            return fabrica.OpenSession();
        }

    }
}
