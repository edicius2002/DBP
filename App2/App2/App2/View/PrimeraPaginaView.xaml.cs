using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeraPaginaView : ContentPage
    {
        public PrimeraPaginaView()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            string english = "";
            string leng = "";
            string habil = "";
            if (videojuegos.IsChecked)
            {
                habil += "- Bueno en videojuegos" + Environment.NewLine;
            }
            if (office.IsChecked)
            {
                habil += "- Experto en Office" + Environment.NewLine;
            }
            if (perros.IsChecked)
            {
                habil += "- Paseador de perros" + Environment.NewLine;
            }
            if (Python.IsChecked)
            {
                leng += " Python ";
            }
            if (Java.IsChecked)
            {
                leng += " Java ";
            }
            if (C.IsChecked)
            {
                leng += " C ";
            }
            if (basico.IsChecked)
            {
                english = basico.Value.ToString();
            }
            if (intermedio.IsChecked)
            {
                english = intermedio.Value.ToString();
            }
            if (avanzado.IsChecked)
            {
                english = avanzado.Value.ToString();
            }
            if (fluido.IsChecked)
            {
                english = fluido.Value.ToString();
            }
            string nombre = EntryNombre.Text;
            string nacimiento = EntryNacimiento.Date.ToString("d");
            string ocupacion = EntryOcupacion.Text;
            string correo = EntryCorreo.Text;
            string nacionalidad = (string)EntryNacionalidad.ItemsSource[EntryNacionalidad.SelectedIndex];
            string ingles= english;
            string lenguaje = leng;
            string habilidades = habil;
            string perfil = EntryPerfil.Text;
            string aptitudes = EntryApt.Text;
            string experiencia = EntryExp.Text;
            string formacion = EntryForm.Text;
            await Application.Current.MainPage.Navigation.PushAsync(new SegundaPaginaView(nombre, ocupacion, correo, nacimiento, nacionalidad, perfil, ingles, lenguaje, habilidades, aptitudes, experiencia, formacion));
        }

    }
}