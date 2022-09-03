using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MyProject
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net.Mail;
    using System.Xml.Schema;
    
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Cart : ContentPage
    {
        MovieCollection moviesCopy = new MovieCollection();
        public Cart(MovieCollection items)
        {
            moviesCopy = items;
            InitializeComponent();
            double sum, sumSoft;

            
            this.purchasedItems.ItemsSource = items.MovieList;//set listview source of cart page


            
            double v;
            void total()//to calculate and show total + voucher
            {
                List<double> list = new List<double>();
                foreach (Info item in items.MovieList)
                {

                    list.Add(item.Ppd * item.Days);
                }
                if (voucher.Text == "DANIEL")
                {
                    v = 0.25;
                }
                else
                    v = 0;
                sum = list.Sum() - (v * list.Sum()); //for hardcopy total price
                sumSoft = sum * 0.5;//for soft copy total price
                this.showTotal.Text = "HARD COPY =  £" + sum.ToString();
                this.showSoftTotal.Text = "SOFT COPY = £" + sumSoft.ToString();

            }

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>//keeps running the calculation every second. Will be improved upon later
            {
                total();
                return true;
            });


        }

        

        private async void pay_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Delivery type", "Cancel", "", "Hard copy", "Soft copy");

            switch (response){//to determine which form fill-in page to navigate to
                case "Hard copy": 
                    await Navigation.PushAsync(new contact(moviesCopy));
                    break;
                case "Soft copy":
                    await Navigation.PushAsync(new contactSoft(moviesCopy));
                    break;
            }
            
        }

        private void itemDelete_Clicked(object sender, EventArgs e) //enables deletion of individual item in listview of cart page
        {
            var stuff = (Xamarin.Forms.Button)sender;
            Info listitem = (from itm in moviesCopy.MovieList
                             where itm.MovieName == stuff.CommandParameter.ToString()// matches the selected item(bound to item name in class to item name in source list
                             select itm).FirstOrDefault<Info>();

            moviesCopy.MovieList.Remove(listitem); //removes the select item
        }
    }
}
    
