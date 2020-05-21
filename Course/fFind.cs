using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Course
{
    public partial class fFind : Form
    {
        public DateTime d1 { get; set; }
        public DateTime d2 { get; set; }
        public bool Notifications { get; set; }
        public bool BoolTime { get; set; }
        public string TypePoster { get; set; }
        public string LocationPoster { get; set; }
        public List<Poster> listCCP { get; set; }
        public List<Poster> listTCP { get; set; }
        public List<Poster> listCMP { get; set; }
        public List<Poster> listDMP { get; set; }

        public fFind()
        {
            InitializeComponent();
            Notifications = false;
            cBType.SelectedIndex = 0;
            listCCP = new List<Poster>();
            listTCP = new List<Poster>();
            listCMP = new List<Poster>();
            listDMP = new List<Poster>();
            ReadFile(listCCP, Application.StartupPath + "\\DBCCP\\" + "CCP.txt", 1);
            ReadFile(listTCP, Application.StartupPath + "\\DBTCP\\" + "TCP.txt", 2);
            ReadFile(listCMP, Application.StartupPath + "\\DBCMP\\" + "CMP.txt", 3);
            ReadFile(listDMP, Application.StartupPath + "\\DBDMP\\" + "DMP.txt", 4);
            ExcbLocation(listCCP);
            ExcbLocation(listTCP);
            ExcbLocation(listCMP);
            ExcbLocation(listDMP);
            LocationPoster = " ";
            d1 = DateTime.Today;
            d2 = DateTime.Today;
            BoolTime = false;
            
        }
        void ReadFile(List<Poster> list, string fileName, int k)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName, enc);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                if (s == "") break;
                string[] mas = s.Split(new char[] { '*' });
                switch (k)
                {
                    case 1: list.Add(new CinemaPoster(mas));
                        break;
                    case 2: list.Add(new TheaterPoster(mas));
                        break;
                    case 3: list.Add(new ConcertPoster(mas));
                        break;
                    case 4: list.Add(new DiscoPoster(mas));
                        break;
                }
            }
            sr.Close();
        }
        private void mCData1_DateChanged(object sender, DateRangeEventArgs e)
        {
            d1 = mCData1.SelectionStart;
        }
       
        private void mCData2_DateChanged(object sender, DateRangeEventArgs e)
        {
            d2 = mCData2.SelectionStart;
        }

        private void cBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypePoster = Convert.ToString(cBType.SelectedItem);
        }

        private void cBLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationPoster = Convert.ToString(cBLocation.SelectedItem);
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            try
            {

                fShowList fSL = new fShowList();
                fSL.Owner = this;
                fSL.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Щось пішло не так :(");
            }
        }

        void ExcbLocation(List <Poster> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (!CH(list[i].Location))
                    cBLocation.Items.Add(list[i].Location);
        }
        bool CH(string s)
        {
            for (int i = 0; i < cBLocation.Items.Count; i++)
                if (s == Convert.ToString(cBLocation.Items[i]))
                    return true;
            return false;
        }

        private void cBTime_Click(object sender, EventArgs e)
        {
            mCData1.Enabled = !mCData1.Enabled;
            mCData2.Enabled = !mCData2.Enabled;
            BoolTime = !BoolTime;
        }

        

        private void chBMessage_Click(object sender, EventArgs e)
        {
            (Owner as fMain).Message = chBMessage.Checked;
            if (!chBMessage.Checked) return;
            List<Poster> list = new List<Poster>();
            foreach (Poster post in listCCP)
                if (post.DateTask.Day == DateTime.Now.Day)
                    list.Add(post);
            foreach (Poster post in listTCP)
                if (post.DateTask.Day == DateTime.Now.Day)
                    list.Add(post);
            foreach (Poster post in listCMP)
                if (post.DateTask.Day == DateTime.Now.Day)
                    list.Add(post);
            foreach (Poster post in listDMP)
                if (post.DateTask.Day == DateTime.Now.Day)
                    list.Add(post);
            (Owner as fMain).MessageList = list;
        }

        private void fFind_Shown(object sender, EventArgs e)
        {
            chBMessage.Checked = (Owner as fMain).Message; 
        }

       

        

       


    }
}
