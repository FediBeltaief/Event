using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Event
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public void Display(Object sender, EventArgs e)
        {
            lblMessage.Text = "Welecome Mr. " + txtName.Text;   
        }


    }
}
