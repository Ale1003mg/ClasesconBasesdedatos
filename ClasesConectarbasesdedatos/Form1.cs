﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesConectarbasesdedatos;

namespace ClasesConectarbasesdedatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//Cerrar
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)//Limpiar
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//Insertar
        {
            int aux = 0;
            Insertar Insert = new Insertar();
            Insert.ObtenerEstudiante(0,textBox2.Text,textBox3.Text,textBox4.Text, Convert.ToInt32(textBox5.Text));
            aux = Insert.Insert();
            if (aux == 1)
            {
                textBox6.Text = "Se guardo Correctamente";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else {
                textBox6.Text = "Se produjo un error";
            }

        }

        private void button3_Click(object sender, EventArgs e)//Eliminar
        {
            int aux = 0;
            Eliminar delete = new Eliminar();
            delete.ObtenerEstudiante(Convert.ToInt32(textBox1.Text),"","","",0);
            aux = delete.Delete();
            if (aux == 1)
            {
                textBox6.Text = "Se Elimino Correctamente";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
            {
                textBox6.Text = "Se produjo un error";
            }
        }

        private void button2_Click(object sender, EventArgs e)//Update
        {
            int aux = 0;
            Modificar modificar = new Modificar();
            modificar.ObtenerEstudiante(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            aux = modificar.Update();
            if (aux == 1)
            {
                textBox6.Text = "Se Actualizo Corectamente";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
            {
                textBox6.Text = "Se produjo un error";
            }
        }
    }
}
