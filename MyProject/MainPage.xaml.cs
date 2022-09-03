using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace MyProject
{
    public partial class MainPage : ContentPage
    {
        //ObservableCollection<MovieCollection> genList;
        protected List<string> actionMovies = new List<string>();
        protected List<string> comedyMovies = new List<string>();
        protected List<string> dramaMovies = new List<string>();
        protected List<string> animationMovies = new List<string>();

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //Creation of movie objects:
        Info Joker = new Info();
        Info Spiderman = new Info();
        Info Frozen = new Info();
        Info Spiderverse = new Info();
        Info WhyHim = new Info();
        Info Hangover2 = new Info();
        Info Neighbors = new Info();
        Info ThreeIdiots = new Info();
        Info Jumpstreet = new Info();
        Info ThePhotograph = new Info();
        //..............................................................................................................................................


        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //create object of class MovieCollection for list of movie objects:
        MovieCollection movies = new MovieCollection();
        //............................................................................

        

        public MainPage()
        {
            InitializeComponent();

            //Setting cart icon image button source:
            cartIcon.Source = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTnGGjGqunpNRwdKqv0I0zcyK-uf9ZFskGY_w&usqp=CAU"));

            //............................................................................................................................................
            //Movie Image url list creation and image button source setting:
            actionMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS7XsLxM2DKkcDRJePbQcE5pE2Bw6z8mQ_Shg&usqp=CAU");
            actionMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTKWp8MGym2i5Yp0S_VmK7Srn3aT7NXpjjYaA&usqp=CAU");
            action1.Source = ImageSource.FromUri(new Uri(actionMovies[0]));
            action2.Source = ImageSource.FromUri(new Uri(actionMovies[1]));

            animationMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTfAI2xTXIuuhYbpMwIY9qg-WVOQiszq3zaFQ&usqp=CAU");
            animationMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQFOWSvPUalWxSPEtkfqH5mJ3AU6fcbovjbHg&usqp=CAU");
            animation1.Source = ImageSource.FromUri(new Uri(animationMovies[0]));
            animation2.Source = ImageSource.FromUri(new Uri(animationMovies[1]));

            comedyMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTDIt1PJwOFCmCS2uAOT2EvHT7fQO0FCI5Utg&usqp=CAU");
            comedyMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQAJz6t_1ThyXqmDyrAlbsd_Y5RTpmE8E5p-A&usqp=CAU");
            comedyMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRpP4iKOSWwcp358JWQaPQQVmjEKEGmPJXxFw&usqp=CAU");
            comedyMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSh92B90g-4FoAE7RmVQzcYxFOUmRV5Ir3iWg&usqp=CAU");
            comedyMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS3_dQjrxZZ6rqXqYsVT2pkNXHcdOjPLA6FMQ&usqp=CAU");
            comedy1.Source = ImageSource.FromUri(new Uri(comedyMovies[0]));
            comedy2.Source = ImageSource.FromUri(new Uri(comedyMovies[1]));
            comedy3.Source = ImageSource.FromUri(new Uri(comedyMovies[2]));
            comedy4.Source = ImageSource.FromUri(new Uri(comedyMovies[3]));
            comedy5.Source = ImageSource.FromUri(new Uri(comedyMovies[4]));

            dramaMovies.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRUmANy32XeouHNnwHzpWhIHop0R6AxyvO7Rw&usqp=CAU");

            drama1.Source = ImageSource.FromUri(new Uri(dramaMovies[0]));
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            ////////////////..................................................................................................................................
            //Sample Movies object initialization:
            Joker.MovieName = "The Joker";
            Joker.MovieYear = "2018";
            Joker.MovieInfo = "A story about the hardships and mental breakdowns that have led to the birth of Gotham's greatest villain, The Joker";
            Joker.Ppd = 2;
            Joker.RunTime = "1.8 hours";

            Spiderman.MovieName = "Spider man";
            Spiderman.MovieYear = "2003";
            Spiderman.MovieInfo = "Peter parker a nerdy random stranger gets bitten by a mutated spider and gains spider-like abilities " +
                "which he uses to fight crime";
            Spiderman.Ppd = 1.5;
            Spiderman.RunTime = "1.3 hours";

            Frozen.MovieName = "Frozen";
            Frozen.MovieYear = "2017";
            Frozen.MovieInfo = "A young queen is troubled by her inability to control her powers and shuts herself off from her kingdom" +
                "and family. Her sister makes it a mission to get her back and save the kingdom";
            Frozen.Ppd = 1.3;
            Frozen.RunTime = "1 hour";

            Spiderverse.MovieName = "Spiderverse";
            Spiderverse.Ppd = 2;

            WhyHim.MovieName = "Why Him?";
            WhyHim.Ppd = 1.25;

            Hangover2.MovieName = "HangOver 2";
            Hangover2.Ppd = 2;

            Neighbors.MovieName = "Neighbors";
            Neighbors.Ppd = 2.5;

            ThreeIdiots.MovieName = "Three Idiots";
            ThreeIdiots.Ppd = 3;
            Jumpstreet.MovieName = "21 Jump Street";
            Jumpstreet.Ppd = 2;


            ThePhotograph.MovieName = "The Photograph";
            ThePhotograph.Ppd = 1;
            //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        }

        //button to navigate to cart page
        async void cartIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cart(movies));
        }


        //Below are image buttons for all the movies on the main page:
        private async void action1_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Joker.MovieName, "Name: " + Joker.MovieName + "\n\nDescription: " + Joker.MovieInfo + "\n\nRun time: " +
                Joker.RunTime + "\n\nRelease date: " + Joker.MovieYear + "\n\nCast: " + Joker.Cast + "\n\nPrice per day: " + "\u00A3" + Joker.Ppd, "Add to cart", "Return");
            if (response)
            {
                
                movies.MovieList.Add(Joker); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }


        }

        private async void action2_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Spiderman.MovieName, "Name: " + Spiderman.MovieName + "\n\nDescription: " + Spiderman.MovieInfo + "\n\nRun time: " +
               Spiderman.RunTime + "\n\nRelease date: " + Spiderman.MovieYear + "\n\nCast: " + Spiderman.Cast + "\n\nPrice per day: " + "\u00A3" + Spiderman.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(Spiderman); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void animation1_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Frozen.MovieName, "Name: " + Frozen.MovieName + "\n\nDescription: " + Frozen.MovieInfo + "\n\nRun time: " +
               Frozen.RunTime + "\n\nRelease date: " + Frozen.MovieYear + "\n\nCast: " + Frozen.Cast + "\n\nPrice per day: " + "\u00A3" + Frozen.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(Frozen); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void animation2_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Spiderverse.MovieName, "Name: " + Spiderverse.MovieName + "\n\nDescription: " + Spiderverse.MovieInfo + "\n\nRun time: " +
               Spiderverse.RunTime + "\n\nRelease date: " + Spiderverse.MovieYear + "\n\nCast: " + Spiderverse.Cast + "\n\nPrice per day: " + "\u00A3" + Spiderverse.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(Spiderverse); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void comedy1_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(WhyHim.MovieName, "Name: " + WhyHim.MovieName + "\n\nDescription: " + WhyHim.MovieInfo + "\n\nRun time: " +
               WhyHim.RunTime + "\n\nRelease date: " + WhyHim.MovieYear + "\n\nCast: " + WhyHim.Cast + "\n\nPrice per day: " + "\u00A3" + WhyHim.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(WhyHim); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void comedy2_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Hangover2.MovieName, "Name: " + Hangover2.MovieName + "\n\nDescription: " + Hangover2.MovieInfo + "\n\nRun time: " +
               Hangover2.RunTime + "\n\nRelease date: " + Hangover2.MovieYear + "\n\nCast: " + Hangover2.Cast + "\n\nPrice per day: " + "\u00A3" + Hangover2.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(Hangover2); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void comedy3_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Neighbors.MovieName, "Name: " + Neighbors.MovieName + "\n\nDescription: " + Neighbors.MovieInfo + "\n\nRun time: " +
               Neighbors.RunTime + "\n\nRelease date: " + Neighbors.MovieYear + "\n\nCast: " + Neighbors.Cast + "\n\nPrice per day: " + "\u00A3" + Neighbors.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(Neighbors); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void comedy4_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(ThreeIdiots.MovieName, "Name: " + ThreeIdiots.MovieName + "\n\nDescription: " + ThreeIdiots.MovieInfo + "\n\nRun time: " +
               ThreeIdiots.RunTime + "\n\nRelease date: " + ThreeIdiots.MovieYear + "\n\nCast: " + ThreeIdiots.Cast + "\n\nPrice per day: " + "\u00A3" + ThreeIdiots.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(ThreeIdiots); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void comedy5_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(Jumpstreet.MovieName, "Name: " + Jumpstreet.MovieName + "\n\nDescription: " + Jumpstreet.MovieInfo + "\n\nRun time: " +
               Jumpstreet.RunTime + "\n\nRelease date: " + Jumpstreet.MovieYear + "\n\nCast: " + Jumpstreet.Cast + "\n\nPrice per day: " + "\u00A3" + Jumpstreet.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(ThePhotograph); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        private async void drama1_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert(ThePhotograph.MovieName, "Name: " + ThePhotograph.MovieName + "\n\nDescription: " + ThePhotograph.MovieInfo + "\n\nRun time: " +
               ThePhotograph.RunTime + "\n\nRelease date: " + ThePhotograph.MovieYear + "\n\nCast: " + ThePhotograph.Cast + "\n\nPrice per day: " + "\u00A3" + ThePhotograph.Ppd, "Add to cart", "Return");
            if (response)
            {
                movies.MovieList.Add(ThePhotograph); //Adds the movie to a list of items(cart) if option to add to cart is selected

            }
        }

        
    }
}
    

