using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculador : ContentPage
    {
        public Calculador()
        {
            InitializeComponent();

            //Llenamos los elementos del picker
            pkOperacion.Items.Add("Suma");
            pkOperacion.Items.Add("Resta");
            pkOperacion.Items.Add("Multiplicación");
            pkOperacion.Items.Add("División");
        }

        private void pkOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //capturo la opcion que seleccione en el picker
            string op = pkOperacion.SelectedItem.ToString();

            //defino numeros
            //lo que tenga en el txtN1 lo convierto en una variable entera
            int n1 = Int32.Parse(txtN1.Text);
            int n2 = Int32.Parse(txtN2.Text);
            //variable para almacenar los resultados de las operaciones
            double res = 0;

            //valido las opciones seleccionadas
            if (op == "Suma")
            {
                res = n1 + n2;
            }
            else
            {
                if (op == "Resta")
                {
                    res = n1 - n2;
                }
                else
                {
                    if(op == "Multiplicacion")
                    {
                        res = n1 * n2;
                    }
                    else
                    {
                        if(op == "Division")
                        {
                            res = n1 / n2;
                        }
                    }
                }
            }

            //imprimo el resultado en una etiqueta
            //nombre_variable+""; se usa para convertir la variable a texto en la impresion de resultado
            lblResta.Text = res + "";
        }
    }
}