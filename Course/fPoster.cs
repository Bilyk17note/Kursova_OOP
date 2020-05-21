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
    public partial class fPoster : Form
    {
        public fPoster()
        {
            InitializeComponent();
        }

        

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tBTitle.Text == ""  || tBCountry.Text == "")
            {
                DialogResult = DialogResult.None;
                return;
            }
            fEditing f = Owner as fEditing;
            if (Convert.ToString(Tag) == "tabCCP")
            {
                List<string> list = new List<string>();
                for(int i=0;i<tBActors.Lines.Length;i++)
                    list.Add(tBActors.Lines[i]);

                List<string> listf = new List<string>();
                for(int i=0;i<listBFotos.Items.Count;i++)
                   listf.Add(Convert.ToString(listBFotos.Items[i]));
                f.listCCP.Add(new CinemaPoster(mCData.SelectionStart, dTime.Value, tBCountry.Text, tBTitle.Text, tBModel.Text,
                    Convert.ToInt32(nUpPriseMin.Value), Convert.ToInt32(nUpPriseMax.Value),list ,listf, tBPr.Text, tBCn.Text));
            }
            if (Convert.ToString(Tag) == "tabTCP")
            {
                List<string> list = new List<string>();
                for (int i = 0; i < tBActors.Lines.Length; i++)
                    list.Add(tBActors.Lines[i]);

                List<string> listf = new List<string>();
                for (int i = 0; i < listBFotos.Items.Count; i++)
                    listf.Add(Convert.ToString(listBFotos.Items[i]));
                f.listTCP.Add(new TheaterPoster(mCData.TodayDate, dTime.Value, tBCountry.Text, tBTitle.Text, tBModel.Text,
                    Convert.ToInt32(nUpPriseMin.Value), Convert.ToInt32(nUpPriseMax.Value), list, listf, tBTitleT.Text));
            }       
            if (Convert.ToString(Tag) == "tabCMP")
            {
                 List<string> list = new List<string>();
                for (int i = 0; i < tBMusic.Lines.Length; i++)
                    list.Add(tBMusic.Lines[i]);

                List<string> listf = new List<string>();
                for (int i = 0; i < tBArtist.Lines.Length; i++)
                    listf.Add(Convert.ToString(tBArtist.Lines[i]));
                f.listCMP.Add(new ConcertPoster(mCData.TodayDate, dTime.Value, tBCountry.Text, tBTitle.Text, tBModel.Text,
                    Convert.ToInt32(nUpPriseMin.Value), Convert.ToInt32(nUpPriseMax.Value), list,tBZv.Text,listf));
            }
            if (Convert.ToString(Tag) == "tabDMP")
            {
                List<string> list = new List<string>();
                for (int i = 0; i < tBMusic.Lines.Length; i++)
                    list.Add(tBMusic.Lines[i]);
                f.listDMP.Add(new DiscoPoster(mCData.TodayDate, dTime.Value, tBCountry.Text, tBTitle.Text, tBModel.Text,
                    Convert.ToInt32(nUpPriseMin.Value), Convert.ToInt32(nUpPriseMax.Value), list,tBZv.Text,rBGirl.Checked));
            }
        }

        private void fHRD_Shown(object sender, EventArgs e)
        {
            fEditing f = Owner as fEditing;
            if (Convert.ToString(Tag) == "tabCCP")
            {
                grBMP.Enabled = false;
                grBTCP.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabTCP")
            {
                grBMP.Enabled = false;
                grBCCP.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabCMP")
            {
                grBCP.Enabled = false;
                grBDMP.Enabled = false;
            }
            if (Convert.ToString(Tag) == "tabDMP")
            {
                grBCP.Enabled = false;
                grBCMP.Enabled = false;
            }
            bSave.Visible = !f.flEd;
            bChange.Visible = f.flEd;
            if (!f.flEd) return;
            if (Convert.ToString(Tag) == "tabCCP")
                ShowCCP(f.listCCP, f.n);
            if (Convert.ToString(Tag) == "tabTCP")
                ShowTCP(f.listTCP, f.n);
            if (Convert.ToString(Tag) == "tabCMP")
                ShowCMP(f.listCMP, f.n);
            if (Convert.ToString(Tag) == "tabDMP")
                ShowDMP(f.listDMP, f.n);
            

        }

        void ShowP(List<Poster> list, int k)
        {
            tBTitle.Text = list[k].Title;
            mCData.SelectionStart = list[k].DateTask;
            dTime.Value = list[k].BeginTask;
            nUpPriseMin.Value = Convert.ToDecimal(list[k].PriseMin);
            nUpPriseMax.Value = Convert.ToDecimal(list[k].PriseMax);
            tBCountry.Text = list[k].Location;
            tBModel.Text = list[k].Model;
        }

        void ShowCP(List<Poster> list, int k)
        {
            ClassicPoster pr=list[k] as ClassicPoster;
             tBActors.Lines=pr.ListActor.ToArray();
             for (int i = 0; i < pr.ListFotoName.Count; i++)
                 listBFotos.Items.Add(pr.ListFotoName[i]);
        }
        void ShowCCP(List<Poster> list, int k)
        {
            ShowP(list, k);
            ShowCP(list, k);
            tBPr.Text = (list[k] as CinemaPoster).producer;
            tBCn.Text = (list[k] as CinemaPoster).screenwriter;
        }
        void ShowTCP(List<Poster> list, int k)
        {
            ShowP(list, k);
            ShowCP(list, k);
            tBTitleT.Text = (list[k] as TheaterPoster).TheaterTitle;
        }
        void ShowMP(List<Poster> list, int k)
        {
            MusicPoster pr = list[k] as MusicPoster;
            tBZv.Text = pr.sounding;
            tBMusic.Lines = pr.MusicStyle.ToArray();
        }

        void ShowCMP(List<Poster> list, int k)
        {
            ShowP(list, k);
            ShowMP(list, k);
            tBArtist.Lines = (list[k] as ConcertPoster).ListActor.ToArray();
            
        }
        void ShowDMP(List<Poster> list, int k)
        {
            ShowP(list, k);
            ShowMP(list, k);
            rBGirl.Checked=(list[k] as DiscoPoster).entranceToGirls;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            fEditing f = Owner as fEditing;
            if (Convert.ToString(Tag) == "tabCCP")
                EdCCP(f.listCCP, f.n);
            if (Convert.ToString(Tag) == "tabTCP")
                EdTCP(f.listTCP, f.n);
            if (Convert.ToString(Tag) == "tabCMP")
                EdCMP(f.listCMP, f.n);
            if (Convert.ToString(Tag) == "tabDMP")
                EdDMP(f.listDMP, f.n);
        }

        private void bModel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файли макету|*.mk";
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\Images";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tBModel.Text = Path.GetFileName(openFileDialog1.FileName);
            if (!File.Exists(Application.StartupPath + "\\Images\\" + Path.GetFileName(openFileDialog1.FileName)))
                File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Images\\" + Path.GetFileName(openFileDialog1.FileName));
        }

        private void bAddFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файли фото|*.jpg";
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\Images";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            listBFotos.Items.Add(Path.GetFileName(openFileDialog1.FileName));
            if (!File.Exists(Application.StartupPath + "\\Images\\" + Path.GetFileName(openFileDialog1.FileName)))
                File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Images\\" + Path.GetFileName(openFileDialog1.FileName));
        }

        private void listBFotos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBFotos.SelectedIndex > -1)
                listBFotos.Items.RemoveAt(listBFotos.SelectedIndex);

        }

        private void bDel_Click(object sender, EventArgs e)
        {
            tBModel.Text = "none";
        }
        void EdP(List<Poster> list, int k)
        {
            list[k].Title = tBTitle.Text;
            list[k].DateTask = mCData.SelectionStart;
            list[k].BeginTask = dTime.Value;
            list[k].PriseMin = Convert.ToInt32(nUpPriseMin.Value);
            list[k].PriseMax = Convert.ToInt32(nUpPriseMax.Value);
            list[k].Location = tBCountry.Text;
            list[k].Model = tBModel.Text;
            
        }
        void EdCP(List<Poster> list, int k)
        {
            List<string> rez = new List<string>();
            for (int i = 0; i < tBActors.Lines.Length; i++)
                rez.Add(tBActors.Lines[i]);
            (list[k] as ClassicPoster).ListActor = rez;
            rez = new List<string>();
            for (int i = 0; i < listBFotos.Items.Count; i++)
                rez.Add(Convert.ToString(listBFotos.Items[i]));
            (list[k] as ClassicPoster).ListFotoName = rez;
        }
        void EdCCP(List<Poster> list, int k)
        {
            EdP(list, k);
            EdCP(list, k);
            (list[k] as CinemaPoster).producer=tBPr.Text;
            (list[k] as CinemaPoster).screenwriter = tBCn.Text;
        }
        void EdTCP(List<Poster> list, int k)
        {
            EdP(list, k);
            EdCP(list, k);
            (list[k] as TheaterPoster).TheaterTitle = tBTitleT.Text;
        }
        void EdMP(List<Poster> list, int k)
        {
            List<string> rez = new List<string>();
            for (int i = 0; i < tBMusic.Lines.Length; i++)
                rez.Add(tBMusic.Lines[i]);
            (list[k] as MusicPoster).MusicStyle = rez;
            (list[k] as MusicPoster).sounding = tBZv.Text;

        }

        void EdCMP(List<Poster> list, int k)
        {
            EdP(list, k);
            EdMP(list, k);
            List<string> rez = new List<string>();
            for (int i = 0; i < tBArtist.Lines.Length; i++)
                rez.Add(tBArtist.Lines[i]);
            (list[k] as ConcertPoster).ListActor = rez;
        }
        void EdDMP(List<Poster> list, int k)
        {
            EdP(list, k);
            EdMP(list, k);
            (list[k] as DiscoPoster).entranceToGirls = rBGirl.Checked;
        }
       
    }
}
