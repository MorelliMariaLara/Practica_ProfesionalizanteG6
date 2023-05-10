using LogicaClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.de.clase
{
    public class Dueño : Usuario 
    {
        public int Id { get; set; }  
        public Usuario UsuarioDueño { get; set; }

    }
}
