using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using FluentNHibernateDemo;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var autor = new Autor
                    {
                        Nombre = "Lucas",
                        Apellido = "Nery"
                    };

                    session.Save(autor);
                    transaction.Commit();
                    Console.WriteLine("Autor creado: " + autor.Nombre + "\t" +
                       autor.Apellido);
                }

                Console.Read();
            }
        }
     }
}
