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
using System.Globalization;

namespace Footing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            il.Enabled = true;
            lengthl.Enabled = true;
            bl.Enabled = true;
            hl.Enabled = true;
            ll.Enabled = true;
            ltf.Enabled = true;
            btf.Enabled = true;
            htf.Enabled = true;
            lotf.Enabled = true;
            next.Enabled = true;
            v = 0;
            click = 0;
            il.Text = "Fill up Coloumn" + (v + 1) + " field";
            cln = Convert.ToInt16(cn.Text);
            ma = new Material[cln + 2];
            for (int i = 0; i < cln + 2; i++)
                ma[i] = new Material();
            cn.Enabled = false;
            start.Enabled = false;
            v = 1;
            tlc(cln);

        }


        private void next_Click(object sender, EventArgs e)
        {
            
            click++;
                if (v % 2 == 0)
                    il.Text = "Fill up Coloum" + (v + 1) + " field";
                else
                    il.Text = "Fill up Beam" + (v + 1) + " field";
                ma[v].Length = double.Parse(ltf.Text);
                ma[v].B = double.Parse(btf.Text);
                ma[v].H = double.Parse(htf.Text);
                ma[v].Load = double.Parse(lotf.Text);
                v++;
            if (click == cln)
            {
                next.Text = "Footing Processing";
                next.Enabled = false;
                output = "";
               // DateTime td = DateTime.Now;
                //footing = td.ToString();
                //footing = "Footing: " + footing+".txt";
                using (System.IO.File.Create("footing.txt")) ;
                System.IO.File.AppendAllText("footing.txt", "Calculation of footing");
                FootCalc();
            }
           
        }

        private void FootCalc()
        {
            int i,k;
            //Moment of inertia, Stiffness for all
            for (i = 1; i <= cln; i++)
            {
                ma[i].moe = (ma[i].B * Math.Pow(ma[i].H, 3)) / 12;
                ma[i].stiff = ma[i].moe / ma[i].Length;
                
            }
           //Distribution factor for coloumn
            for (i = 1; i <= cln; i += 2)
                ma[i].dfac = ma[i].stiff / (ma[i - 1].stiff + ma[i].stiff + ma[i + 1].stiff);
            //Distribution factor for beam both straight and reverse
            for (i = 2; i <= cln; i += 2)
            {
                ma[i].sdfac = ma[i].stiff / (ma[i].stiff + ma[i - 1].stiff + ma[i - 2].stiff);
                ma[i].rdfac = ma[i].stiff / (ma[i].stiff + ma[i + 1].stiff + ma[i + 2].stiff);
            }
            //Fixed end moment for beam both straight and reverse
            for (i = 2; i <= cln; i += 2)
            {
                ma[i].sfem = (ma[i].Load * Math.Pow(ma[i].Length, 2)) / 12;
                ma[i].rfem = (-1) * ma[i].sfem;
            }
            //Balance for coloumn
            for (i = 1; i <= cln; i += 2)
                ma[i].bl[1] = (ma[i - 1].rfem + ma[i + 1].sfem) *ma[i].dfac * (-1);
            //Balance for beam both straight and reverse
            for (i = 2; i <= cln; i += 2)
            {
                ma[i].sbl[1] = (ma[i - 2].rfem + ma[i].sfem) * ma[i].sdfac * (-1);
                ma[i].rbl[1] = (ma[i].rfem + ma[i + 2].sfem) * ma[i].rdfac * (-1);
            }
            for ( k = 1; k <= 4;k++ )
            {
                //Carry Over Beam both straight and reverse
                for (i = 2; i <= cln; i += 2)
                {
                    ma[i].sco[k] = .5 * ma[i].rbl[k];
                    ma[i].rco[k] = .5 * ma[i].sbl[k];
                }
                //Balance for coloumn
                for (i = 1; i <= cln; i += 2)
                    ma[i].bl[k + 1] = (ma[i - 1].rco[k] + ma[i + 1].sco[k]) * ma[i].dfac * (-1);
                //Balance for beam both straight and reverse
                for (i = 2; i <= cln; i += 2)
                {
                    ma[i].sbl[k + 1] = (ma[i - 2].rco[k] + ma[i].sco[k]) * ma[i].sdfac * (-1);
                    ma[i].rbl[k + 1] = (ma[i].rco[k] + ma[i + 2].sco[k]) * ma[i].rdfac * (-1);
                }
            }

            DataWrite();
            showdata();
           }

        private void DataWrite()
        {
            int i, k;
            for (i = 1; i <= cln; i++)
            {
                if (i % 2 == 0)
                {
                    output = "\n\nBeam" + i + " :\n\n";
                    System.IO.File.AppendAllText("footing.txt", output);
                }
                else
                {
                    output = "\n\nColoumn" + i + " :\n\n";
                    System.IO.File.AppendAllText("footing.txt", output);
                }
                output = "Length = " + ma[i].Length + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "B = " + ma[i].B + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "H = " + ma[i].H + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Load = " + ma[i].Load + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Moment of Enertia = " + ma[i].moe + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Stiffness = " + ma[i].stiff + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Distribution Factor = " + ma[i].dfac + " " + ma[i].sdfac + "  " + ma[i].rdfac + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Fixed End Moment = " + ma[i].sfem + "  " + ma[i].rfem + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                output = "Balance = " + ma[i].bl[1] + "  " + ma[i].sbl[1] + "  " + ma[i].rbl[1] + "\n";
                System.IO.File.AppendAllText("footing.txt", output);
                for (k = 1; k <= 4; k++)
                {
                    output = "Carry Over = " + ma[i].sco[k] + "  " + ma[i].rco[k] + "\n";
                    System.IO.File.AppendAllText("footing.txt", output);
                    output = "Balance = " + ma[i].bl[k + 1] + "  " + ma[i].sbl[k + 1] + "  " + ma[i].rbl[k + 1] + "\n";
                    System.IO.File.AppendAllText("footing.txt", output);

                }
            }
           
        }

        private void tlc(int cln)
        {
            Label[] cl=new Label[cln+1];
            Label[] rl=new Label[18];
            int i;
            this.tableLayoutPanel1.ColumnCount=cln+1;
            for (i = 0; i < (cln + 1); i++)
            {
                cl[i] = new Label();
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            }
            this.tableLayoutPanel1.RowCount=18;
            for (i = 0; i < 18; i++)
            {
                rl[i] = new Label();
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            }
            for (i = 1; i <= cln; i++)
            {
                if (i % 2 != 0)
                    cl[i].Text = "Coloumn";
                else
                    cl[i].Text = "Beam";
                this.tableLayoutPanel1.Controls.Add(cl[i], i, 0);
            }
            rl[1].Text="Length =";
            rl[2].Text = "B =";
            rl[3].Text="H =";
            rl[4].Text="Load =";
            rl[5].Text="Mo. Ener. =";
            rl[6].Text="Stiffness =";
            rl[7].Text="Dis. Fac. =";
            rl[8].Text="Fix end Mo. =";
            rl[9].Text="Balance =";
            rl[10].Text="Carry over =";
            rl[11].Text="Balance =";
            rl[12].Text = "Carry over =";
            rl[13].Text = "Balance =";
            rl[14].Text = "Carry over =";
            rl[15].Text = "Balance =";
            rl[16].Text = "Carry over =";
            rl[17].Text = "Balance =";
            for (i = 1; i <= 17; i++)
                this.tableLayoutPanel1.Controls.Add(rl[i], 0, i);
         }

        private void showdata()
        {
            int i,j;
            for (i = 1; i <= cln; i++)
            {
                Label[] rl = new Label[18];
                for (j = 1; j < 18; j++)
                {
                    rl[j] = new Label();
                    rl[j].AutoSize = true;
                    this.tableLayoutPanel1.Controls.Add(rl[j], i, j);
                }
                rl[1].Text=Convert.ToString( ma[i].Length);
                rl[2].Text = Convert.ToString(ma[i].B);
                rl[3].Text = Convert.ToString(ma[i].H);
                rl[4].Text = Convert.ToString(ma[i].Load);
                rl[5].Text = Convert.ToString(ma[i].moe);
                rl[6].Text = Convert.ToString(ma[i].stiff);
                if (i % 2 != 0)
                {
                    rl[7].Text = Convert.ToString(ma[i].dfac);//distribution factor
                    rl[8].Text = "0";//feo
                    rl[9].Text = Convert.ToString(ma[i].bl[1]);//balance
                    rl[10].Text = "0";
                    rl[11].Text = Convert.ToString(ma[i].bl[2]);
                    rl[12].Text = "0";
                    rl[13].Text = Convert.ToString(ma[i].bl[3]);
                    rl[14].Text = "0";
                    rl[15].Text = Convert.ToString(ma[i].bl[4]);
                    rl[16].Text = "0";
                    rl[17].Text = Convert.ToString(ma[i].bl[5]);

                }
                else
                {
                    rl[7].Text = Convert.ToString(ma[i].sdfac) +" : "+ Convert.ToString(ma[i].rdfac);//distribution factor
                    rl[8].Text = Convert.ToString(ma[i].sfem)+" : "+Convert.ToString(ma[i].rfem);//feo
                    rl[9].Text = Convert.ToString(ma[i].sbl[1])+" : "+Convert.ToString(ma[i].rbl[1]);//balance
                    rl[10].Text = Convert.ToString(ma[i].sco[1])+" : "+Convert.ToString(ma[i].rco[1]);
                    rl[11].Text = Convert.ToString(ma[i].sbl[2]) + " : " + Convert.ToString(ma[i].rbl[2]);
                    rl[12].Text = Convert.ToString(ma[i].sco[2]) + " : " + Convert.ToString(ma[i].rco[2]);
                    rl[13].Text = Convert.ToString(ma[i].sbl[3]) + " : " + Convert.ToString(ma[i].rbl[3]);
                    rl[14].Text = Convert.ToString(ma[i].sco[3]) + ": " + Convert.ToString(ma[i].rco[3]);
                    rl[15].Text = Convert.ToString(ma[i].sbl[4]) + ": " + Convert.ToString(ma[i].rbl[4]);
                    rl[16].Text = Convert.ToString(ma[i].sco[4]) + ": " + Convert.ToString(ma[i].rco[4]);
                    rl[17].Text = Convert.ToString(ma[i].sbl[5]) + " :" + Convert.ToString(ma[i].rbl[5]);
                }


            }
        }
            
            
        }
    }

