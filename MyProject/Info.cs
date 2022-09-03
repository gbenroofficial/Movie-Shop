using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    using System.ComponentModel;
    public class Info:INotifyPropertyChanged
    {
        private string movieName;
        private string movieYear = "2020";
        private string movieInfo = "The story follows the life of a young programmer trying to get his assignment done and submitted before the deadline";
        private string runTime = "2";
        private string cast = "David Baumann, Alicia Stevens, Russel Blake, Dave Carrington, Aurora Davis, Michael Flynn, Oliver Jameson";
        private double ppd;
        private double days = 1;
       
         
        public string MovieName { get => movieName; set => movieName = value; }
        public string MovieYear { get => movieYear; set => movieYear = value; }
        public string MovieInfo { get => movieInfo; set => movieInfo = value; }
        public string RunTime { get => runTime; set => runTime = value; }
        public double Ppd { get => ppd; set => ppd = value; }
        public string Cast { get => cast; set => cast = value; }

        
        public double Days
        {
            get => days; set
            {
                if (days != value)
                {
                    days = value;
                    OnChangedProperty("Days"); //ensures that changes in customer input for days in cartpage are reflected in real time
                };
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnChangedProperty(string propertyName)
        {
            var changed = PropertyChanged;
            if(changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
