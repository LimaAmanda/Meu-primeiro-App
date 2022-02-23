using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void btnClicar_Clicked(object sender, EventArgs e)
        {
            count++;
            btnCliqueAqui.Text = " Você clicou" + count + "Vezes";

        }

        private void btnAdicionarDias_Clicked(object sender, EventArgs e)
        {

            DateTime dataDigitada = Convert.ToDateTime(txtData.Text);
            DateTime dataFutura = dataDigitada.AddDays(10);

            DisplayAlert("Mensagem", "A data futura é " + dataFutura.Date, "ok");
        }
        private async void btntAdicionarMeses_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Mensagem", "Deseja realmente somar os meses ?", "yes", "no"))
                {
                
                    DateTime mesDigitado = Convert.ToDateTime(txtData.Text);
                    DateTime mesFuturo = mesDigitado.AddMonths(10);

                   await DisplayAlert("Mensagem", "O futuro Mes é " + mesFuturo.Date, "ok");

                }

            }
        }
    } 


