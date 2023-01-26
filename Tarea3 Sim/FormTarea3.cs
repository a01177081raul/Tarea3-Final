using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tarea3_Sim.AlgoritmoTarea3;

namespace Tarea3_Sim
{
    public partial class FormTarea3 : Form
    {
        public FormTarea3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Paso 1: Condición de vacío
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))          //Si mi TextBox1 está vacía pasa algo. || es la funcion "or".
                {
                    MessageBox.Show("Los números tienen que ser MAYOR que cero, se tiene que insertar un valor");
                    return;
                }
                int semilla = Convert.ToInt32(textBox1.Text);       //Convertir un texto a un entero
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
                int numeroDatos = Convert.ToInt32(textBox5.Text);

                int x = 0;
                int y = 0;
                int z = 0;
                List<int> listaDatos = new List<int>();
                //Paso 2: Condición de Mayor y Menor
                if (numeroDatos < 0)
                {
                    MessageBox.Show("Introduce un número mayor a cero en Numero de Datos");
                    return;
                }
                if (semilla > 0 && a > 0 && b > 0 && c > 0 && numeroDatos > 0)
                {
                    Algoritmotarea3 algoritmo = new Algoritmotarea3();
                    x = algoritmo.CalcularZ(numeroDatos, a, b, c, semilla, listaDatos);
                    //Dudas con listaDatos[0]
                    llenarGrid(numeroDatos, x, y, z);
                    textBox5.Text = listaDatos[0].ToString();
                    textBox2.Text = listaDatos[0].ToString();
                    textBox3.Text = listaDatos[0].ToString();
                    textBox4.Text = listaDatos[0].ToString();
                    //for (int i = 0; i < numeroDatos; i++);

                }
                else
                {
                    MessageBox.Show("Vuelve a intentar (Nunca te rindas)");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vuélvelo a intentar");

            }
            //iteracion = iteracion +1;
            //textBox5.Text = iteracion.Value;
            //



        }
        public void llenarGrid(int numeroDatos, int x, int y, int z, Algoritmotarea3 algoritmo)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Numero");
            dataGridView1.Columns.Add(numeroColumna2, "X(n)");
            dataGridView1.Columns.Add(numeroColumna3, "a*X(n) +c");
            dataGridView1.Columns.Add(numeroColumna4, "[a*X(n) +c] mod m");

            for (int i = 0; i < numeroDatos; i++)                          //foreach recorre la lista de objetos, for recorre int
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = algoritmo.listaNumeros[i].numeroDatos.ToString();   //se obtiene desde algoritmo >> ListaDemandas, el valor de Cantidad Requerida
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = algoritmo.listaNumeros[i].x.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = algoritmo.listaNumeros[i].y.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = algoritmo.listaNumeros[i].z.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
     }
    
}
