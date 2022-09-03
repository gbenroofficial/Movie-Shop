using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class contactSoft : ContentPage
    {
        MovieCollection moviesCopy2;
        public contactSoft(MovieCollection items)
        {
            moviesCopy2 = items; //copied the content of items into an object to be used in submit button implementation
            InitializeComponent();
        }

        //submit button implementation:
        private void submitSoft_Clicked(object sender, EventArgs e)
        {
            if (firstName_soft.Text == null || lastName_soft == null || email_soft == null)
            {
                DisplayAlert("Error", "One or more fields require your input", "Ok");
            }
            else
            {
                DisplayAlert("", "Your order has been placed successfully. \nA confirmation has been sent to your email", "Ok");

               
                moviesCopy2.MovieList.Clear();//clears the content of the listview in cart by clearing list(observable collection)
                this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 1]); //removes page from stack               
                this.Navigation.PopAsync();
                
            }
        }

        //cancel button
        private void cancelSoft_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}