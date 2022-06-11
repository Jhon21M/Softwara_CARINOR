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
    public partial class FPrincipal2 : Form
    {
        public  FPrincipal2()
        {
            InitializeComponent();
            //Inicializaciòn();
        }
        private void EPanel()
        {
            if (PAdminist.Visible == true)
                PAdminist.Visible = false;
            if (PPedidos.Visible == true)
                PPedidos.Visible = false;
            if (PPago.Visible == true)
                PPago.Visible = false;
            if (PGastos.Visible == true)
                PGastos.Visible = false;
            if (PInvers.Visible == true)
                PInvers.Visible = false;
     

            //PSubMenu.AutoScroll = true;
        }

        //private void MPanel(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        HPanel();
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;

        //}


        private void FPrincipal2_Load(object sender, EventArgs e)
        {

            EPanel();
            BUbicacio();
            PSubMenu.Size = new Size(177, 417);
            PSoporte.Visible = false;
            
        }
        private Form activeform = null;
        private void AbrirFormularios(Form H)
        {
            if (activeform != null)
                activeform.Close();
            activeform = H;
            H.TopLevel = false;
            H.FormBorderStyle = FormBorderStyle.None;
            H.Dock = DockStyle.Fill;
            PPrincipalF.Controls.Add(H);
            PPrincipalF.Tag = H;
            H.BringToFront();
            H.Show();

        }
        private void BUbicacio()
        {
            BAdminist.Location = new Point(0, 0);
            BPedidos.Location = new Point(0, 49);
            BPago.Location = new Point(0, 98);
            BGastos.Location = new Point(0, 147);
            BEstadist.Location = new Point(0, 196);
        }

        //private void Inicializaciòn()
        //{
        //    PAdminist.Visible = false;
        //    PPedidos.Visible = false;
        //    PPago.Visible = false;
        //    PGastos.Visible = false;
        //}


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (PSoporte.Visible == true)
            { 
                PSoporte.Visible = false;
            }
            else
            {
                
                PSoporte.Visible = true;
                PSoporte.Size = new Size(151, 97);
                PSoporte.Location =new Point(36,3);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            //if (PAdminist.Visible == true || PPago.Visible == true || PGastos.Visible == true || PInvers.Visible == true)
            //{
                PAdminist.Visible = false;
                PPago.Visible = false;
                PGastos.Visible = false;
                PInvers.Visible = false;
                if (PPedidos.Visible == true)
            {
                EPanel();
                BUbicacio();
            }
            else
            {
                PPedidos.Visible = true;
                PPedidos.Size = new Size(177, 87);

            }
            BPedidos.Location = new Point(0, 49);
            PPedidos.Location = new Point(0, 98);
            BPago.Location = new Point(0, 185);
            BGastos.Location = new Point(0, 234);
            BEstadist.Location = new Point(0, 283);

            if (PPedidos.Visible == false)
            {
                BUbicacio();
            }
           
           // }
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void BAdminist_Click(object sender, EventArgs e)
        {
          
                PPedidos.Visible = false;
                PPago.Visible = false;
                PGastos.Visible = false;
                PInvers.Visible = false;

                if (PAdminist.Visible == true)
                {
                    EPanel();
                    BUbicacio();
                }
                else
                {
                    PAdminist.Visible = true;
                    PAdminist.Size = new Size(177, 170);
                }
                BAdminist.Location = new Point(0, 0);
                PAdminist.Location = new Point(0, 49);
                BPedidos.Location = new Point(0, 219);
                BPago.Location = new Point(0, 265);
                BGastos.Location = new Point(0, 315);
                BEstadist.Location = new Point(0, 364);


                if (PAdminist.Visible == false)
                {
                    BUbicacio();
              }
//}
             
           // MPanel(PAdminist);
        }

        private void BPago_Click(object sender, EventArgs e)
        {

            //if (PAdminist.Visible == true || PPedidos.Visible == true || PGastos.Visible == true || PInvers.Visible == true)
            //{
                PAdminist.Visible = false;
                PPedidos.Visible = false;
                PGastos.Visible = false;
                PInvers.Visible = false;

                if (PPago.Visible == true)
            {
                EPanel();
                BUbicacio();
            }
            else
            {
                PPago.Visible = true;
                PPago.Size = new Size(177, 88);
            }
            BPago.Location = new Point(0, 98);
            PPago.Location = new Point(0, 148);
            BGastos.Location = new Point(0, 235);
            BEstadist.Location = new Point(0, 284);
            

            if (PPago.Visible == false)
            {
                BUbicacio();
            }//MPanel(PGastos);
            //}
        }

        private void BGastos_Click(object sender, EventArgs e)
        {
            //if (PAdminist.Visible == true || PPedidos.Visible == true || PPago.Visible == true || PInvers.Visible == true)
            //{
                PAdminist.Visible = false;
                PPedidos.Visible = false;
                PPago.Visible = false;
                PInvers.Visible = false;
                if (PGastos.Visible == true)
            {
                EPanel();
                BUbicacio();
            }
            else
            {
                PGastos.Visible = true;
                PGastos.Size = new Size(177, 128);
            }
            BGastos.Location = new Point(0, 147);
            PGastos.Location = new Point(0, 197);
            BEstadist.Location = new Point(0, 324);


            if (PGastos.Visible == false)
            {
                BUbicacio();
            }
          //  }
            //MPanel(PGastos);
            // MPanel(PGastos);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PPedidos_Click(object sender, EventArgs e)
        {

        }

        private void BEstadist_Click(object sender, EventArgs e)
        {
            //if (PAdminist.Visible == true || PPedidos.Visible == true || PPago.Visible == true || PGastos.Visible == true)
            //{
                PAdminist.Visible = false;
                PPedidos.Visible = false;
                PPago.Visible = false;
                PGastos.Visible = false;

                if (PInvers.Visible == true)
            {
                EPanel();
                BUbicacio();
            }
            else
            {
                PInvers.Visible = true;
                PInvers.Size = new Size(177, 87);
            }
            BEstadist.Location = new Point(0, 196);
            PInvers.Location = new Point(0, 247);
           


            if (PInvers.Visible == false)
            {
                BUbicacio();
            }
           // }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FClientes());
            EPanel();
            BUbicacio();
            
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FBodega());
            EPanel();
            BUbicacio();

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FProductos());
            EPanel();
            BUbicacio();
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void PPago_Click(object sender, EventArgs e)
        {

        }

        //private void iconButton12_Click(object sender, EventArgs e)
        //{
           // AbrirFormularios(new FTrabajadores());
            //EPanel();
            //BUbicacio();

       // }
    
        private void BCerrarSession_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();


        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void iconButton13_Click_1(object sender, EventArgs e)
        {
            EPanel();
            BUbicacio();

        }

        private void PSoporte_Click(object sender, EventArgs e)
        {
            
        }
    }
}
