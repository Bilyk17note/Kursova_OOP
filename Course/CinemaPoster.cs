using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    public class CinemaPoster:ClassicPoster
    {
        public string producer { set; get;}
        public string screenwriter { set; get; }

        public CinemaPoster()
        {
            
        }
        public CinemaPoster(string[] mas)
            : base(mas)
       {

           producer = mas[9];
           screenwriter = mas[10];
       }
        public CinemaPoster(DateTime d, DateTime b, string l, string t, string m, int p1, int p2, List<string> lA, List<string> lF,string p,string s)
       :base(d,b,l,t,m,p1,p2,lA,lF)
       {
           producer = p;
           screenwriter = s;
       }
        public override List<string> PosterChar()
        {

            List<string> s = base.PosterChar();
            s.Add(producer);
            s.Add(screenwriter);
            return s;
        }

        public override string FileInfo()
        {
            string s=Convert.ToString(DateTask) + "*" + Convert.ToString(BeginTask) + "*" + Location + "*" + Title + "*"
                + Model + "*" + Convert.ToString(priseMin) + "*" + Convert.ToString(priseMax) + "*";
            if (listActor.Count == 0)
                s += "none";
            else
            {
                s += listActor[0];
                for (int i = 1; i < listActor.Count; i++)
                    s += "|" + listActor[i];
            }
                s += "*";
            if(listFotoName.Count==0)
                s+="none";
            else
            {
                s += listFotoName[0];
                for (int i = 1; i < listFotoName.Count; i++)
                    s += "|" + listFotoName[i];
            }
            s += "*";
            s+=producer + "*"
                + screenwriter;
            return s;
        }
        public override string Info()
        {

            string min = Convert.ToString(BeginTask.Minute);
            if (BeginTask.Minute < 10)
                min = "0" + min;
            string h = Convert.ToString(BeginTask.Hour);
            if (BeginTask.Hour< 10)
                h = "0" + h;
            return "Кіноафіша: " +Environment.NewLine +
                "Дата проведення: " + Convert.ToString(DateTask.Date.Day)+" "+DateShow() + Environment.NewLine +
                "Час проведення: " + h + ":" + min  + Environment.NewLine +
                "Місце проведення: " + Location;
        }
    }
}
