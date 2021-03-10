using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Calculadora.Funçoes;


namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        string display = string.Empty;
        Model dado = new Model();
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }
        private void btnNumero1_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "1";
        }
        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
        }
        private void btnNumero2_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "6";
        }
        private void btnNumero7_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "7";
        }
        private void btnNumero8_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "8";
        }
        private void btnNumero9_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "9";
        }
        private void btnNumero0_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length < 11)
                lblTotal.Text += "0";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Contains(",") != true && display.Length < 8 && display.Length >= 1)
                lblTotal.Text += ",";
        }
        private void btnApagarUm_Click(object sender, EventArgs e)
        {
            display = lblTotal.Text;
            if (display.Length > 0)
                lblTotal.Text = display.Remove(display.Length - 1);
        }
        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            lblAnteriorAcao.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (lblTotal.Text.Length > 0)
            {
                string text = lblTotal.Text;
                if (check == 1)
                {
                    lblTotal.Text = "-" + lblTotal.Text;
                    check = 2;
                }
                else if (check == 2)
                {
                    int lenght = lblTotal.Text.Length;
                    for (int i = 1; i < lenght; i++) { lblTotal.Text = lblTotal.Text + text[i]; }
                    check = 1;
                }
            }
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblAnteriorAcao.Text = lblTotal.Text + " /";
                dado.Numero = Convert.ToDouble(lblTotal.Text);
                dado.Acao = "/";
                lblTotal.Text = "";
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                if (dado.Acao == "/")
                {
                    double numb1 = dado.Numero;
                    double numb2 = Convert.ToDouble(lblTotal.Text);
                    Divisao div = new Divisao();
                    lblTotal.Text = Convert.ToString(div.divir(numb1, numb2));
                }
                else if (dado.Acao == "+")
                {
                    double numb1 = dado.Numero;
                    double numb2 = Convert.ToDouble(lblTotal.Text);
                    Adicao adicao = new Adicao();
                    lblTotal.Text = Convert.ToString(adicao.Somar(numb1, numb2));
                }
                else if (dado.Acao == "-")
                {
                    double numb1 = dado.Numero;
                    double numb2 = Convert.ToDouble(lblTotal.Text);
                    Subtracao subtracao = new Subtracao();
                    lblTotal.Text = Convert.ToString(subtracao.Menos(numb1, numb2));
                }
                else if (dado.Acao == "*")
                {
                    double numb1 = dado.Numero;
                    double numb2 = Convert.ToDouble(lblTotal.Text);
                    Multiplicacao multiplicacao = new Multiplicacao();
                    lblTotal.Text = Convert.ToString(multiplicacao.Multip(numb1, numb2));
                }
            }
        }
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblAnteriorAcao.Text = lblTotal.Text + " +";
                dado.Numero = Convert.ToDouble(lblTotal.Text);
                dado.Acao = "+";
                lblTotal.Text = "";

            }
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblAnteriorAcao.Text = lblTotal.Text + " -";
                dado.Numero = Convert.ToDouble(lblTotal.Text);
                dado.Acao = "-";
                lblTotal.Text = "";
            }
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblAnteriorAcao.Text = lblTotal.Text + " X";
                dado.Numero = Convert.ToDouble(lblTotal.Text);
                dado.Acao = "*";
                lblTotal.Text = "";

            }
        }
        private void btnApagarAcao_Click(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
        }
        private void frmCalculadora_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        private void frmCalculadora_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }
        private void frmCalculadora_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
    }
}
