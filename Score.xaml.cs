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
	public partial class Score : ContentPage
	{
        int result1;
		public Score (int ans)
		{
            result1 = ans;
			InitializeComponent ();
		}
        void ShowS_Button(object sender, System.EventArgs e)
        {
            displaylabel.Text = result1.ToString();
        }

    }
}