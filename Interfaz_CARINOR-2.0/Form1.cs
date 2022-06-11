using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_CARINOR_2._0
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
            diseñopanel();
        }

        private void diseñopanel()
        {
            panel_Visualizar.Visible = false;
            Panel_Pedidos.Visible = false;
            Panel_pago.Visible = false;
            Panel_Compras.Visible = false;
            panel_Reportes.Visible = false;
        }
        private void HPanel()
        {
            if (panel_Visualizar.Visible == true)
                panel_Visualizar.Visible = false;
            if (Panel_Pedidos.Visible == true)
                Panel_Pedidos.Visible = false;
            if (Panel_pago.Visible == true)
                Panel_pago.Visible = false;
            if (Panel_Compras.Visible == true)
                Panel_Compras.Visible = false;
            if (panel_Reportes.Visible == true)
                panel_Reportes.Visible = false;
            Panel_Izqui_Menu.AutoScroll = true;
        }

        private void MPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HPanel();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void B_Visualizar_Click(object sender, EventArgs e)
        {
            MPanel(panel_Visualizar);
        }

        private void MPedidos_Click(object sender, EventArgs e)
        {
            MPanel(Panel_Pedidos);
        }

        private void MPago_Click(object sender, EventArgs e)
        {
            MPanel(Panel_pago);
        }

        private void MCompras_Click(object sender, EventArgs e)
        {
            MPanel(Panel_Compras);
        }

        private void btPrima_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Compras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MReporte_Click(object sender, EventArgs e)
        {
            MPanel(panel_Reportes);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void MProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void MPEntregados_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void MPAdministracion_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void MPOperativos_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void MMaquinaria_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void MInversiones_Click(object sender, EventArgs e)
        {
            HPanel();
        }

        private void panelAbajo_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeform = null;
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PFormularios_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

            //pictureBox1.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Izqui_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Reportes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
