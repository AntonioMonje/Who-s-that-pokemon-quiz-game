using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizG1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
    async void Enter_Button(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new Page1());
        }
	}
}
