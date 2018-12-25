using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Entidades;

namespace FluentNHibernateDemo
{

    public class NHibernateHelper
    {

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory(); return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            /*String DataSource = "FEDERICO";
            String InitialCatalog = "bibliotecaDB";
            String IntegratedSecurity = "True";
            String ConnectTimeout = "15";
            String Encrypt = "False";
            String TrustServerCertificate = "False";
            String ApplicationIntent = "ReadWrite";
            String MultiSubnetFailover = "False";
            */
            _sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
            @"Server=FEDERICO;Database=biblioteca;Trusted_Connection=True").ShowSql())
            /*
         .Mappings(m => m.FluentMappings
         .AddFromAssemblyOf<Program>())
         .ExposeConfiguration(cfg => new SchemaExport(cfg)
         .Create(true, true))
         .BuildSessionFactory();

            Borra la tabla
            Crea la tabla
            Guarda el registro
           */

            .Mappings(m => m.FluentMappings
         .AddFromAssemblyOf<Program>())
         .BuildSessionFactory();
            /*
             *Guarda el registro 
            */

        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
