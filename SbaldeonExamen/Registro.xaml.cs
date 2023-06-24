using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SbaldeonExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuarioglobal;
        public Registro(string usuario)
        {

            InitializeComponent();
            lblUsuario.Text = "Usuarioconectado:  " + usuario;
            usuarioglobal = usuario;
        }

        private void pPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pPaises.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", " Seleccione un Pais", "Cerrar");
            }

            else
            {
                DisplayAlert("Alerta", pPaises.Items[pPaises.SelectedIndex], "Cerrar");
            }
        }

        private void pCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pCiudades.SelectedIndex == -1)
            {
                DisplayAlert("Alerta", " Seleccione una ciudad", "Cerrar");
            }

            else
            {
                DisplayAlert("Alerta", pCiudades.Items[pCiudades.SelectedIndex], "Cerrar");
            }
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            double MI = Convert.ToDouble(txtMI.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double edad = Convert.ToDouble(txtEdad.Text);
            string fecha = dpFechas.Date.ToString("M/dd/yyyy");
            string ciudad = pCiudades.Items[pCiudades.SelectedIndex];
            string pais = pPaises.Items[pPaises.SelectedIndex];
            double PM = Convert.ToDouble(txtPM.Text);
            



            Navigation.PushAsync(new Resumen(usuarioglobal,MI,nombre,apellido,edad,fecha,ciudad,pais,PM));
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            
            double MI = Convert.ToDouble(txtMI.Text);
            double PM = ((1500 - MI )/4) + (1500*0.04) ;
            double PT = (PM * 4)+MI;
            txtPM.Text=PM.ToString();

        }

        private void txtMI_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double MI = Convert.ToDouble(txtMI.Text);
                if (MI >=1500)
                {
                    DisplayAlert("Error", "El valor no puede ser el total", " Cerrar");
                    txtMI.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }
    }
}