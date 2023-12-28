using MICRUD.Datos;
using MICRUD.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICRUD.Presentacion
{
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            InitializeComponent();
        }
        string Identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechaReg;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TomarAsistencia_Load(object sender, EventArgs e)
        {
             
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString(); 

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdentidad();
            if(Identificacion==txtIdentificacion.Text)
            {
                buscarAsistenciasId();
                if (Contador == 0)
                {
                    DialogResult resultado= MessageBox.Show("Agregar una Observacion?","Observaciones",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(resultado == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point(panel3.Location.X,panel3.Location.Y);
                        panelObservacion.Size = new Size(panel3.Width, panel3.Height);
                        panelObservacion.BringToFront();
                        riObservacion.Clear();
                        panelObservacion.Focus();
                        
                    }
                    else
                    {
                        InsertarAsistencias();
                    }
                }
                else
                {
                    ConfirmarSalida();
                }
            }
        }
        private void ConfirmarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion= new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_salida=DateTime.Now;
            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour,fechaReg, DateTime.Now);
            if (funcion.ConfirmarSalida(parametros) == true)
            {
                txtAviso.Text = "SALIDA REGISTRDA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }

        }
        private void InsertarAsistencias()
        {
            if(string.IsNullOrEmpty(riObservacion.Text)) 
            {
                riObservacion.Text = "-";
            }
            Lasistencias parametros =new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida= DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = riObservacion.Text;
           if(funcion.InsertarAsistencias(parametros) == true)
            {
                txtAviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                panelObservacion.Visible = false;


            }
      

        }
        private void buscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.buscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;
            if(Contador >0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
            }
        }
        private void BuscarPersonalIdentidad()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion= new Dpersonal();
            funcion.BuscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if(dt.Rows.Count > 0)
            {
                Identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal = Convert.ToInt32(dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombres"].ToString();


            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
