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
    public partial class SegundaPaginaView : ContentPage
    {
        public SegundaPaginaView(string nombre, string ocupacion, string correo, string nacimiento, string nacionalidad, string perfil, string ingles, string lenguaje, string habilidades, string aptitudes, string experiencia, string formacion)
        {
            InitializeComponent();
            nombr.Text = nombre;
            ocp.Text = ocupacion;
            cor.Text = "Correo: " + correo + Environment.NewLine + "Nacimiento: " + nacimiento + Environment.NewLine + "Nacionalidad: " + nacionalidad;
            perf.Text = perfil;
            ing.Text = "Ingles: " + ingles;
            leng.Text = "Leng. de program: " + lenguaje + Environment.NewLine + "Aptitudes: " + aptitudes;
            hab.Text = habilidades;
            exp.Text = experiencia;
            form.Text = formacion;
        }


    }
}