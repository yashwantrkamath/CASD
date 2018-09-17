using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            double T,Reyno=0,Lr=0,Cf,k2=0,Ca=0;
            double c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20;
            double Rf=0, Rapp=0, Rw=0, Rb=0, Rtr=0, Ra=0,R=0,k1=0,WettedSurfaceArea=0,Fnt=0;
            T = (Convert.ToSingle(tbTAP.Text) + Convert.ToSingle(tbTFP.Text)) / 2;
            c1 =;
           
            c3 =;
            c2 = Math.Exp(-1.89*Math.Sqrt(c3));
            if (Convert.ToDouble(tbTFP.Text)/Convert.ToDouble(tbLBP.Text) <= 0.04)
                c4 = Convert.ToDouble(tbTFP.Text)/Convert.ToDouble(tbLBP.Text);
            else
                if (Convert.ToDouble(tbTFP.Text)/ Convert.ToDouble(tbLBP.Text) > 0.04)
                c4 = 0.04;

            c5 =1-0.8*Convert.ToDouble(tbTransomArea.Text)/(Convert.ToDouble(tbB)*T*Convert.ToDouble(tbCm.Text));

            Fnt = Convert.ToDouble(tbVelocity.Text)/Math.Sqrt(2*9.81*(Convert.ToDouble(tbTransomArea.Text))/(Convert.ToDouble(tbB.Text)+ Convert.ToDouble(tbB.Text)*Convert.ToDouble(tbCwp.Text)));
            if (Fnt < 5)
                c6 =0.2*(1-0.2*Fnt);
            else
             if (Fnt >= 5)
                c6 = 0;

            if (Convert.ToDouble(tbB.Text) / Convert.ToSingle(tbLBP.Text) > 0.05)
                c7 = Math.Pow((Convert.ToDouble(tbB.Text) / Convert.ToDouble(tbLBP.Text)), 0.33333);
            else
               if (Convert.ToDouble(tbB.Text) / Convert.ToSingle(tbLBP.Text) < 0.25 || Convert.ToDouble(tbB.Text) / Convert.ToSingle(tbLBP.Text) > 0.11)
                c7 = Convert.ToDouble(tbB.Text) / Convert.ToSingle(tbLBP.Text) ;
            else
               if (Convert.ToDouble(tbB.Text) / Convert.ToSingle(tbLBP.Text) < 0.25)
                c7 = 0.5 - 0.0625 * Convert.ToDouble(tbLBP.Text) / Convert.ToSingle(tbB.Text);
            

            c8 =;
            c9 =;
            c10 =;
            c11 =;
            if (T / Convert.ToSingle(tbLBP.Text) > 0.05)
                c12 = Math.Pow(  (T/Convert.ToDouble(tbLBP.Text)) ,0.2228446);
            else
                if (T / Convert.ToSingle(tbLBP.Text) < 0.05)
                c12 =48.20 * Math.Pow((T / Convert.ToDouble(tbLBP.Text))-0.02, 2.078) +0.479948;
            else
                if (T / Convert.ToSingle(tbLBP.Text) < 0.02)
                c12 =0.479948;
            c13 =1+0.003*Convert.ToSingle(tbCstern.Text);
            c14 =;
            c15 =;
            c16 =;
            c17 =;
            c18 =;
            c19 =;
            c20 =;
            Lr = Convert.ToDouble(tbLBP.Text) * ( 1-Convert.ToDouble(tbCp.Text) + 0.06 * Convert.ToDouble(tbCp.Text) * Convert.ToDouble(tbLCB.Text)) / (4*Convert.ToDouble(tbCp.Text) -1)  ;

            k1 = c13 *(0.93+c12*Math.Pow(Convert.ToDouble(tbB.Text)/Lr,0.92497)) * Math.Pow(0.95-Convert.ToDouble(tbCp.Text), -0.521448) * Math.Pow(1- Convert.ToDouble(tbCp.Text)+0.0225*Convert.ToDouble(tbLCB.Text) , 0.6906);

            Cf = 0.075 /(Math.Pow( (Math.Log10(Reyno)-2),2));

            WettedSurfaceArea = Convert.ToDouble(tbLBP.Text)*(2*T+Convert.ToDouble(tbB.Text) ) * Math.Sqrt(Convert.ToDouble(tbCm.Text)) * (0.453+0.4425* Convert.ToDouble(tbCb.Text) ) -0.2862 * Convert.ToDouble(tbCm.Text) - 0.003467 * Convert.ToDouble(tbB.Text)/ Convert.ToDouble(T) + 0.3696* Convert.ToDouble(tbCwp.Text)+2.38* Convert.ToDouble(tbAbt.Text)/Convert.ToDouble(tbCb.Text);

            Rapp = 0.5* 1.025* Convert.ToDouble(tbVelocity.Text)* Convert.ToDouble(tbVelocity.Text)* Convert.ToDouble(tbWettedAreaApp.Text)*Cf*k2;

            Rw = c1*c2*c5* Convert.ToDouble(tbVdisp.Text) * 1.025*9.81*Math.Exp(m1*Math.Pow(Fn,0.9)+m2*Math.Cos(lamba*Math.Pow(Fn,-2)));

            Rb =0.11*Math.Exp(-3*Math.Pow(Pb,-2))*Math.Pow(Fni,3)*Math.Pow(Convert.ToDouble(tbAbt.Text),1.5)*1.025*9.81/(1+Math.Pow( Fni,2)) ;

            Ca = 0.006*Math.Pow(Convert.ToDouble(tbLBP.Text)+100 ,-0.16) - 0.00205 + 0.003 * Math.Sqrt(Convert.ToDouble(tbLBP.Text) / 7.5) * c2* Math.Pow(Convert.ToDouble(tbCb),4)*(0.04-c4);
            Ra = 0.5 * 1.025 *Convert.ToDouble(tbVelocity.Text)*Convert.ToDouble(tbVelocity.Text)*WettedSurfaceArea*Ca;



            R = Rf*(k1)+Rapp+Rw+Rb+Rtr+Ra;



        }

        private void cbAfterbodyForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAfterbodyForm.Text == "V-shaped sections")
                tbCstern.Text= Convert.ToString(-10);
            else
                if (cbAfterbodyForm.Text == "Normal section")
                tbCstern.Text = Convert.ToString(0);
            else
                if (cbAfterbodyForm.Text == "U-shaped sections")
                tbCstern.Text = Convert.ToString(10);
        }

        private void tbCstern_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
