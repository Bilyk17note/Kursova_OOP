using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    public class DiscoPoster:MusicPoster
    {
        public bool entranceToGirls { get; set; }
        public DiscoPoster()
        {
            entranceToGirls = true;
        }
        public DiscoPoster(string[] mas)
            : base(mas)
       {

           entranceToGirls = Convert.ToBoolean(mas[9]);
           
       }
        public DiscoPoster(DateTime d, DateTime b, string l, string t, string m, int p1, int p2, List<string> lm, string s,bool e)
       :base(d,b,l,t,m,p1,p2,lm,s)
       {
           entranceToGirls = e;
           
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

            s += Convert.ToString(entranceToGirls);

            return s;
        }
        public override List<string> PosterChar()
        {

            List<string> s = base.PosterChar();
            s.Add(Convert.ToString(entranceToGirls));
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
            return "Дискотека: " + Environment.NewLine +
                "Дата проведення: " + Convert.ToString(DateTask.Date.Day) + " " + DateShow() + Environment.NewLine +
                "Час проведення: " + h + ":" + min + Environment.NewLine +
                "Місце проведення: " + Location;
        }
    }
}
