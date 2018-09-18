using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Footer : PdfPageEventHelper

        {
            public override void OnEndPage(PdfWriter writer, Document doc)

            {
                PdfReader r;
                int k = doc.PageNumber;


                Paragraph footer = new Paragraph(new Phrase("Page  " + k, iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12)));

                footer.Alignment = Element.ALIGN_CENTER;

                PdfPTable footerTbl = new PdfPTable(1);

                footerTbl.TotalWidth = 300;

                footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell cell = new PdfPCell(footer);

                cell.Border = 0;

                cell.PaddingLeft = 10;

                footerTbl.AddCell(cell);

                footerTbl.WriteSelectedRows(0, -1, 240, 30, writer.DirectContent);

            }
        }
            private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            double T,Reyno=0,Lr=0,Cf,k2=0,Ca=0;
            double c1, c2, c3, c4, c5, c6, c7=0, c8, c9, c10, c11, c12=0, c13, c14, c15, c16, c17, c18, c19, c20;
            double Rf=0, Rapp=0, Rw=0, Rb=0, Rtr=0, Ra=0,R=0,k1=0,WettedSurfaceArea=0,Fnt=0;
            T = (Convert.ToSingle(tbTAP.Text) + Convert.ToSingle(tbTFP.Text)) / 2;
            double v =0.00000118 ;
            Reyno = Convert.ToDouble(tbVelocity.Text) * Convert.ToDouble(tbLBP.Text) / v; ;

            c7 = 0;
            double iE = 0;
            iE =1+89*Math.Exp(-1* Math.Pow(Convert.ToDouble(tbLBP.Text)/ Convert.ToDouble(tbB.Text), 0.80856 ) * Math.Pow(1-Convert.ToDouble(tbCwp.Text),0.30484) *Math.Pow((1-Convert.ToDouble(tbCp.Text)-0.0225*Convert.ToDouble(tbLBP.Text)),0.6367) * Math.Pow( ( Lr/Convert.ToDouble(tbB.Text) ) , 0.34574) ) * Math.Pow( 100*Convert.ToDouble(tbVdisp)/Math.Pow(Convert.ToDouble(tbLBP.Text),3) , 0.16302);

            c3 =0;
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


            c1 = 2223105 * Math.Pow(c7, 3.78613) * Math.Pow(T/Convert.ToDouble(tbB.Text),1.07961)*Math.Pow(90-iE,-1.37565);
           
            if (T / Convert.ToSingle(tbLBP.Text) > 0.05)
                c12 = Math.Pow(  (T/Convert.ToDouble(tbLBP.Text)) ,0.2228446);
            else
                if (T / Convert.ToSingle(tbLBP.Text) < 0.05)
                c12 =48.20 * Math.Pow((T / Convert.ToDouble(tbLBP.Text))-0.02, 2.078) +0.479948;
            else
                if (T / Convert.ToSingle(tbLBP.Text) < 0.02)
                c12 =0.479948;

            c13 =1+0.003*Convert.ToSingle(tbCstern.Text);
          
            Lr = Convert.ToDouble(tbLBP.Text) * ( 1-Convert.ToDouble(tbCp.Text) + 0.06 * Convert.ToDouble(tbCp.Text) * Convert.ToDouble(tbLCB.Text)) / (4*Convert.ToDouble(tbCp.Text) -1)  ;

            k1 = c13 *(0.93+c12*Math.Pow(Convert.ToDouble(tbB.Text)/Lr,0.92497)) * Math.Pow(0.95-Convert.ToDouble(tbCp.Text), -0.521448) * Math.Pow(1- Convert.ToDouble(tbCp.Text)+0.0225*Convert.ToDouble(tbLCB.Text) , 0.6906);

            /////////////////////////////////////////
            k2 = 1.5;

            Cf = 0.075 /(Math.Pow( (Math.Log10(Reyno)-2),2));

            WettedSurfaceArea = Convert.ToDouble(tbLBP.Text)*(2*T+Convert.ToDouble(tbB.Text) ) * Math.Sqrt(Convert.ToDouble(tbCm.Text)) * (0.453+0.4425* Convert.ToDouble(tbCb.Text) ) -0.2862 * Convert.ToDouble(tbCm.Text) - 0.003467 * Convert.ToDouble(tbB.Text)/ Convert.ToDouble(T) + 0.3696* Convert.ToDouble(tbCwp.Text)+2.38* Convert.ToDouble(tbAbt.Text)/Convert.ToDouble(tbCb.Text);

            Rapp = 0.5* 1.025* Convert.ToDouble(tbVelocity.Text)* Convert.ToDouble(tbVelocity.Text)* Convert.ToDouble(tbWettedAreaApp.Text)*Cf*k2;

            double m1=0, m2=0, lambda=0, Fni=0,Fn=0,Pb=0;
            c16 = 0;
            if (Convert.ToDouble(tbCp.Text) < 0.8)
               c16=8.07981* Convert.ToDouble(tbCp.Text)-13.8673* Math.Pow(Convert.ToDouble(tbCp.Text),2)+6.984388* Math.Pow(Convert.ToDouble(tbCp.Text), 3);
            else
                     if (Convert.ToDouble(tbCp.Text) < 0.8)
              c16 =  1.73014-0.7067* Convert.ToDouble(tbCp.Text);

            m1 = 0.0141407 * Convert.ToDouble(tbLBP.Text)/T - 1.75254*Math.Pow(Convert.ToDouble(tbVdisp.Text),0.333) / Convert.ToDouble(tbLBP.Text)  - 4.79323 * (Convert.ToDouble(tbB.Text) / Convert.ToDouble(tbLBP.Text)) - c16;
            c15 = -1.69385 +( (Convert.ToDouble(tbLBP.Text)/Convert.ToDouble(tbVdisp.Text))-8.0) / 2.36    ;
            if(Convert.ToDouble(tbLBP.Text)/Convert.ToDouble(tbB.Text) <12 )
                 lambda =1.446* Convert.ToDouble(tbCp.Text)-0.03* (Convert.ToDouble(tbLBP.Text) / Convert.ToDouble(tbB.Text)) ;
            else
                           if (Convert.ToDouble(tbLBP.Text) / Convert.ToDouble(tbB.Text) > 12)
                             lambda = lambda = 1.446 * Convert.ToDouble(tbCp.Text) - 0.36;

            Fni = Convert.ToDouble(tbVelocity.Text) / Math.Sqrt(9.81*(Convert.ToDouble(tbTFP.Text)- Convert.ToDouble(tbhb.Text)-0.25*Math.Pow( Convert.ToDouble(tbAbt.Text),0.5) +0.15* Convert.ToDouble(tbVelocity.Text)* Convert.ToDouble(tbVelocity.Text)))  ;

            Rw = c1*c2*c5* Convert.ToDouble(tbVdisp.Text) * 1.025*9.81*Math.Exp(m1*Math.Pow(Fn,0.9)+m2*Math.Cos(lambda*Math.Pow(Fn,-2)));

            Pb = 0.56 * Math.Pow(Convert.ToDouble(tbAbt.Text), 0.5) / (Convert.ToDouble(tbTFP.Text)-1.5*Convert.ToDouble(tbhb.Text));

            Rb =0.11*Math.Exp(-3*Math.Pow(Pb,-2))*Math.Pow(Fni,3)*Math.Pow(Convert.ToDouble(tbAbt.Text),1.5)*1.025*9.81/(1+Math.Pow( Fni,2)) ;

            c4 = 0;
            if (Convert.ToDouble(tbTFP.Text)/Convert.ToDouble(tbLBP.Text) <=0.04)
                c4 = Convert.ToDouble(tbTFP.Text) / Convert.ToDouble(tbLBP.Text);
            if (Convert.ToDouble(tbTFP.Text) / Convert.ToDouble(tbLBP.Text) > 0.04)
                c4 =0.04  ;



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

        private void btngeneratereport_Click(object sender, EventArgs e)
        {
            string fvessel;
            fvessel = "D://"+ tbVESSELID.Text+".pdf";
            Document doc = new Document(PageSize.A4,60,60,80,40);
            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(fvessel,FileMode.Create));
            writer.PageEvent = new Footer();
            doc.Open();
            
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 14);
            iTextSharp.text.Font font6 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            iTextSharp.text.Font font7 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12);
            iTextSharp.text.Font font8 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            iTextSharp.text.Font font9 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);

            Paragraph prgheading = new Paragraph();
            prgheading.Alignment = Element.ALIGN_CENTER;
            prgheading.Add(new Chunk("RESISTENCE CALCULATIONS", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 28)));
            doc.Add(prgheading);

            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLUE, Element.ALIGN_LEFT, 0.0F)));
            doc.Add(line);

            doc.Add(new Chunk("\n", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA)));

            doc.Add(new Chunk("Main Particulars", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            doc.Add(new Chunk("\n", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA)));

            PdfPTable t = new PdfPTable(2);
            t.HorizontalAlignment = 0;
            t.WidthPercentage = 45;

            PdfPCell cell1 = new PdfPCell(new Phrase("LBP" + "(m)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbLBP.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("LWL" + "(m)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbLWL.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("B(mld)" + "(m)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbB.Text, font7));
            t.AddCell(cell1);

            double T=0;
            T = ( Convert.ToDouble(tbTAP.Text) + Convert.ToDouble(tbTFP.Text) ) / 2;
            cell1 = new PdfPCell(new Phrase("T(avg)" + "(m)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(Convert.ToString(T), font7));
            t.AddCell(cell1);

           
            cell1 = new PdfPCell(new Phrase("Volume disp.", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbVdisp.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Cb.", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbCb.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Cp.", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbCp.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Cm.", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbCm.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Cw", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbCwp.Text, font7));
            t.AddCell(cell1);

            doc.Add(new Chunk("\n", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA)));

            Paragraph p1 = new Paragraph();
            p1.Alignment = Element.ALIGN_LEFT;
            p1.Add(new Chunk("Results", font9));
            doc.Add(p1);
            doc.Add(new Chunk("\n", iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12)));

            t = new PdfPTable(2);
            t.HorizontalAlignment = 0;
            t.WidthPercentage = 45;

            cell1 = new PdfPCell(new Phrase("Frictional Resistance", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbfrictional.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Wave Making Resistance", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbwavemaking.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Appendage Resistance", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbappendageresis.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Added Pressure Resistance(Bow)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbpressureresisbow.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Added Presure Resistance(Stern)", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase(tbpressureresisstern.Text, font7));
            t.AddCell(cell1);

            cell1 = new PdfPCell(new Phrase("Wetted Surface Area", font8));
            cell1.Colspan = 1;
            t.AddCell(cell1);
            double WettedSurfaceArea = 0;
            WettedSurfaceArea = Convert.ToDouble(tbLBP.Text) * (2 * T + Convert.ToDouble(tbB.Text)) * Math.Sqrt(Convert.ToDouble(tbCm.Text)) * (0.453 + 0.4425 * Convert.ToDouble(tbCb.Text)) - 0.2862 * Convert.ToDouble(tbCm.Text) - 0.003467 * Convert.ToDouble(tbB.Text) / Convert.ToDouble(T) + 0.3696 * Convert.ToDouble(tbCwp.Text) + 2.38 * Convert.ToDouble(tbAbt.Text) / Convert.ToDouble(tbCb.Text);
            cell1 = new PdfPCell(new Phrase(Convert.ToString(WettedSurfaceArea), font7));
            t.AddCell(cell1);

            doc.Close();
            writer.Close();

            Process process1 = new Process();
            process1.StartInfo = new ProcessStartInfo(fvessel);
            process1.Start();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbie.Checked)
            { tbie.Visible = false; }
            else
            { tbie.Visible = true; }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void gbINPUTS_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbLBP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
