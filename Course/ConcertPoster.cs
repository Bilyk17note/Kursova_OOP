using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    public class ConcertPoster: MusicPoster
    {
        protected List<string> listActor;
        public List<string> ListActor
        {
            set { listActor = value; }
            get { return listActor; }
        }
        public ConcertPoster()
        {
            listActor = new List<string>();
            
        }
        public ConcertPoster(string[] mas)
            : base(mas)
       {

           listActor = new List<string>();         
           string [] sA=mas[9].Split('|');
           for (int i = 0; i < sA.Length; i++)
               listActor.Add(sA[i]);
           
           
       }
        public ConcertPoster(DateTime d, DateTime b, string l, string t, string m, int p1, int p2, List<string> lm, string s, List<string> lA)
       :base(d,b,l,t,m,p1,p2,lm,s)
       {
           listActor = new List<string>();
           for (int i = 0; i < lA.Count; i++)
               listActor.Add(lA[i]);
           
       }
        public override string FileInfo()
        {
            string s = Convert.ToString(DateTask) + "*" + Convert.ToString(BeginTask) + "*" + Location + "*" + Title + "*"
                + Model + "*" + Convert.ToString(priseMin) + "*" + Convert.ToString(priseMax) + "*";

            if (MusicStyle.Count == 0)
                s += "none";
            else
            {
                s += MusicStyle[0];
                for (int i = 1; i < MusicStyle.Count; i++)
                    s += "|" + MusicStyle[i];
            }
             s += "*";

             s += sounding + "*";

            if (listActor.Count == 0)
                s += "none";
            else
            {
                s += listActor[0];
                for (int i = 1; i < listActor.Count; i++)
                    s += "|" + listActor[i];
            }
            
            return s;
        }
        public override List<string> PosterChar()
        {

            List<string> s = base.PosterChar();

            string rez = "";
            foreach (string str in listActor)
                rez += str + Environment.NewLine;
            s.Add(rez);
            return s;
        }
        public override string Info()
        {
            string min = Convert.ToString(BeginTask.Minute);
            if (BeginTask.Minute < 10)
                min = "0" + min;
            string h = Convert.ToString(BeginTask.Hour);
            if (BeginTask.Hour < 10)
                h = "0" + h;
            return "Концерт: " + Environment.NewLine +
                "Дата проведення: " + Convert.ToString(DateTask.Date.Day) + " " + DateShow() + Environment.NewLine +
                "Час проведення: " + h+ ":" + min + Environment.NewLine +
                "Місце проведення: " + Location;
        }
    }
}
