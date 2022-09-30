using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormsCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            char[] operadores = {'+', '-', '*', '/'};
            cmb_operador.DataSource = operadores;
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
            string numero1 = (txt_num1.Text).Replace('.',',');
            string numero2 = (txt_num2.Text).Replace('.',',');
            string operador = cmb_operador.Text;
            if(double.TryParse(numero1,out double aux1) && double.TryParse(numero2,out double aux2))
            {
                if(operador == " ")
                {
                    operador = "+";
                }
                double resultado = Operar(numero1, numero2, operador);
                lbl_resultado.Text = resultado.ToString();
                lstbx_operaciones.Items.Add($"{numero1} {operador} {numero2} = {resultado}\n");
            }
            else
            {
                lbl_resultado.Text = "Valor Invalido";
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_convertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = lbl_resultado.Text;
            if (!(string.IsNullOrEmpty(resultado)))
            {
                lbl_resultado.Text = Operando.Conversor(true, resultado);
            }
        }

        private void btn_convertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = lbl_resultado.Text;
            if (!(string.IsNullOrEmpty(resultado)))
            {
                lbl_resultado.Text = Operando.Conversor(false, resultado);
            }

        }
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void Limpiar()
        {
            txt_num1.Clear();
            txt_num2.Clear();
            lbl_resultado.Text = "Resultado Actual";
            lstbx_operaciones.Items.Clear();
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char operacion = char.Parse(operador);
            return Calculadora.Operar(num1,num2,operacion);           
        }  
    }
}
