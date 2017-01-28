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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void RegistrarCliente()
        {
            ClaseMaster ObjMaster = new ClaseMaster();
            Cliente objCliente = new Cliente();

            ClienteLogic objClienteLogic = new ClienteLogic();
            IlogicCliente iLogicaCliente;
            ObjMaster.EntidadCliente = new List<Cliente>();

            iLogicaCliente = objClienteLogic;

            objCliente.NombreCliente = txtNombreCliente.Text.Trim();
            objCliente.DireccionCliente = txtDireccionCliente.Text.Trim();
            objCliente.MontoCompra = Convert.ToDecimal(txtMonto.Text);
       
            //
            ObjMaster.EntidadCliente.Add(objCliente);

            string Respuesta = iLogicaCliente.RegistrarCliente(ObjMaster);

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
            RegistrarCliente();
        }


    }
}
