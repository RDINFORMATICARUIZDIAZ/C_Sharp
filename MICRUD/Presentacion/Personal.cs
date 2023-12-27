using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MICRUD.Logica;
using MICRUD.Datos;
using System.Runtime.Remoting.Contexts;



namespace MICRUD.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }
        int IdCargo=0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int Idpersonal;
        private int items_por_pagina = 10;
        string Estado;
        int totalPaginas;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LocalizarDtvCargos();
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistros.Visible = true;
            PanelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardadCambiosdePersonal.Visible = false;
            Limpiar();
        }
        private void LocalizarDtvCargos()
        {
        
            dataListadoCargos.Location = new Point(txtSueldoPorHora.Location.X, txtSueldoPorHora.Location.Y);
            dataListadoCargos.Size = new Size(469, 141);
            dataListadoCargos.Visible = true;
            lblsueldo.Visible = false;
            PanelBtnGuardarPersonal.Visible = false;


        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtcedula.Clear();
            txtCargo.Clear();
            txtSueldoPorHora.Clear();
            buscarCargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtcedula.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (IdCargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoPorHora.Text))
                            {
                                Insertar_Personal();
                            }
                        }
                    }
                }
            }
        }

       
        private void Insertar_Personal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtcedula.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = IdCargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoPorHora.Text);
            if (funcion.InsertarPersonal(parametros) == true)
            {
                ReiniciarPaginado();
                MostrarPersonal();
                PanelRegistros.Visible = false;
                // Esta linea de abajo, solo es mi implementacion, no esta en los videos
                //PanelPaginado.Visible = false;
            }
            
 

        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.mostrarPersonal(ref dt, desde, hasta);
            DataListadoPersonal.DataSource = dt;
            //MostrarPersonal();
            DiseñarDtvPersonal();

        }
        private void DiseñarDtvPersonal()
        {
            Bases.DiseñoDtv(ref DataListadoPersonal);
            Bases.DiseñoDtvEliminar (ref DataListadoPersonal);
            PanelPaginado.Visible = true;
            DataListadoPersonal.Columns[2].Visible = false;
            DataListadoPersonal.Columns[7].Visible = false;
            ////DataListadoPersonal.Columns[9].Visible = false;

        }


        private void InsetarCargos()
        {
            if(!string.IsNullOrEmpty(txtCargoG.Text))
            {
                if(!string.IsNullOrEmpty(txtSueldoG.Text))
                {
                    Lcargos parametros = new Lcargos();
                    Dcargos funcion = new Dcargos();
                    parametros.cargo = txtCargoG.Text;
                    parametros.sueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
                    if (funcion.insertar_cargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        buscarCargos();
                        PanelCargos.Visible = false;

                    }
                }

                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Agrege el Cargo", "Falta el Cargo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void buscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.buscarCargos(ref dt, txtCargo.Text);
            dataListadoCargos.DataSource = dt;
            Bases.DiseñoDtv(ref dataListadoCargos);
            dataListadoCargos.Columns[1].Visible = false;
            dataListadoCargos.Columns[3].Visible = false;
            dataListadoCargos.Visible = true;

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            buscarCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargoG.Clear();
            txtSueldoG.Clear();   



        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            InsetarCargos();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoG, e);
        }

        private void txtSueldoPorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoPorHora, e);
        }

        private void dataListadoCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == dataListadoCargos.Columns["cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }
        private void ObtenerDatosCargos()
        {
            IdCargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoPorHora.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            dataListadoCargos.Visible = false;
            PanelBtnGuardarPersonal.Visible = true;
            lblsueldo.Visible = true;
        }
        private void ObtenerCargosEditar()
        {
            IdCargo =Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargoG.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoG.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarC.Visible = false;
            btnGuardarCambiosC.Visible = true;
            txtCargoG.Focus();
            txtCargo.SelectAll();
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
        }

        private void btnBolverCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible=false;
        }

        private void btnvolverPersonal_Click(object sender, EventArgs e)
        {
            PanelRegistros.Visible=false;
            PanelPaginado.Visible=true;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            EditarCargos(); 
        }
        private void EditarCargos()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Id_cargo = IdCargo;
            parametros.cargo = txtCargoG.Text;
            parametros.sueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
            if (funcion.editar_cargo(parametros) == true)
            {
                txtCargo.Clear();
                buscarCargos();
                PanelCargos.Visible = false;

            }
        }
        private void Personal_load(DataObjectMethodType sender, EventArgs e)
        {

        }

        private void btnGuardadCambiosdePersonal_Click(object sender, EventArgs e)
        {
            editarPersonal();
        }
        private void editarPersonal()
        {


            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            parametros.Nombres= txtNombres.Text;
            parametros.Identificacion=txtcedula.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo= IdCargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoPorHora.Text);
            if (funcion.editarPersonal(parametros) == true)
            {
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }
        }

        private void DataListadoPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

        }
        private void ObtenerDatos()
        {
            Idpersonal = Convert.ToInt32(DataListadoPersonal.SelectedCells[2].Value);
            Estado = DataListadoPersonal.SelectedCells[8].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                restaurar_personal();
            }
            else
            {
                LocalizarDtvCargos();
                txtNombres.Text = DataListadoPersonal.SelectedCells[3].Value.ToString();
                txtcedula.Text = DataListadoPersonal.SelectedCells[4].Value.ToString();
                cbxPais.Text = DataListadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = DataListadoPersonal.SelectedCells[6].Value.ToString();
                IdCargo = Convert.ToInt32(DataListadoPersonal.SelectedCells[7].Value);
                txtSueldoPorHora.Text = DataListadoPersonal.SelectedCells[5].Value.ToString();
                PanelPaginado.Visible = false;
                PanelRegistros.Visible = true;
                PanelRegistros.Dock = DockStyle.Fill;
                dataListadoCargos.Visible = false;
                lblsueldo.Visible= true;
                PanelBtnGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardadCambiosdePersonal.Visible = true;
                PanelCargos.Visible= false;
                
            }
        }
        private void restaurar_personal()
        {
            DialogResult result = MessageBox.Show("Este personal se Elimino. Desea volver a Habilitarlo?", "Restauracion registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }
        }
        private void HabilitarPersonal()
        {
            Lpersonal parametros=new Lpersonal();
            Dpersonal funcionario = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcionario.restaurar_personal(parametros) == true)
            {
                MostrarPersonal();
            }

        }
        private void EliminarPersonal()
        {
            Idpersonal = Convert.ToInt32(DataListadoPersonal.SelectedCells[2].Value);
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if(funcion.eliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }

        }

        private void Personal_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
            
        }
        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();
            if (contador > hasta)
            {
                btn_Sig.Visible = true;
                btn_Ant.Visible = false;
                btn_PrimeraPagina.Visible = true;
                btn_UltimaPagina.Visible = true;

            }
            else
            {
                btn_Sig.Visible = false;
                btn_Ant.Visible = false;
                btn_UltimaPagina .Visible = false;
                btn_PrimeraPagina.Visible=false;

            }
            Paginar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //MostrarPersonal();
        }

        private void PanelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDtvPersonal();
            timer1.Enabled = false;
        }

        private void DataListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataListadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Solo se Cambiara el Estado para que no se pueda acceder, Desea Continuar", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                }

            }
            if (e.ColumnIndex == DataListadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sig_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();
            if(contador > hasta)
            {
                btn_Sig.Visible = true;
                btn_Ant.Visible = true;
            }
            else
            {
                btn_Sig.Visible = false;
                btn_Ant.Visible = true;
            }
            Paginar();

        }
        private void Paginar()
        {
            try
            {
                lbl_Pagina.Text = (hasta / items_por_pagina).ToString();
                lbl_total.Text = Math.Ceiling(Convert.ToSingle(contador) / items_por_pagina).ToString();
                totalPaginas=Convert.ToInt32(lbl_total.Text);
            }
            catch (Exception)
            {

            }
        }
        private void Contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.ContarPersonal(ref contador);
        }

        private void btn_Ant_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta-= 10;
            MostrarPersonal();
            Contar();
            if (contador>hasta)

            {
                btn_Sig.Visible = true;
                btn_Ant.Visible = true;

            }
            else
            {
                btn_Sig.Visible = false;
                btn_Ant.Visible =true;
            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginar();
        }

        private void btn_UltimaPagina_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * items_por_pagina;
            desde = hasta - 9;
            MostrarPersonal() ;
            Contar();
            if (contador>hasta)

            {
                btn_Sig.Visible=true;
                btn_Ant.Visible=true;
            }
            else
            {
                btn_Sig.Visible = false;
                btn_Ant.Visible =true;
            }
            Paginar();
        }

        private void btn_PrimeraPagina_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void PanelPaginado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texbuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }

        private void BuscarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion= new Dpersonal();
            funcion.BuscarPersonal(ref dt, desde, hasta, txtbuscador.Text);
            DataListadoPersonal.DataSource= dt;
            DiseñarDtvPersonal();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }
    }
}
