using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
using _4_UNFV.PF.LogicaNegocio;

namespace _5_UNFV.PF.UI
{
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }


        private void RegistrarProducto()
        {
            ClaseMaster ObjMaster = new ClaseMaster();
            Producto objProducto = new Producto();

            ProductoLogic objProductoLogic = new ProductoLogic();
            ILogicProducto ILogicaProducto;

            ObjMaster.EntidadProducto = new List<Producto>();
            ILogicaProducto = objProductoLogic;

            objProducto.NombreProducto = txtNombreProducto.Text.Trim();
            objProducto.LineaProducto = txtLineaProducto.Text.Trim();
            objProducto.PrecioProducto = Convert.ToDecimal(txtPrecioProducto.Text);

            //
            ObjMaster.EntidadProducto.Add(objProducto);

            string Respuesta = ILogicaProducto.RegistrarProducto(ObjMaster);

            if (Respuesta == "1")
            {
                MessageBox.Show("Datos grabados satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Error al grabar:\n" + Respuesta);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
        }


    }
}
