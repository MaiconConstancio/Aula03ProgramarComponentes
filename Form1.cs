﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03ProgramarComponentes
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = CaixaDeDialogo.Text;

            MessageBox.Show($"Bem-Vindo {nome} :D");


            nome = SeuNomeÉ.Text = ($"Seu nome é: {nome} :D");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)

        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaixaDeDialogo.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
