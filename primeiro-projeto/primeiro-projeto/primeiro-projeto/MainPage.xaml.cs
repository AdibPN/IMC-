using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace primeiro_projeto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);
            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                DisplayAlert("Abaixo do peso normal:", "Seu imc:" + imc.ToString(), "OK💕");
            }
            else if (imc >= 18.5 & imc < 25)
            {
                DisplayAlert("Peso Normal:", "Seu imc:" + imc.ToString(), "OK💕");
            }


            if (imc >= 25 & imc < 30)
            {
                DisplayAlert("Excesso de Peso:", "Seu imc:" + imc.ToString(), "OK💕");
            }
            else if (imc >= 30 & imc < 35)
            {
                DisplayAlert("Obesidade Classe I:", "Seu imc:" + imc.ToString(), "OK💕");
            }
            else if (imc >= 35 & imc < 40)
            {
                DisplayAlert("Obesidade Classe II:", "Seu imc:" + imc.ToString(), "OK💕");
            }
            else if (imc > 40)
            {
                DisplayAlert("Obesidade Classe III:", "Seu imc:" + imc.ToString(), "OK💕");
            }



        }
    }
}
