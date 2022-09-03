using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyProject
{

    public class MovieCollection : INotifyPropertyChanged        
    
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Info> movieList;

        public ObservableCollection<Info> MovieList { get => movieList; set 
            {
                if (movieList != value)
                    movieList = value;
                OnPropertyChanged("MovieList");
            } 
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public MovieCollection()
        {
            MovieList = new ObservableCollection<Info>();
            
        }




        


    }        
       

        
}
