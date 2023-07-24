using EmpleadosGestion.Controladores;
using EmpleadosGestion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosGestion.Vistas
{
    public partial class FormJob : Form
    {
        bool bEsUpdate = false;
        int nId_job = 0;
           
        public FormJob()
        {
            InitializeComponent();
            InicializarForm();            
        }

        private void InicializarForm()
        {
            cboFiltro.SelectedIndex = 0;
            CargarRegistros(null, "ASC", 0);
            nId_job = int.Parse(txtTitulo.Text = grdJobs.Rows[0].Cells[0].Value.ToString());
            txtTitulo.Text = grdJobs.Rows[0].Cells[1].Value.ToString();
            txtSalarioMin.Text = grdJobs.Rows[0].Cells[2].Value.ToString();
            txtSalarioMax.Text = grdJobs.Rows[0].Cells[3].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            if (dato != null && dato != "")
                CargarRegistros(dato, null, cboFiltro.SelectedIndex + 1);
            else
                CargarRegistros(dato, null, 0);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboFiltro.SelectedIndex != 1)
            {
                if(cboFiltro.SelectedIndex == 0)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                    {
                        e.Handled = true;
                    }
                }                

                // only allow one decimal point
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CtrlJob ctrlJobs = new CtrlJob();
            Job oJob = new Job(0, txtTitulo.Text, decimal.Parse(txtSalarioMin.Text), decimal.Parse(txtSalarioMax.Text));

            if (!bEsUpdate)
            {
                ctrlJobs.InsertJob(oJob);
                CargarRegistros(null, "DESC", 0);
            }
            else 
            {
                oJob.job_id = nId_job;
                ctrlJobs.UpdateJob(oJob);
                CargarRegistros(null, "ASC", 0);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bEsUpdate = true;
            pnlJob.Enabled = true;            
        }

        private void grdJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nId_job = int.Parse(grdJobs.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTitulo.Text = grdJobs.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSalarioMin.Text = grdJobs.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSalarioMax.Text = grdJobs.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = null;
            txtSalarioMin.Text = null;
            txtSalarioMax.Text = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bEsUpdate = false;
            pnlJob.Enabled = true;
            txtTitulo.Text = null;
            txtSalarioMin.Text = null;
            txtSalarioMax.Text = null;
            txtTitulo.Focus();
        }       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CtrlJob ctrlJobs = new CtrlJob();
            Job oJob = new Job(nId_job, txtTitulo.Text, decimal.Parse(txtSalarioMin.Text), decimal.Parse(txtSalarioMax.Text));
            ctrlJobs.DeleteJob(oJob);
            CargarRegistros(null, "ASC", 0);
        }

        private void txtSalarioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalarioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CargarRegistros(string dato, string orden, int opcion)
        {
            CtrlJob ctrlJobs = new CtrlJob();

            switch (opcion)
            {
                case 0:
                    grdJobs.DataSource = ctrlJobs.GetAllJobs(orden);
                    break;
                case 1:
                    grdJobs.DataSource = ctrlJobs.GetJobById(int.Parse(dato));
                    break;
                case 2:
                    grdJobs.DataSource = ctrlJobs.GetJobByTitle(dato);
                    break;
                case 3:
                    grdJobs.DataSource = ctrlJobs.GetJobBySalaryMin(decimal.Parse(dato));
                    break;
                case 4:
                    grdJobs.DataSource = ctrlJobs.GetJobBySalaryMax(decimal.Parse(dato));
                    break;
            }

            grdJobs.Columns[0].HeaderText = "ID";
            grdJobs.Columns[1].HeaderText = "Descripción";
            grdJobs.Columns[2].HeaderText = "Salario Min";
            grdJobs.Columns[3].HeaderText = "Salario Max";
        }
    }
}
