using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Entidades;

namespace Entidades
{
    public class AutorMap : ClassMap<Autor>
    {
        public AutorMap()
        {
            //Nombre de la tabla en la base de datos
            Table("autores");
            //Identificador único, KEY, le asignamos una secuencia para que se genere
            //de manera automática

            Id(x => x.Id);
            
            //Mapeamos el nombre dando el nombre que queremos a la columna en la
            //base de datos
            Map(x => x.Nombre).Column("nombre");
            //Mapeamos la fecha y asignamos un valor por defecto que dependerá 
            //del motor de base de datos
            Map(x => x.Apellido).Column("apellido");
        }
    }
}
