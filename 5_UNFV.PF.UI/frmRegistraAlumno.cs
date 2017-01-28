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
    public partial class frmRegistraAlumno : Form
    {

        public frmRegistraAlumno()
        {
            InitializeComponent();
        }

        private void RegistrarAlumno()
        {
            ClaseMaster ObjMaster = new ClaseMaster();
            Alumno ObjAlumno = new Alumno();
            AlumnoLogic ObjAlumnoLogic = new AlumnoLogic();
            ILogicAlumno iLogicaAlumno;
            ObjMaster.EntidadAlumno = new List<Alumno>();
            
            iLogicaAlumno = ObjAlumnoLogic;

            ObjAlumno.NombresAlumno = txtNombres.Text.Trim();
            ObjAlumno.ApellidosAlumno = txtApellidos.Text.Trim();
            ObjAlumno.Practica1 = Convert.ToInt32(txtPractica1.Text);
            ObjAlumno.Practica2 = Convert.ToInt32(txtPractica2.Text);
            ObjAlumno.Practica3 = Convert.ToInt32(txtPractica3.Text);
            ObjAlumno.Practica4 = Convert.ToInt32(txtPractica4.Text);
            ObjAlumno.PromedioPracticas = 0;
            ObjAlumno.ExamenParcial = Convert.ToInt32(this.txtParcial.Text); ;
            ObjAlumno.ExamenFinal = Convert.ToInt32(this.txtFinal.Text); ;
            ObjAlumno.PromedioFinal = 0;
            ObjAlumno.Estado = Convert.ToBoolean(chkEstado.Checked);
            //
            ObjMaster.EntidadAlumno.Add(ObjAlumno);

            string Respuesta = iLogicaAlumno.RegistrarAlumno(ObjMaster);

            if (Respuesta == "1")
            {
                MessageBox.Show("Datos grabados satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Error al grabar:\n" + Respuesta);
            }

        }


        private void BuscarAlumnos()
        {
            if (!(string.IsNullOrEmpty(txtCodigo.Text)))
            {
                Alumno ObjAlumno = new Alumno();
                AlumnoLogic ObjAlumnoLogic = new AlumnoLogic();
                ObjAlumno.CodigoAlumno = Convert.ToInt32(txtCodigo.Text);

                List<Alumno> objAlumno = ObjAlumnoLogic.ListarAlumnos(ObjAlumno);

                try
                {
                    txtNombres.Text = Convert.ToString(objAlumno[0].NombresAlumno);
                    txtApellidos.Text = Convert.ToString(objAlumno[0].ApellidosAlumno); ;
                    txtPractica1.Text = Convert.ToString(objAlumno[0].Practica1);
                    txtPractica2.Text = Convert.ToString(objAlumno[0].Practica2);
                    txtPractica3.Text = Convert.ToString(objAlumno[0].Practica3);
                    txtPractica4.Text = Convert.ToString(objAlumno[0].Practica4);
                    lblPromedioPracticas.Text = Convert.ToString(objAlumno[0].PromedioPracticas);
                    txtParcial.Text = Convert.ToString(objAlumno[0].ExamenParcial);
                    txtFinal.Text = Convert.ToString(objAlumno[0].ExamenFinal);
                    lblPromedioFinal.Text = Convert.ToString(objAlumno[0].PromedioFinal);
                    chkEstado.Checked = Convert.ToBoolean(objAlumno[0].Estado);
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error al Buscar Alumno, Codigo de alumno no existe");
                    txtCodigo.Enabled = true;
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
            }
        }

        private void ActualizarAlumno()
        {
            ClaseMaster ObjMaster = new ClaseMaster();
            Alumno ObjAlumno = new Alumno();
            AlumnoLogic ObjAlumnoLogic = new AlumnoLogic();
            ILogicAlumno iLogicaAlumno;
            ObjMaster.EntidadAlumno = new List<Alumno>();

            iLogicaAlumno = ObjAlumnoLogic;

            ObjAlumno.CodigoAlumno = Convert.ToInt32(txtCodigo.Text);
            ObjAlumno.NombresAlumno = txtNombres.Text.Trim();
            ObjAlumno.ApellidosAlumno = txtApellidos.Text.Trim();
            ObjAlumno.Practica1 = Convert.ToInt32(txtPractica1.Text);
            ObjAlumno.Practica2 = Convert.ToInt32(txtPractica2.Text);
            ObjAlumno.Practica3 = Convert.ToInt32(txtPractica3.Text);
            ObjAlumno.Practica4 = Convert.ToInt32(txtPractica4.Text);
            ObjAlumno.PromedioPracticas = 0;
            ObjAlumno.ExamenParcial = Convert.ToInt32(this.txtParcial.Text); ;
            ObjAlumno.ExamenFinal = Convert.ToInt32(this.txtFinal.Text); ;
            ObjAlumno.PromedioFinal = 0;
            ObjAlumno.Estado = Convert.ToBoolean(chkEstado.Checked);
            //
            ObjMaster.EntidadAlumno.Add(ObjAlumno);

            string Respuesta = iLogicaAlumno.ActualizarAlumno(ObjMaster);

            if (Respuesta == "1")
            {
                MessageBox.Show("Datos actualizados satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar:\n" + Respuesta);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarAlumno();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAlumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarAlumno();
        }

    }
}
