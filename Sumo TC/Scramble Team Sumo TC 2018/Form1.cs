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
        public bool isStartR2 = false;
        public bool isStartR3 = false;
        public bool isStartSF = false;
        public bool nextR = false;
        public bool[] round1 = new bool[16];
        public bool[] round2 = new bool[8];
        public bool[] semiFinal = new bool[4];

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(165, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        public void checkRound()
        {
            int a;

            if (isStartR2 == false)
            {
                for (a = 0; a < 16; a++)
                {
                    if (round1[a] == false)
                    {
                        break;
                    }
                }
                if (a == 16) //tandanya semua true
                {
                    isStartR2 = true;
                    nextR = true;
                    isStart = false;
                    button1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(115)))), ((int)(((byte)(5)))));
                    button1.ForeColor = Color.Maroon;
                    button1.Enabled = true;
                    
                }
            }
            if (isStartR3 == false)
            {
                for (a = 0; a < 8; a++)
                {
                    if (round2[a] == false)
                    {
                        break;
                    }
                }
                if (a == 8) //tandanya semua true
                {
                    isStartR3 = true;
                    nextR = true;
                    isStart = false;
                    button1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(115)))), ((int)(((byte)(5)))));
                    button1.ForeColor = Color.Maroon;
                    button1.Enabled = true;
                    
                }
            }
            if (isStartSF == false)
            {
                for (a = 0; a < 4; a++)
                {
                    if (round2[a] == false)
                    {
                        break;
                    }
                }
                if (a == 4) //tandanya semua true
                {
                    isStartSF = true;
                    nextR = true;
                    isStart = false;
                    button1.BackColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(115)))), ((int)(((byte)(5)))));
                    button1.ForeColor = Color.Maroon;
                    button1.Enabled = true;

                }
            }
        }

        string[] name = new string[32];

        public void button1_Click(object sender, EventArgs e)
        {
            int i;
            

            if (isStart)
            {
                //DRAW button does nothin
            }
            else
            {
                //   this.pictureBox5.Image = global::Scramble_Team_Sumo_TC_2018.Properties.Resources._1;
                //   this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                string temp;
                int range = name.Length;

                if ((isStartR2 == false) && (isStartR3 == false))
                {
                    for (i = 0; i < name.Length; i++)
                    {
                        name[i] = "Team" + " " + (i + 1);
                    }
                }

                if (isStartR2 || isStartR3)
                {
                    if (isStartR2)
                    {
                        range /= 2;
                    }
                    else if (isStartR3)
                    {
                        range /= 4;
                    }
                    else if (isStartSF)
                    {
                        range /= 8;
                    }
                    if (nextR)
                    {
                        //insisasi ulang
                        
                        nextR = false;
                        for (i = 0; i < range; i++)
                        {
                            if (isStartR2 == true)
                            {
                                name[i] = this.Controls["label" + (i + 33).ToString()].Text;
                            }
                            else if (isStartR3 == true)
                            {
                                name[i] = this.Controls["label" + (i + 49).ToString()].Text;
                            }
                        }
                    }                    
                }

                Random rand = new Random();
                for (i = 0; i < range; i++)
                {
                    int j = rand.Next(i, range);
                    temp = name[i];
                    name[i] = name[j];
                    name[j] = temp;

                    if ((isStartR2 == false) && (isStartR3 == false))
                    {
                        this.Controls["label" + (i + 1).ToString()].Text = name[i];
                    }
                    else if (isStartR2)
                    {
                        this.Controls["label" + (i + 33).ToString()].Text = name[i];
                    }
                    else if (isStartR3)
                    {
                        this.Controls["label" + (i + 49).ToString()].Text = name[i];
                    }
                    else if (isStartSF)
                    {
                        this.Controls["label" + (i + 57).ToString()].Text = name[i];
                    }           
                }
            }
        }
        //
        //left tree
        //
        private void label1_Click(object sender, EventArgs e)
        { 
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label33.Text = this.label1.Text;
            round1[0] = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label33.Text = this.label2.Text;
            round1[0] = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label3.Text;
            round1[1] = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.label34.Text = this.label4.Text;
            round1[1] = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label5.Text;
            round1[2] = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.label35.Text = this.label6.Text;
            round1[2] = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label7.Text;
            round1[3] = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.label36.Text = this.label8.Text;
            round1[3] = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label9.Text;
            round1[4] = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.label37.Text = this.label10.Text;
            round1[4] = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label11.Text;
            round1[5] = true; 
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.label38.Text = this.label12.Text;
            round1[5] = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label13.Text;
            round1[6] = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.label39.Text = this.label14.Text;
            round1[6] = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label15.Text;
            round1[7] = true;
            checkRound();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.label40.Text = this.label16.Text;
            round1[7] = true;
            checkRound();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label49.Text = this.label33.Text;
            round2[0] = true;
            isStartR2 = false; //biar ga double logic
            round1[0] = false; //biar ga double logic
        }

        private void label34_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label49.Text = this.label34.Text;
            round2[0] = true;
            isStartR2 = false; //biar ga double logic
            round1[0] = false; //biar ga double logic
        }

        private void label35_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label35.Text;
            round2[1] = true;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            this.label50.Text = this.label36.Text;
            round2[1] = true;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label37.Text;
            round2[2] = true;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            this.label51.Text = this.label38.Text;
            round2[2] = true;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label39.Text;
            round2[3] = true;
            checkRound();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            this.label52.Text = this.label40.Text;
            round2[3] = true;
            checkRound();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label57.Text = this.label49.Text;
        }

        private void label50_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label57.Text = this.label50.Text;
        }

        private void label51_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label58.Text = this.label51.Text;
            semiFinal[0] = true;
            isStartR3 = false; //biar ga double logic
            round2[0] = false; //biar ga double logic
            
            
        }

        private void label52_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label58.Text = this.label52.Text;
            semiFinal[0] = true;
            isStartR3 = false; //biar ga double logic
            round2[0] = false; //biar ga double logic
            
            
        }

        private void label57_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label57.Text;
            semiFinal[1] = true;
            checkRound();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            this.label61.Text = this.label58.Text;
            semiFinal[1] = true;
            checkRound();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            this.label63.Text = this.label61.Text + "\n" + "Hore Menang";
            
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
            round1[8] = true;
        }
        
        private void label18_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label41.Text = this.label18.Text;
            round1[8] = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.label42.Text = this.label19.Text;
            round1[9] = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.label42.Text = this.label20.Text;
            round1[9] = true;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.label43.Text = this.label21.Text;
            round1[10] = true;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.label43.Text = this.label22.Text;
            round1[10] = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.label44.Text = this.label23.Text;
            round1[11] = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            this.label44.Text = this.label24.Text;
            round1[11] = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.label45.Text = this.label25.Text;
            round1[12] = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.label45.Text = this.label26.Text;
            round1[12] = true;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.label46.Text = this.label27.Text;
            round1[13] = true;

        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.label46.Text = this.label28.Text;
            round1[13] = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.label47.Text = this.label29.Text;
            round1[14] = true;   
        }

        private void label30_Click(object sender, EventArgs e)
        {
            this.label47.Text = this.label30.Text;
            round1[14] = true;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            this.label48.Text = this.label31.Text;
            round1[15] = true;
            checkRound();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            this.label48.Text = this.label32.Text;
            round1[15] = true;
            checkRound();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label53.Text = this.label41.Text;
            round2[4] = true;
            isStartR2 = false; //biar ga double logic
            round1[0] = false; //biar ga double logic
        }

        private void label42_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label53.Text = this.label42.Text;
            round2[4] = true;
            isStartR2 = false; //biar ga double logic
            round1[0] = false; //biar ga double logic
        }

        private void label43_Click(object sender, EventArgs e)
        {
            this.label54.Text = this.label43.Text;
            round2[5] = true;
        }

        private void label44_Click(object sender, EventArgs e)
        {
            this.label54.Text = this.label44.Text;
            round2[5] = true;
        }

        private void label45_Click(object sender, EventArgs e)
        {
            this.label55.Text = this.label45.Text;
            round2[6] = true;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            this.label55.Text = this.label46.Text;
            round2[6] = true;
        }

        private void label47_Click(object sender, EventArgs e)
        {
            this.label56.Text = this.label47.Text;
            round2[7] = true;
            checkRound();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            this.label56.Text = this.label48.Text;
            round2[7] = true;
            checkRound();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
            this.label59.Text = this.label53.Text;
        }

        private void label54_Click(object sender, EventArgs e)
        {
            isStart = true;
            button1.BackColor = Color.FromArgb(175, Color.FromArgb(254, 115, 5));
            button1.ForeColor = Color.Black;
            button1.Enabled = false;
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
            this.label63.Text = this.label62.Text + "\n" + "Hore Menang";
            
        }

    }
}