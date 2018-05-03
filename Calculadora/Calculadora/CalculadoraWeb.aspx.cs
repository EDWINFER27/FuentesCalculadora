using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculadora.ServiceREST;

namespace Calculadora
{
    public partial class CalculadoraWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {

            ////servicio REST
            ServiceREST.Service1Client R = new Service1Client();
            double Respuesta = 0.0;
            string select = DropDownList1.SelectedValue;
            if (select.Equals("1"))
            {
                Respuesta = R.GetSuma(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }
            if (select.Equals("2"))
            {
                Respuesta = R.GetResta(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            if (select.Equals("3"))
            {
                Respuesta = R.GetMultiplicacion(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            if (select.Equals("4"))
            {
                Respuesta = R.GetDivision(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            LblResult.Text = Respuesta.ToString();

            ////servicio SOAP
            //ServicioR.CalcularSoapClient s = new ServicioR.CalcularSoapClient();
            //double Respuesta = 0.0;
            //string select = DropDownList1.SelectedValue;
            //if (select.Equals("1"))
            //{
            //    Respuesta = s.Suma(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}
            //if (select.Equals("2"))
            //{
            //    Respuesta = s.Resta(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}

            //if (select.Equals("3"))
            //{
            //    Respuesta = s.Multiplicacion(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}

            //if (select.Equals("4"))
            //{
            //    Respuesta = s.Division(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            //}
            //LblResult.Text = Respuesta.ToString();
        }
    }
}