using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HandingTheControl : ContentPage
    {
        public HandingTheControl()
        {
            InitializeComponent();
        }
     
        private void btnSubmit_Clicked_1(object sender, EventArgs e)
        {
            string usrName = entUsrName.Text ?? "";
            string usrEmail = entUsrEmail.Text ?? "";
            string usrPhone = entUsrPhone.Text ?? "";

            string usrDOB = dpkUsrDOB.Date.ToString("dd/MM/yyyy");
            string usrGender = sex.IsToggled ? "Male" : "Female";

            string messageContent = "Name: " + usrName + "\nEmail: " + usrEmail + "\nPhone: " + usrPhone + "\nBirthday: " + usrDOB + "\nGender: " + usrGender;
            DisplayAlert("User Information", messageContent, "OK");

        }

        private void btnCancel_Clicked_1(object sender, EventArgs e)
        {
            entUsrName.Text = "";
            entUsrEmail.Text = "";
            entUsrPhone.Text = "";
            dpkUsrDOB.Date = DateTime.Today;
            sex.IsToggled = false;

        }
    }
}