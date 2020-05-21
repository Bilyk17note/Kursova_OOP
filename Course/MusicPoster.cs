using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    abstract public class MusicPoster: Poster
    {
        protected List<string> musicStyle;
        public string sounding { get; set;}
        public MusicPoster()
        {
            musicStyle = new List<string>();
        }
        public MusicPoster(string[] mas)
            : base(mas)
       {
           musicStyle = new List<string>();
        
           string [] sA=mas[7].Split('|');
           for (int i = 0; i < sA.Length; i++)
               musicStyle.Add(sA[i]);
           sounding = mas[8];
       }
        public MusicPoster(DateTime d, DateTime b, string l, string t, string m, int p1, int p2, List<string> lm, string s)
       :base(d,b,l,t,m,p1,p2)
       {
           musicStyle = new List<string>();
           for (int i = 0; i < lm.Count; i++)
               musicStyle.Add(lm[i]);
           sounding = s;
       }
        public List<string> MusicStyle
        {
            set { musicStyle = value; }
            get { return musicStyle; }
        }
        public override List<string> PosterChar()
        {
            List<string> s = base.PosterChar();
            string rez = "";
            foreach (string str in musicStyle)
                rez += str + Environment.NewLine;
            s.Add(rez);
            s.Add(sounding);

            return s;
        }
    }
}
