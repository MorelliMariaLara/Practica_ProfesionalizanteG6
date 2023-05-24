using LogicaClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClase

{
    public class Principal
    {
        List<Producto> ListaProducto = new List<Producto>();
        List<Proveedor> ListaProveedor = new List<Proveedor>();
        List<Carrito> ListaCarrito = new List<Carrito>();
        List<Vendedor> ListaVendedor = new List<Vendedor>();
        List<Dueño> Listadueño = new List<Dueño>();

        public void altavendedor(int Id, string Nombre_vendedor) //parametros
        {
            Vendedor vendedornuevo = new Vendedor();
            vendedornuevo.Id = Id;
            vendedornuevo.Nombre_vendedor = Nombre_vendedor;
            ListaVendedor.Add(vendedornuevo);
        }

        public void altadueño(int id, string Nombre_dueño) //parametros
        {
            Dueño dueñonuevo = new Dueño();
            dueñonuevo.id = id;
            dueñonuevo.nombre_dueño = Nombre_dueño;
            Listadueño.Add(dueñonuevo);
        }

        public void altaproducto(int id, string codigo_barra, int precio, string nombrep, int stock) //parametros
        {
            Producto productconuevo = new Producto();
            int contadorId = 0;
            foreach (var Producto in ListaProducto)
            {
                if (Producto.Id != null)
                {
                  //OBTENER EL MAXIMO PRIMERO 


                }
            }
            productconuevo.Id = //obtener la variable contador  + 1;
            productconuevo.codigo_barra = codigo_barra;
            productconuevo.precio = precio;
            productconuevo.nombrep = nombrep;
            productconuevo.stock = stock;
           
            ListaProducto.Add(productconuevo);
            

        }

        public void altaproveedor(string aoellido, string nombreproveedor, string lproductos) //parametros
        {
            Proveedor proveedorconuevo = new Proveedor();
            proveedorconuevo.apellido = aoellido;
            proveedorconuevo.nombreproveedor = nombreproveedor;
            proveedorconuevo.lproductos = lproductos;
            ListaProveedor.Add(proveedorconuevo);
        }

        public void altacarrito(double final, double precio_producto, string tipo_producto) //parametros
        {
            Carrito carritonuevo = new Carrito();
            carritonuevo.final = final; ;
            carritonuevo.precio_producto = precio_producto;
            carritonuevo.tipo_producto = tipo_producto;
            ListaCarrito.Add(carritonuevo);
        }
    }



}
