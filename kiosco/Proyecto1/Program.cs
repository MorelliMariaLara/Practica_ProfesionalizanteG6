using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using LogicaClase;

namespace Proyecto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();

            while () ;
            //mientras nuevo vendedor, hacer
            {
                Usuario usuarioagregado = new Usuario();
                Console.WriteLine("Agrega un usuario");
                Console.WriteLine("Empeza por tu nombre");
                usuarioagregado.nombre = Console.ReadLine();

                Console.WriteLine("Empeza por tu nombre");
                usuarioagregado.contraseña = Console.ReadLine();
                Console.WriteLine("Poneme tu apellido");
                usuarioagregado.apellido = Console.ReadLine();


                principal.AltaUsuario(usuarioagregado.nombre, usuarioagregado.comtraseña, usuarioagregado.apellido);
            }
           
            while () ;
            {
                Productos Productoagregado = new Productos();
                Console.WriteLine("agregar un producto");

                Console.WriteLine("arranca por el id");
                Productoagregado.id = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el nombre");
                Productoagregado.nombreproductos = Console.ReadLine();

                Console.WriteLine("agregar el precio");
                Productoagregado.precio = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el codigo de barra");
                Productoagregado.codigobarras = Console.ReadLine();

                Console.WriteLine("mostrame el stock")
                Productoagregado.stock =int.Parse(Console.ReadLine());

                principal.AltaProductos(Productoagregado.id, Productoagregado.nombreproductos ,
                    Productoagregado.precio, Productoagregado.codigobarras, Productoagregado.stock);

            }
            while ();
            {
                Proveedores Proveedoragregado = new Proveedores();
                Console.WriteLine("agregar un proveedor");

                Console.WriteLine("arranca por la lista");
                Proveedoragregado.lista = int.Parse(Console.ReadLine());

                Console.WriteLine("agregar el nombre");
                Proveedoragregado.nombredelproveedor = Console.ReadLine();

              

                principal.AltaProveedores(Proveedoragregado.lista, Proveedoragregado.nombredelproveedor);
            }
            while () ;
            {
                Carrito Carritoagregado = new Carrito();
                Console.WriteLine("crea tu carrito");

                Console.WriteLine("agrega tu producto al carrito");
                Carritoagregado.tipodeprod = Console.ReadLine();

                Console.WriteLine("este es el precio de tu producto");
                Carritoagregado.precioporprod = Console.ReadLine();

                Console.WriteLine("este es tu monto total");
                Carritoagregado.montototal = Console.ReadLine();
              

                principal.AltaCarrito(Carritoagregado.tipodeprod, Carritoagregado.precioporprod, Carritoagregado.montototal)
            }
        }















        }
        }
        }
    }
}
