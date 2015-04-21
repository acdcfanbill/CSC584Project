using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ScheduledTechs
    {
        private string name;
        private DateTime date;
        private bool AM;
        private bool PM;
        
        public ScheduledTechs(string name,DateTime date, bool AM, bool PM) 
        {
            this.name = name;
            this.date = date;
            this.AM = AM;
            this.PM = PM;
        }

        public string TechName
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public bool Morning
        {
            get { return AM; }
            set { AM = value; }
        }

        public bool Afternoon
        {
            get { return PM; }
            set { PM = value; }
        }
    }
}
