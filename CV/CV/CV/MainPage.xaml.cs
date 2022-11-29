using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();          

        }

        private void cbox_terminos_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(cbox_terminos.IsChecked)
                btn_registrar.IsEnabled = true;
            else
                btn_registrar.IsEnabled = false;
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {

        }

        private void lbl_password_Completed(object sender, EventArgs e)
        {
            
        }

        private void lbl_password2_Completed(object sender, EventArgs e)
        {
            
        }

        private void lbl_nombre_Completed(object sender, EventArgs e)
        {
            
        }

        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            String nombre = lbl_nombre.Text.ToString();
            string cadena = $"Bienvenido {nombre}. Llene sus datos";
            lbl_principal.Text = cadena;
        }

        private void lbl_correo_Completed(object sender, EventArgs e)
        {
           
        }
        private void limpiarRegistros()
        {
            lbl_nombre.Text = "";
            lbl_correo.Text = "";
           

        }

        private void lbl_ocupacion_Completed(object sender, EventArgs e)
        {

        }
    }
}
