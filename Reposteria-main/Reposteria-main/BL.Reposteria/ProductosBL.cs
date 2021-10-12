using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class ProductosBL
    {
       public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pastel de zanahoria";
            producto1.Precio = 200;
            producto1.Existencia = 15;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Cheesecake de fresa";
            producto2.Precio = 190;
            producto2.Existencia = 8;
            producto2.Activo = true;

            ListaProductos.Add(producto2);


            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pie de limon";
            producto3.Precio = 150;
            producto3.Existencia = 17;
            producto3.Activo = true;

            ListaProductos.Add(producto3);


            var producto4 = new Producto();
            producto4.Id = 4;
            producto3.Descripcion = "Cupcakes de avena";
            producto3.Precio = 110;
            producto3.Existencia = 10;
            producto3.Activo = true;

            ListaProductos.Add(producto4);

        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }

    }
}
