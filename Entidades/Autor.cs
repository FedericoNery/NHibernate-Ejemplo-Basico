using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
    }
}
