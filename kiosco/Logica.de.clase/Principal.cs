using Logica.de.clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClase

{
    public class Principal
    {
        List<Usuario> ListaUsuario = new List<Usuario>();
        List<Productos> ListaProducto = new List<Productos>();
        List<Carrito> ListaCarrito = new List<Carrito>();
        List<Dueño> ListaDueño = new List<Dueño>();
        List<Vendedor> ListaVendedor = new List<Vendedor>();



        public void AltaUsuario(string nombre,  string contraseña, string apellido, string Tipo)
        {
            Usuario usuarionuevo = new Usuario();
            usuarionuevo.nombre = nombre;
            usuarionuevo.contraseña = contraseña;
            usuarionuevo.apellido = apellido;
            usuarionuevo.Tipo = Tipo;
            ListaUsuario.Add(usuarionuevo);

            if (Tipo = "Vendedor")
            {

            }
        }
        public void AltaProducto(int id, string codigobarras, double precio, string nombreproducto, int stock)
        {
            Productos producto = new Productos();
            producto.id = id + 1;
            producto.codigobarras = codigobarras;
            producto.precio = precio;   
            producto.nombreproducto = nombreproducto;
            producto.stock = stock; 
            ListaProductos.Add(producto);

        }
        public void AltaProveedor(string lista, string nombredelproveedor, string apellido)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.lista = lista;
            proveedor.nombredelproveedor = nombredelproveedor;
            proveedor.apellido = apellido; 
            ListaProveedores.Add(proveedor);

        }
        public void AltaCarrito(double montototal, double precioxprod, string tipodeprod)
        {
            Carrito carrito = new Carrito();
            carrito.montototal = montototal;
            carrito.precioxprod = precioxprod;
            carrito.tipodeprod = tipodeprod;
            ListaCarrito.Add(carrito);
        }

        public void AltaCarrito()





        public List<Vendedor> mostrarlista()
            //recorre elemento por elemento
        { 
           foreach (var vendedor in ListaVendedor)
            {
            
            }
           return ListaVendedor;    
        }

       
}
