using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Course
{
    public partial class fEditing : Form
    {
        
        int x0 = 5;
        int y0=5;
        public bool flEd { get; set; }
        public int n { get; set; }
        Label[] lCCP;
        Label[] lTCP;
        Label[] lCMP;
        Label[] lDMP;
        Label[,] LCCP;
        Label[,] LTCP;
        Label[,] LCMP;
        Label[,] LDMP;




        public List<Poster> listCCP { get; set; }
        public List<Poster> listTCP { get; set; }
        public List<Poster> listCMP { get; set; }
        public List<Poster> listDMP { get; set; }

        

        public fEditing()
        {
            InitializeComponent();

            listCCP = new List<Poster>();
            listTCP = new List<Poster>();
            listCMP = new List<Poster>();
            listDMP = new List<Poster>();
            flEd = false;
        }
        

        private void fEditing_Shown(object sender, EventArgs e)
        {
            
            LabelLocation(lCCP);
            LabelLocation(LCCP,lCCP[0].Location.X,lCCP[0].Location.Y+lCCP[0].Height,listCCP);

            LabelLocation(lTCP);
            LabelLocation(LTCP, lTCP[0].Location.X, lTCP[0].Location.Y + lTCP[0].Height,listTCP);

            LabelLocation(lCMP);
            LabelLocation(LCMP, lCMP[0].Location.X, lCMP[0].Location.Y + lCMP[0].Height, listCMP);

            LabelLocation(lDMP);
            LabelLocation(LDMP, lDMP[0].Location.X, lDMP[0].Location.Y + lDMP[0].Height, listDMP);
        }

        private void fEditing_Load(object sender, EventArgs e)
        {
            ReadFile(listCCP, Application.StartupPath + "\\DBCCP\\" + "CCP.txt",1);
            TableBuilding(ref lCCP, tabCCP, Application.StartupPath + "\\DBCCP\\" + "CCP_Ch.txt");
            ListBuilding(ref LCCP, lCCP, tabCCP, listCCP.Count);

            ReadFile(listTCP, Application.StartupPath + "\\DBTCP\\" + "TCP.txt",2);
            TableBuilding(ref lTCP, tabTCP, Application.StartupPath + "\\DBTCP\\" + "TCP_Ch.txt");
            ListBuilding(ref LTCP, lTCP, tabTCP, listTCP.Count);

            ReadFile(listCMP, Application.StartupPath + "\\DBCMP\\" + "CMP.txt", 3);
            TableBuilding(ref lCMP, tabCMP, Application.StartupPath + "\\DBCMP\\" + "CMP_Ch.txt");
            ListBuilding(ref LCMP, lCMP, tabCMP, listCMP.Count);

            ReadFile(listDMP, Application.StartupPath + "\\DBDMP\\" + "DMP.txt", 4);
            TableBuilding(ref lDMP, tabDMP, Application.StartupPath + "\\DBDMP\\" + "DMP_Ch.txt");
            ListBuilding(ref LDMP, lDMP, tabDMP, listDMP.Count);
            
        }

        void ReadFile(List<Poster> list,string fileName,int k)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName, enc);
            while (!sr.EndOfStream)
            {
                string s=sr.ReadLine();
                if(s=="") break;
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
        void TableBuilding(ref Label [] l,TabPage tab,string fileName)
        {
            List<string> strLab = new List<string>();
            strLab.Add("Нoмер  ** ");
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(fileName,enc);
            while (!sr.EndOfStream)
                strLab.Add(sr.ReadLine());
            sr.Close();
            for (int i = 0; i < strLab.Count; i++)
                        strLab[i] = strLab[i].Replace('*', '\n');
            int n = strLab.Count;
            l = new Label[n];
            for (int i = 0; i < n; i++)
            {
                l[i] = new Label();
                l[i].AutoSize = true;
                l[i].BorderStyle = BorderStyle.FixedSingle;
                l[i].Text = strLab[i];
            }
            tab.Controls.AddRange(l);   
        }
        void LabelLocation(Label[] l)
        {
            l[0].Location = new Point(x0, y0);
            for (int i = 1; i < l.Length; i++)
                l[i].Location = new Point(l[i - 1].Location.X + l[i - 1].Width, y0);          
        }
        void LabelLocation(Label[,] l, int x,int y,List<Poster> list)
        {
            if (list.Count == 0) return;
            int h = l[0, 0].Height;
            for (int i = 0; i < l.GetLength(0); i++)
            {
                l[i, 0].Text = Convert.ToString(i+1);
                l[i, 0].Location = new Point(x, y+i*h);
                l[i,0].MouseDown+=new MouseEventHandler(Label_MouseDown);
                l[i, 0].Tag = i;
                List<string> rez = list[i].PosterChar();
                for (int j = 1; j <l.GetLength(1); j++)
                {
                    l[i, j].Text = rez[j - 1];
                    l[i, j].Location = new Point(l[i, j - 1].Location.X + l[i, j - 1].Width, y + i * h);
                }
            }
        }
        void ListBuilding(ref Label [,] l, Label [] lM,TabPage tab, int n)
        {
            int m = lM.Length;
            if(n==0)
                return;
            l = new Label[n,m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    l[i, j] = new Label();
                    l[i, j].Width = lM[j].Width;
                    l[i, j].BorderStyle = BorderStyle.FixedSingle;
                    tab.Controls.Add(l[i, j]);
                }
        }

  
        private void tabCCP_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabCCP") == DialogResult.OK)
            {
                AddLabel(LCCP, tabCCP);
                ListBuilding(ref LCCP, lCCP, tabCCP, listCCP.Count);
                LabelLocation(LCCP, lCCP[0].Location.X, lCCP[0].Location.Y + lCCP[0].Height, listCCP);
            }
           
        }

        void AddLabel(Label[,] l, TabPage tab)
        {
            if (l == null) return;
             for (int i = 0; i < l.GetLength(0); i++)
                   for (int j = 0; j <l.GetLength(1); j++)
                       tab.Controls.Remove(l[i, j]);
        }

        private void tabTCP_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabTCP") == DialogResult.OK)
            {
                AddLabel(LTCP, tabTCP);
                ListBuilding(ref LTCP, lTCP, tabTCP, listTCP.Count);
                LabelLocation(LTCP, lTCP[0].Location.X, lTCP[0].Location.Y + lTCP[0].Height, listTCP);
            }
        }

        private void tabCMP_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabCMP") == DialogResult.OK)
            {
                AddLabel(LCMP, tabCMP);
                ListBuilding(ref LCMP, lCMP, tabCMP, listCMP.Count);
                LabelLocation(LCMP, lCMP[0].Location.X, lCMP[0].Location.Y + lCMP[0].Height, listCMP);
            }
        }

        private void tabDMP_Click(object sender, EventArgs e)
        {
            flEd = false;
            if (ShowFHD("tabDMP") == DialogResult.OK)
            {
                AddLabel(LDMP, tabDMP);
                ListBuilding(ref LDMP, lDMP, tabDMP, listDMP.Count);
                LabelLocation(LDMP, lDMP[0].Location.X, lDMP[0].Location.Y + lDMP[0].Height, listDMP);
            }
        }

        DialogResult ShowFHD(string s)
        {
            fPoster f = new fPoster();
            f.Tag = s;
            f.Owner = this;
            return f.ShowDialog();
        }

        private void fEditing_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFile(listCCP, Application.StartupPath + "\\DBCCP\\" + "CCP.txt");
            SaveFile(listTCP, Application.StartupPath + "\\DBTCP\\" + "TCP.txt");
            SaveFile(listCMP, Application.StartupPath + "\\DBCMP\\" + "CMP.txt");
            SaveFile(listDMP, Application.StartupPath + "\\DBDMP\\" + "DMP.txt");
        }
        void SaveFile(List<Poster> list, string fileName)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), enc);
            for (int i = 0; i < list.Count; i++)
                sw.WriteLine(list[i].FileInfo());
            sw.Close();
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Хочете видалити запис?", "Запит", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                Label l=sender as Label;
                int k = Convert.ToInt32(l.Tag);
                if (l.Parent == tabCCP)
                    DeleteLabel(k, tabCCP, listCCP, lCCP, ref LCCP);
                if (l.Parent == tabTCP)
                    DeleteLabel(k, tabTCP, listTCP, lTCP, ref LTCP);
                if (l.Parent == tabCMP)
                    DeleteLabel(k, tabCMP, listCMP, lCMP, ref LCMP);
                if (l.Parent == tabDMP)
                    DeleteLabel(k, tabDMP, listDMP, lDMP, ref LDMP);
            }

            if (e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Хочете редагувати запис?", "Запит", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                Label l = sender as Label;
                n = Convert.ToInt32(l.Tag);
                flEd = true;
                if (l.Parent == tabCCP)
                    if (ShowFHD("tabCCP") == DialogResult.OK)
                        EdingLabel(LCCP, listCCP, n);
                if (l.Parent == tabTCP)
                    if (ShowFHD("tabTCP") == DialogResult.OK)
                        EdingLabel(LTCP, listTCP, n);
                if (l.Parent == tabCMP)
                    if (ShowFHD("tabCMP") == DialogResult.OK)
                        EdingLabel(LCMP, listCMP, n);
                if (l.Parent == tabDMP)
                    if (ShowFHD("tabDMP") == DialogResult.OK)
                        EdingLabel(LDMP, listDMP, n);
            }
        }
        void DeleteLabel(int k, TabPage tab, List<Poster> list, Label[] L1D,ref Label[,] L2D)
        {
            list.RemoveAt(k);
            AddLabel(L2D, tab);
            ListBuilding(ref L2D, L1D, tab, list.Count);
            LabelLocation(L2D, L1D[0].Location.X, L1D[0].Location.Y + L1D[0].Height, list);
        }
        void EdingLabel(Label[,] L2D, List<Poster> list,int n)
        {
            List<string> rez = list[n].PosterChar();
            for (int j = 1; j < L2D.GetLength(1); j++)
                L2D[n, j].Text = rez[j - 1];
        }
    }
}
