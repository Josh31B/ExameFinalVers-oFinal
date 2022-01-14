using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsJosh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool vaiMudar = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblConta.Text = "";
            btnResultado1.Text = "0";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btnResultado1.Text == "0" || vaiMudar)
            {
                btnResultado1.Text = "";
                vaiMudar = false;
            }
            btnResultado1.Text += btn.Text;
        }

        private void btnOpe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string aux = btnResultado1.Text;
            lblConta.Text += aux + "" + btn.Text + "";
            
            vaiMudar = true;
        }

            private double Evaluate(string expression)
        {
            expression = expression.Replace(",", "."﻿);
            expression = expression.Replace("﻿÷", "/");
            expression = expression.Replace("X", "*");
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
;            }
            catch
            {
                return double.Parse("0");
            }

        }

        private void btnCalculadora(object sender, EventArgs e)
        {

        }

        private void btnPadrao(object sender, EventArgs e)
        {

        }

        private void btnResultado(object sender, EventArgs e)
        {

        }

        private void btnPorcentagem(object sender, EventArgs e)
        {

        }
        private void btn(object sender, EventArgs e)
        {
            btnResultado1.Text = "0";

        }

        private void lblResultado(object sender, EventArgs e)
        {

        }

        private void lblConta_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnResultado1.Text = btnResultado1.Text.Substring(0, btnResultado1.Text.Length -1);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!btnResultado1.Text.Contains(','))
            {
                btnResultado1.Text += ",";
            }

        }

        private void btnMaisouMenos_Click(object sender, EventArgs e)
        {
            btnResultado1.Text = (double.Parse(btnResultado1.Text) * -1).ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string conta = lblConta.Text + btnResultado1.Text;
            double resultado = Evaluate(conta);
            btnResultado1.Text = resultado.ToString();
            lblConta.Text= "";
            vaiMudar = true;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            btnResultado1.Text = Math.Pow(double.Parse(btnResultado1.Text), 2).ToString();
            vaiMudar = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string aux = btnResultado1.Text;
            btnResultado1.Text = Evaluate(lblConta.Text + btnResultado1.Text).ToString();
            lblConta.Text += aux + "yroot";
            vaiMudar = true;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            btnResultado1.Text = (1 / double.Parse(btnResultado1.Text)).ToString();
            vaiMudar = true;
        }

        private void btnIgual3(object sender, EventArgs e)
        {

        }
    }
}
