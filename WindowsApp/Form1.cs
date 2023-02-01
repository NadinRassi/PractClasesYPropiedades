using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();


            producto.Nombre = "Pan";
            producto.Descripcion = "Bolsa de Pan";
            producto.PrecioCosto = 2000;
            producto.Margen = 0.15;
            producto.IVA = 0.21;
            producto.Proveedor = "Carlos Perez";
            producto.Categoria = "Comestibles";
            producto.SubCategoria = "Panificados";

            //GET

            MessageBox.Show("Nombre: " + producto.Nombre + "\n" + "Descripcion: " + producto.Descripcion + "\n" + "Precio: " + producto.PrecioCosto.ToString() + "\n" + "Margen: " + producto.Margen.ToString() + "\n" + "Iva: " + producto.IVA.ToString() + "\n" + "Precio bruto: " + producto.PrecioBruto + "\n" + "Precio Venta: " + producto.PrecioVenta + "\n" + "Proveedor: " + producto.Proveedor + "\n" + "Categoria: " + producto.Categoria + "\n" + "Subcategoria: " + producto.SubCategoria
                );


        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClienteIndividuo1 clienteindividuo = new ClienteIndividuo1();
            clienteindividuo.Nombre = "Juan";
            clienteindividuo.Apellido = "Lopez";
            clienteindividuo.CUIT = "24324853940";
            clienteindividuo.Email = "juanl09@gmail.com";
            clienteindividuo.Telefono = "1184753219";
            clienteindividuo.Direccion = "Lopez de Vega 123";

            MessageBox.Show("Nombre: " + clienteindividuo.Nombre + "\n" + "Apellido: " + clienteindividuo.Apellido + "\n" + "CUIT: " + clienteindividuo.CUIT + "\n" + "Email: " + clienteindividuo.Email + "\n" + "Teléfono: " + clienteindividuo.Telefono + "\n" + "Dirección: " + clienteindividuo.Direccion);
        }
    }

}
    

