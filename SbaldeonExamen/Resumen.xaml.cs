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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, double MI,string nombre,string apellido, double edad, string fecha,string ciudad, string pais,double PM)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuarioconectado: " + usuario;
            txtMI.Text = MI.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad.ToString();
            txtFecha.Text = fecha;
            txtCiudad.Text = ciudad.ToString();
            txtPais.Text = pais;
            txtPM.Text=PM.ToString();
            double PT = (PM * 4) + MI;
            txtPT.Text = PT.ToString();

        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
          
            //System.Environment.Exit(0);
        }
    }
}