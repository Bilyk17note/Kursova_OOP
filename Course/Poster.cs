using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course
{
    abstract public class Poster
    {
        public DateTime DateTask { get; set; }
        public DateTime BeginTask { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Model { get; set; }

        protected int priseMin;
        protected int priseMax;

        public int PriseMin
        {
            get { return priseMin; }
            set { if (value < 0) value = 0; priseMin = value; }
        }
        public int PriseMax
        {
            get { return priseMax; }
            set { if (value < 0) value = 0; priseMax = value; }
        }
        public Poster()
        {
            priseMin = 0;
            priseMax = 0;
            DateTask = DateTime.Now;
            BeginTask = DateTime.Now;
            Location = "Тут може бути Ваша реклама!"; 
            Title = "Тут може бути Ваша реклама!";
            Model = "";
        }
        public Poster(DateTime d,DateTime b,string l,string t,string m, int p1,int p2)
        {
            priseMin = p1;
            PriseMax = p2;
            DateTask = d;
            BeginTask = b;
            Location = l;
            Title = t;
            Model = m;
        }

        public Poster(string[] mas)
       {
          
          DateTask = Convert.ToDateTime(mas[0]);
          BeginTask = Convert.ToDateTime(mas[1]);
           Location = mas[2];
           Title = mas[3];
           Model = mas[4];
           priseMin = Convert.ToInt32(mas[5]);
           priseMax = Convert.ToInt32(mas[6]);
           
       }
        protected string DateShow()
        {
            string m = "";
            switch (DateTask.Date.Month)
            {
                case 1: m = "січня";
                    break;
                case 2: m = "лютого";
                    break;
                case 3: m = "березня";
                    break;
                case 4: m = "квітня";
                    break;
                case 5: m = "травня";
                    break;
                case 6: m = "червня";
                    break;
                case 7: m = "липня";
                    break;
                case 8: m = "серпня";
                    break;
                case 9: m = "вересня";
                    break;
                case 10: m = "жовтня";
                    break;
                case 11: m = "листопада";
                    break;
                case 12: m = "грудня";
                    break;
            }
            return m;
        }
        public virtual List<string> PosterChar()
        {
            string min = Convert.ToString(BeginTask.Minute);
            if (BeginTask.Minute < 10)
                min = "0" + min;
            string h = Convert.ToString(BeginTask.Hour);
            if (BeginTask.Hour < 10)
                h = "0" + h;
            List<string> s = new List<string>();
            s.Add(Convert.ToString(DateTask));
            s.Add(h + ":" + min);
            s.Add(Location);
            s.Add(Title);
            s.Add(Model);
            s.Add(Convert.ToString(priseMin));
            s.Add(Convert.ToString(priseMax));
            return s;
        }
        public abstract string FileInfo();
        public abstract string Info();
    }
}
