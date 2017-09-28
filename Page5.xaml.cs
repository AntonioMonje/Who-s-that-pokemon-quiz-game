using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizG1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
        int answer = 1;
		public Page5 (int val)
		{
            answer += val;
			InitializeComponent ();
		}
        async void B1_Button(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Score(answer));
        }
        async void B2_Button(object sender, System.EventArgs e)
        {
            answer--;
            await Navigation.PushAsync(new Score(answer));
        }
        async void B3_Button(object sender, System.EventArgs e)
        {
            answer--;
            await Navigation.PushAsync(new Score(answer));
        }
        async void B4_Button(object sender, System.EventArgs e)
        {
            answer--;
            await Navigation.PushAsync(new Score(answer));
        }
    }
}