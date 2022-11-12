using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_calculo_nomina
{
    public partial class fmrprincipal : Form
    {
        public fmrprincipal()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double deducciones =15.34,salario=0,monto_deduccion=0, dia =0, salariohora=0;
            string nombre, cedula;
            nombre = Convert.ToString(txtnombre.Text);
            cedula = Convert.ToString(txtcedula.Text);
            txtnombre1.Text = Convert.ToString(txtnombre.Text);
            txtcedula1.Text = Convert.ToString(txtcedula.Text);

            dia = Convert.ToDouble(txtdias.Text);
            salariohora = Convert.ToDouble(txtsalariohora.Text);
             salario = Convert.ToDouble(salariohora * dia);
            monto_deduccion = Convert.ToDouble(salario * deducciones / 100);
            txtsalarioneto.Text = Convert.ToString(monto_deduccion);
            

            double bono=0,bono1 = 10500, bono2 = 25500, bono3 = 35500, bono4 = 45500, bono5 = 55500, bono6 = 10000, bono7 = 25000, bono8 = 35000, bono9 = 45000, bono10 = 55000;


            if (cmbsexo.Equals('M'))
            {

                if (cmbantiguedad.Equals('1'))
                {
                     bono = monto_deduccion + bono6;
                     txtsalarioneto_bono.Text = Convert.ToString(bono);
                }
                
                if (cmbantiguedad.Equals('2'))
                {
                     bono = monto_deduccion + bono7;
                }
                else
                {

                }
                    
                if (cmbantiguedad.Equals('3'))
                {
                      bono = monto_deduccion + bono8;
                }
                else
                {

                }
                        
                if (cmbantiguedad.Equals('4'))
                {
                        bono = monto_deduccion + bono9;
                }
                else
                {

                }
                            
                if (cmbantiguedad.Equals('5'))
                {
                         bono = monto_deduccion = bono10;
                }
                            
                        
                    
                    if (cmbsexo.Equals('F'))
                    {
                        if (cmbantiguedad.Equals('1'))
                        {
                                bono = monto_deduccion + bono1;
                        }
                        else
                        {
                            if (cmbantiguedad.Equals('2'))
                            {
                                    bono = monto_deduccion + bono2;
                            }
                            else
                            {
                                if (cmbantiguedad.Equals('3'))
                                {
                                        bono = monto_deduccion + bono3;
                                }
                                else
                                {
                                    if (cmbantiguedad.Equals('4'))
                                    {
                                            bono = monto_deduccion + bono4;
                                    }
                                    else
                                    {
                                        if (cmbantiguedad.Equals('5'))
                                        {
                                                bono = monto_deduccion + bono5;
                                        }
                                        else
                                        {
                                            
                                        }
                                    }
                                }
                            }
                        }
                       
                    }  
                      
                    
                


            }
            ///if principal



        }

        private void txtsalarioneto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombre1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcedula1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
                


            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtcedula.Clear();
            txtsalarioneto.Clear();
            txtsalariohora.Clear();
            cmbsexo.Items.Clear();
            cmbantiguedad.Items.Clear();
            txtnombre1.Clear();
            txtcedula1.Clear();
            txtsalarioneto.Clear();
            txtsalarioneto_bono.Clear();
            txtdias.Clear();
        }
    }
}
