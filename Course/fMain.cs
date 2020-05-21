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
    public partial class fMain : Form
    {
        public bool Message { get; set;}
        public List<Poster> MessageList { get; set; }
        int kol = 0;
        public fMain()
        {
            InitializeComponent();
            Message = false;
            MessageList = new List<Poster>();
        }

        private void lMaket_Click(object sender, EventArgs e)
        {

            try
            {
                
                fEditing fE = new fEditing();
                fE.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }

        private void lFind_Click(object sender, EventArgs e)
        { 

            try
            {

                fFind fF = new fFind();
                fF.Owner = this;
                fF.ShowDialog();
                timer1.Enabled = Message;
                kol = 0;
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (MessageList.Count == 0) return;
                fShowPoster fSP = new fShowPoster();
                fSP.Tag = MessageList[kol];
                fSP.ShowDialog();
                kol++;
                if (kol == MessageList.Count) kol = 0;
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
