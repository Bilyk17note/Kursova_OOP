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
    public partial class fShowList : Form
    {
        
        fFind myOwner;
        int x0 = 5;
        int y0 = 0;
        int kx = 0, ky = 0;
        int x = 0, y = 0;
        int lx = 300;
        int ly = 180;

        public fShowList()
        {
            InitializeComponent();
           
        }

        private void fShowList_Load(object sender, EventArgs e)
        {
            myOwner = Owner as fFind;
           
        }
       
        void LocationList(List<Poster> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (x + 2 * lx > this.ClientSize.Width)
                {
                    kx = 0;
                    ky++;

                }
                x = x0 + kx * (lx + 15);
                y = y0 + ky * (ly + 15);
                if (Add(new Point(x, y), list[i]))
                    kx++;
            }
        }
        public bool Add(Point Pos, Poster hrd)
        {
            int x0 = 5;
            int y0 = 5;
            if ((myOwner.LocationPoster != " ") && (myOwner.LocationPoster != hrd.Location))
                return false;
            if (myOwner.BoolTime && (hrd.DateTask < myOwner.d1 || hrd.DateTask > myOwner.d2))
                return false;
                Panel p = new Panel();
                Label lR = new Label();
                p.Location = Pos;
                p.Font = new Font("Segoe Print", 12);
                lR.Location = new Point(x0, y0);
                lR.ForeColor = Color.Black;
                lR.Text = hrd.Info();
                lR.Size = new Size(lx, ly);
                lR.Click+=new EventHandler(p_Click);
                lR.Tag = hrd;
                p.Controls.Add(lR);
                p.AutoSize = true;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Tag = hrd;
                p.Click+=new EventHandler(p_Click);
                Controls.Add(p);
                return true;
         

        }
        private void p_Click(object sender, EventArgs e)
        {
            try
            {

                fShowPoster fSP = new fShowPoster();
                fSP.Tag = (sender as Control).Tag;
                fSP.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }
        private void fShowList_Shown(object sender, EventArgs e)
        {
            if (myOwner.TypePoster == "Кіно")
            {
                LocationList(myOwner.listCCP);
                return;
            }
            if (myOwner.TypePoster == "Театральна вистава")
            {
                LocationList(myOwner.listTCP);
                return;
            }
            if (myOwner.TypePoster == "Концерт")
            {

                LocationList(myOwner.listCMP);
                return;
            }
            if (myOwner.TypePoster == "Дискотека")
            {
                LocationList(myOwner.listDMP);
                return;
            }
            LocationList(myOwner.listCCP);
            LocationList(myOwner.listTCP);
            LocationList(myOwner.listCMP);
            LocationList(myOwner.listDMP);
        }
    }
}
