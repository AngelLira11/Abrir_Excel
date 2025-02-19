using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abrir_Excel
{
    public partial class frmFechas : Form
    {
        public frmFechas()
        {
            InitializeComponent();
        }


        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            dtpFecha_nacimiento.Enabled = true;
            dtpFechaCalculo.Enabled = true;
            dtpFechaCalculo.MinDate = dtpFecha_nacimiento.Value;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFecha_nacimiento.Value;
            DateTime calculo = dtpFechaCalculo.Value;
            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Dias " + dias, " Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //LIHA041211HCLRRNA2

        private void btnCurp_Click(object sender, EventArgs e)
        {
            // string fecha = txtCurp.Text.Substring(4, 6);
            string mes = txtCurp.Text.Substring(6, 2);
            string dia = txtCurp.Text.Substring(8, 2);
            string año = txtCurp.Text.Substring(4, 2);


            string sexo = txtCurp.Text.Substring(10, 1);
            string estado = txtCurp.Text.Substring(11, 2);
            //-----------------------------------------------FECHA 
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre",
            "Octubre", "Noviembre", "Diciembre"};

            string nombreMes = "";
            for (int i = 0; i < meses.Length; i++)
            {
                if (mes == (i + 1).ToString())
                {
                    nombreMes = meses[i];
                }
            }
            //---------------------------------------------------------------
            //-----------------------------------------SEXO
            if (sexo == "H")
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }
            //----------------------------------------------------------------
            //----------------------------------------ESTADOS
            string[] estados = {
        "AS", "Aguascalientes", "BC", " Baja California", "BS ", "Baja California Sur",
        "CC ", "Campeche", "CS ", "Chiapas", "CH", "Chihuahua",
        "CL ", "Coahuila", "CM ", "Colima", "DF ", "Ciudad de México",
        "DG ", " Durango", "GT ", "Guanajuato", "GR ", " Guerrero",
        "HG ", " Hidalgo", "JC ", " Jalisco", "MC ", " Estado de México",
        "MN ", " Michoacán", "MS ", " Morelos", "NT ", " Nayarit",
        "NL ", " Nuevo León", "OC ", " Oaxaca", "PL ", " Puebla",
        "QT ", " Querétaro", "QR ", " Quintana Roo", "SP ", " San Luis Potosí",
        "SL ", " Sinaloa", "SR ", " Sonora", "TC ", " Tabasco",
        "TS ", " Tamaulipas", "TL ", " Tlaxcala", "VZ ", " Veracruz",
        "YN ", " Yucatán", "ZS ", "Zacatecas", "NE ", " Nacido en el Extranjero"
    };




            if (estado == "AS") { estado = "Aguas Calientes"; }
            else if (estado == "BC") { estado = "Baja California"; }
            else if (estado == "BS") { estado = "Baja California Sur"; }
            else if (estado == "CC") { estado = "Campeche"; }
            else if (estado == "CS") { estado = "Chiapas"; }
            else if (estado == "CH") { estado = "Chihuahua"; }
            else if (estado == "CL") { estado = "Coahuila"; }
            else if (estado == "CM") { estado = "Colima"; }
            else if (estado == "DF") { estado = "Ciudad de México"; }
            else if (estado == "DG") { estado = "Durango"; }
            else if (estado == "GT") { estado = "Guanajuato"; }
            else if (estado == "GR") { estado = "Guerrero"; }
            else if (estado == "HG") { estado = "Hidalgo"; }
            else if (estado == "JC") { estado = "Jalisco"; }
            else if (estado == "MC") { estado = "Estado de México"; }
            else if (estado == "MN") { estado = "Michoacán"; }
            else if (estado == "MS") { estado = "Morelos"; }
            else if (estado == "NT") { estado = "Nayarit"; }
            else if (estado == "NL") { estado = "Nuevo León"; }
            else if (estado == "OC") { estado = "Oaxaca"; }
            else if (estado == "PL") { estado = "Puebla"; }
            else if (estado == "QT") { estado = "Querétaro"; }
            else if (estado == "QR") { estado = "Quintana Roo"; }
            else if (estado == "SP") { estado = "San Luis Potosí"; }
            else if (estado == "SL") { estado = "Sinaloa"; }
            else if (estado == "SR") { estado = "Sonora"; }
            else if (estado == "TC") { estado = "Tabasco"; }
            else if (estado == "TS") { estado = "Tamaulipas"; }
            else if (estado == "TL") { estado = "Tlaxcala"; }
            else if (estado == "VZ") { estado = "Veracruz"; }
            else if (estado == "YN") { estado = "Yucatán"; }
            else if (estado == "ZS") { estado = "Zacatecas"; }
            else if (estado == "NE") { estado = "Nacido en el Extranjero"; }



            MessageBox.Show("El genero es: " + sexo + " El estado es: " + estado + " Fecha Nacimiento: " + dia + " / " + nombreMes + "/ 20" + año);
        }

    }
}
