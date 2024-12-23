﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Logica;

namespace PresentacionWpf.Forms
{
    /// <summary>
    /// Lógica de interacción para UcNuevoContacto.xaml
    /// </summary>
    public partial class UcNuevoContacto : UserControl
    {
        public UcNuevoContacto()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DtFechaNacimiento.DisplayDateEnd = DateTime.Today;
            DtFechaNacimiento.SelectedDate = DateTime.Today;

            CboGrupo.ItemsSource = Enum.GetValues(typeof(Clasificacion));
            CboGrupo.SelectedItem = Clasificacion.Default;


        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //capturar los datos del formulario
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();
            int telefono = int.Parse(TxtTelefono.Text.Trim());
            DateTime fechaNacimiento = (DateTime)DtFechaNacimiento.SelectedDate;
            Clasificacion grupo = (Clasificacion)CboGrupo.SelectedItem;

            // validar datos
            List<string> errores = new List<string>();
            if (nombre == string.Empty)
            {
                errores.Add("Debe ingresar el nombre del contacto");
            }

            if (apellido == string.Empty)
            {
                errores.Add("Debe ingresar el apellido");
            }

            // guardar los datos en BLL
            if (errores.Count == 0)
            {
                //guardar los datos
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = nombre;
                nuevaPersona.Apellido = apellido;
                nuevaPersona.Telefono = telefono;
                nuevaPersona.FechaNacimiento = fechaNacimiento;
                nuevaPersona.Grupo = grupo;

                ContactoBLL cbll = new ContactoBLL();
                cbll.Agregar(nuevaPersona);

                //limpiar formulario
                TxtNombre.Text = string.Empty;
                TxtApellido.Text = string.Empty;
                TxtTelefono.Text = string.Empty;
                DtFechaNacimiento.SelectedDate = DateTime.Today;
                CboGrupo.SelectedItem = Clasificacion.Default;
                //mensajes
                MessageBox.Show(nombre + " se ha agregado correctamente","Nuevo Contacto",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                //hay errores
                string mensajesError = string.Join("\n",errores);
                MessageBox.Show(mensajesError,"Error crear Contacto",MessageBoxButton.OK,MessageBoxImage.Error);
                //mensajes
            }
            //Limpiar formulario

            //mensajes
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
