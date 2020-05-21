using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
   abstract  public class ClassicPoster: Poster
    {
        protected List<string> listActor;
        protected List<string> listFotoName;

        public ClassicPoster()
        {
            listActor = new List<string>();
            listFotoName = new List<string>();
        }

        public List<string> ListActor
        {
            set { listActor = value; }
            get { return listActor; }
        }
        public List<string> ListFotoName
        {
            set { listFotoName = value; }
            get { return listFotoName; }
        }
       public ClassicPoster(string[] mas):base(mas)
       {

           listActor = new List<string>();
           listFotoName = new List<string>();
           string [] sA=mas[7].Split('|');
           for (int i = 0; i < sA.Length; i++)
               listActor.Add(sA[i]);
           sA = mas[8].Split('|');
           for (int i = 0; i < sA.Length; i++)
               listFotoName.Add(sA[i]);
           
       }
       public ClassicPoster(DateTime d, DateTime b, string l, string t, string m, int p1, int p2,List  <string> lA, List  <string> lF)
       :base(d,b,l,t,m,p1,p2)
       {
           listActor = new List<string>();
           for (int i = 0; i < lA.Count; i++)
               listActor.Add(lA[i]);
           listFotoName = new List<string>();
           for (int i = 0; i < lF.Count; i++)
               listFotoName.Add(lF[i]);
       }
       public override List<string> PosterChar()
       {

           List<string> s = base.PosterChar();
           string rez="";
           foreach (string str in listActor)
               rez += str + Environment.NewLine;
           s.Add(rez);
           rez = "";
           foreach (string str in listFotoName)
               rez += str + Environment.NewLine;
           s.Add(rez);
           return s;
       }
    }
}
