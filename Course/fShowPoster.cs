using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course
{
    public partial class fShowPoster : Form
    {
        public fShowPoster()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void fShowPoster_Shown(object sender, EventArgs e)
        {
            List <string> rez=(Tag as Poster).PosterChar();
            lDate.Text = "Дата проведення:\n"+rez[0].Split(' ')[0];
            lTime.Text = "Час проведення:\n"+rez[1];
            lLocation.Text = "Місце проведення:\n"+rez[2];
            lTitle.Text=rez[3];
            lPrise.Text = "Наші ціни: " + rez[5] + " - " + rez[6];
            if (rez[4] != "none")
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\"+rez[4]);
            }
            if (Tag is CinemaPoster || Tag is TheaterPoster)
            {
                if (rez[7] != "" && rez[7] != null && rez[7] != "none\r\n")
                {
                    lArt.Visible = true;
                    lArt.Text = "Наші актори:\n" + rez[7];
                }
                if (rez[8] != "" && rez[8] != null && rez[8] != "none\r\n")
                {
                    string[] adr = rez[8].Split(new char []{ '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    int k=adr.Length;
                    if(k!=0)
                    {
                    PictureBox [] masPic=new PictureBox[k];
                    for (int i = 0; i < k; i++)
                    {
                        masPic[i] = new PictureBox();
                        masPic[i].ImageLocation = Application.StartupPath + "\\Images\\" + adr[i];
                        masPic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        masPic[i].Location = new Point(10+50*i, this.Height-70);
                        masPic[i].Size = new Size(50, 50);
                        masPic[i].Load();
                    }
                    this.Controls.AddRange(masPic);
                    }

                }
            }
            if (Tag is CinemaPoster)
            {
                if (rez[9] != "" && rez[9] != null && rez[9] != "none\r\n")
                {
                    lPr.Visible = true;
                    lPr.Text = "Продюсер:\n" + rez[9];
                }
                if (rez[10] != "" && rez[10] != null)
                {
                    lScreen.Visible = true;
                    lScreen.Text = "Сценарист:\n" + rez[10];
                }
            }
            if (Tag is TheaterPoster)
            {
                if (rez[9] != "" && rez[9] != null && rez[9] != "none\r\n")
                {
                    lPr.Visible = true;
                    lPr.Text = "Театр:\n" + rez[9];
                }  
            }
            if (Tag is ConcertPoster || Tag is DiscoPoster)
            {
                if (rez[7] != "" && rez[7] != null && rez[7] != "none\r\n")
                {
                    lArt.Visible = true;
                    lArt.Text = "Наша музика:\n" + rez[7];
                }
                if (rez[8] != "" && rez[8] != null /*&& rez[8] != "none\r\n"*/)
                {
                    lPr.Visible = true;
                    lPr.Text = "Звучання:\n" + rez[8];
                }  
            }
            if (Tag is ConcertPoster)
            {
                if (rez[9] != "" && rez[9] != null && rez[9] != "none\r\n")
                {
                    lScreen.Visible = true;
                    lScreen.Text = "Артисти:\n" + rez[9];
                }
            }
            if (Tag is DiscoPoster)
            {
               
                if (Convert.ToBoolean(rez[9]))
                { lScreen.Visible = true;
                    
                    lScreen.Text = "Дівчата вхід вільний";
                }
               
            }

        }

        private void fShowPoster_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }


    }
}
