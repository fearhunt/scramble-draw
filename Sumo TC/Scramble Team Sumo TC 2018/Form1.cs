using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Team_TC_Label
{
    public partial class Form1 : Form
    {
        public bool isStart = false;

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(165, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Label[] labels = new Label[63];
       // public labels = new System.Windows.Forms.Label[63];
        private void MyForm_Load(object sender, EventArgs e)
        {
            
            for (int a = 0; a < 63; a++)
            {    
                labels[a] = new System.Windows.Forms.Label();
            }
           // labels[0] = this.label1;
            labels[1] = this.label2;
            labels[2] = this.label3;
            labels[3] = this.label4;
            labels[4] = this.label5;
            labels[5] = this.label6;
            labels[6] = this.label7;
            labels[7] = this.label8;
            labels[8] = this.label9;
            labels[9] = this.label10;
            labels[10] = this.label11;
            labels[11] = this.label12;
            labels[12] = this.label13;
            labels[13] = this.label14;
            labels[14] = this.label15;
            labels[15] = this.label16;
            labels[16] = this.label17;
            labels[17] = this.label18;
            labels[18] = this.label19;
            labels[19] = this.label20;
            labels[20] = this.label21;
            labels[21] = this.label22;
            labels[22] = this.label23;
            labels[23] = this.label24;
            labels[24] = this.label25;
            labels[25] = this.label26;
            labels[26] = this.label27;
            labels[27] = this.label28;
            labels[28] = this.label29;
            labels[29] = this.label30;
            labels[30] = this.label31;
            labels[31] = this.label32;
            labels[32] = this.label33;
            labels[33] = this.label34;
            labels[34] = this.label35;
            labels[35] = this.label36;
            labels[36] = this.label37;
            labels[37] = this.label38;
            labels[38] = this.label39;
            labels[39] = this.label40;
            labels[40] = this.label41;
            labels[41] = this.label42;
            labels[42] = this.label43;
            labels[43] = this.label44;
            labels[44] = this.label45;
            labels[45] = this.label46;
            labels[46] = this.label47;
            labels[47] = this.label48;
            labels[48] = this.label49;
            labels[49] = this.label50;
            labels[50] = this.label51;
            labels[51] = this.label52;
            labels[52] = this.label53;
            labels[53] = this.label54;
            labels[54] = this.label55;
            labels[55] = this.label56;
            labels[56] = this.label57;
            labels[57] = this.label58;
            labels[58] = this.label59;
            labels[59] = this.label60;
            labels[60] = this.label61;
            labels[61] = this.label62;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Yakin ingin keluar dari Scramble Draw?";
            string title = "Close";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
        //convert to image 
        //public void convertImage(string[] name)
        //{
        //    string temp;
        //    int tempNum;

        //    for (int a = 0; a < 32; a++)
        //    {
        //        temp = temp.Remove(0, 5);
        //        tempNum = Convert.ToInt32(temp);

        //        //backgrund
        //    }
        //}

        public void button1_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                //DRAW button does nothin
            }
            else
            {
                string temp;
                string[] name = new string[32];

                for (int i = 0; i < name.Length; i++)
                {
                    name[i] = "Team" + " " + (i + 1);
                }
                Random rand = new Random();
                for (int i = 0; i < name.Length; i++)
                {
                    int j = rand.Next(i, name.Length);
                    temp = name[i];
                    name[i] = name[j];
                    name[j] = temp;
                }
                //convertImage(name);

                // ___ERROR__
                // labels[1].Text = name[0]; masih error
                // labels[] is null
                // ___END ERROR___

                int n = 2;
                this.Controls["label" + n.ToString()].Text = "Test";
                //this.label1.Text = name[0]; ------------> sudah dihaoys 

                //this.label2.Text = name[1];
                //this.label2.BackgroundImage = global::Scramble_Team_Sumo_TC_2018.Properties.Resources.bl1;
                //this.label2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                //this.label3.Text = name[2];

                //this.label4.Text = name[3];

                //this.label5.Text = name[4];

                //this.label6.Text = name[5];

                //this.label7.Text = name[6];

                //this.label8.Text = name[7];

                //this.label9.Text = name[8];

                //this.label10.Text = name[9];

                //this.label11.Text = name[10];

                //this.label12.Text = name[11];

                //this.label13.Text = name[12];

                //this.label14.Text = name[13];
                //this.label15.Text = name[14];

                //this.label16.Text = name[15];

                //this.label17.Text = name[16];

                //this.label18.Text = name[17];

                //this.label19.Text = name[18];


                //this.label20.Text = name[19];


                //this.label21.Text = name[20];


                //this.label22.Text = name[21];


                //this.label23.Text = name[22];


                //this.label24.Text = name[23];


                //this.label25.Text = name[24];


                //this.label26.Text = name[25];


                //this.label27.Text = name[26];


                //this.label28.Text = name[27];


                //this.label29.Text = name[28];


                //this.label30.Text = name[29];


                //this.label31.Text = name[30];


                //this.label32.Text = name[31];
            }
        }
        //
        //left tree
        //
        //private void label1_Click(object sender, EventArgs e)
        //{ 
        //    isStart = true;
        //    button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
        //    button1.ForeColor = Color.Black;
        //    button1.Enabled = false;
        //    this.label33.Text = this.label1.Text;
            
        //}

        private void label2_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label33.Text = this.label2.Text;
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label3.Text;
            
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label4.Text;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label5.Text;
         
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label6.Text;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label7.Text;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label8.Text;
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label9.Text;
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label10.Text;
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label11.Text;
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label12.Text;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label13.Text;
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label14.Text;
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label15.Text;
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label16.Text;
            
        }

        private void label33_Click(object sender, EventArgs e)
        {
            this.label49.Text = this.label33.Text;
            
        }

        private void label34_Click(object sender, EventArgs e)
        {
            this.label49.Text = this.label34.Text;
            
        }

        private void label35_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label35.Text;
            
        }

        private void label36_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label36.Text;
            
        }

        private void label37_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label37.Text;
            
        }

        private void label38_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label38.Text;
            
        }

        private void label39_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label39.Text;
            
        }

        private void label40_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label40.Text;
            
        }

        private void label49_Click(object sender, EventArgs e)
        {
            this.label57.Text = this.label49.Text;
            
        }

        private void label50_Click(object sender, EventArgs e)
        {
            this.label57.Text = this.label50.Text;
            
        }

        private void label51_Click(object sender, EventArgs e)
        {
            this.label58.Text = this.label51.Text;
            
        }

        private void label52_Click(object sender, EventArgs e)
        {
            this.label58.Text = this.label52.Text;
            
        }

        private void label57_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label57.Text;
            
        }

        private void label58_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label58.Text;
            
        }

        private void label61_Click(object sender, EventArgs e)
        {
         //   this.label63.Text = this.label61.Text + "\n" + "Hore Menang";
            
        }
        //
        //right tree
        //
        private void label17_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label41.Text = this.label17.Text;
            
        }
        
        private void label18_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label41.Text = this.label18.Text;
            
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.label42.Text = this.label19.Text;
            
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.label42.Text = this.label20.Text;
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.label43.Text = this.label21.Text;
            
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.label43.Text = this.label22.Text;
            
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.label44.Text = this.label23.Text;
            
        }

        private void label24_Click(object sender, EventArgs e)
        {
            this.label44.Text = this.label24.Text;
            
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.label45.Text = this.label25.Text;
            
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.label45.Text = this.label26.Text;
            
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.label46.Text = this.label27.Text;
            
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.label46.Text = this.label28.Text;
            
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.label47.Text = this.label29.Text;
            
        }

        private void label30_Click(object sender, EventArgs e)
        {
            this.label47.Text = this.label30.Text;
            
        }

        private void label31_Click(object sender, EventArgs e)
        {
            this.label48.Text = this.label31.Text;
            
        }

        private void label32_Click(object sender, EventArgs e)
        {
            this.label48.Text = this.label32.Text;
            
        }

        private void label41_Click(object sender, EventArgs e)
        {
            this.label53.Text = this.label41.Text;
            
        }

        private void label42_Click(object sender, EventArgs e)
        {
            this.label53.Text = this.label42.Text;
            
        }

        private void label43_Click(object sender, EventArgs e)
        {
            this.label54.Text = this.label43.Text;
            
        }

        private void label44_Click(object sender, EventArgs e)
        {
            this.label54.Text = this.label44.Text;
            
        }

        private void label45_Click(object sender, EventArgs e)
        {
            this.label55.Text = this.label45.Text;
            
        }

        private void label46_Click(object sender, EventArgs e)
        {
            this.label55.Text = this.label46.Text;
            
        }

        private void label47_Click(object sender, EventArgs e)
        {
            this.label56.Text = this.label47.Text;
            
        }

        private void label48_Click(object sender, EventArgs e)
        {
            this.label56.Text = this.label48.Text;
            
        }

        private void label53_Click(object sender, EventArgs e)
        {
            this.label59.Text = this.label53.Text;
            
        }

        private void label54_Click(object sender, EventArgs e)
        {
            this.label59.Text = this.label54.Text;
            
        }

        private void label55_Click(object sender, EventArgs e)
        {
            this.label60.Text = this.label55.Text;
            
        }

        private void label56_Click(object sender, EventArgs e)
        {
            this.label60.Text = this.label56.Text;
            
        }

        private void label59_Click(object sender, EventArgs e)
        {
            this.label62.Text = this.label59.Text;
            
        }

        private void label60_Click(object sender, EventArgs e)
        {
            this.label62.Text = this.label60.Text;
            
        }

        private void label62_Click(object sender, EventArgs e)
        {
      //      this.label63.Text = this.label62.Text + "\n" + "Hore Menang";
            
        }
    }
}