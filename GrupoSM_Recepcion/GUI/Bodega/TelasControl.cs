using System;
using System.Windows.Forms;

namespace GrupoSM_Recepcion.GUI.Bodega
{
    public partial class TelasControl : Form
    {
        public TelasControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUI.Bodega.Cliente_seleccion clientegui = new Cliente_seleccion(this);
            clientegui.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUI.Bodega.Proveedor_Seleccion proveedorgui = new Proveedor_Seleccion(this);
            proveedorgui.ShowDialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Aceptar")
            {
                if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (comboBox1.Text != "") && (comboBox1.SelectedIndex != -1))
                {
                    DAO.TelasDAO telasdao = new GrupoSM_Recepcion.DAO.TelasDAO();

                    telasdao.produccion = int.Parse(label10.Text);

                    telasdao.fecha_entrada_produccion = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());

                    telasdao.proveedor = int.Parse(label11.Text);

                    telasdao.metros =double.Parse(textBox3.Text);

                    telasdao.nombre_descripcion = (textBox4.Text);

                    telasdao.composicion = textBox5.Text;

                    telasdao.color = textBox6.Text;

                    telasdao.ancho = double.Parse(textBox7.Text);

                    if (comboBox1.Text == "Tela")
                    {
                        telasdao.tipo = 1;
                    }
                    if (comboBox1.Text == "Combinacion")
                    {
                        telasdao.tipo = 2;
                    }
                    if (comboBox1.Text == "Forro")
                    {
                        telasdao.tipo = 3;
                    }

                    //if(telasdao.ingresatelaalmacen()==1)
                    //{
                    //    MessageBox.Show("Correcto");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Hubo algun error");
                    //}

                    this.Visible = false;

                    this.Close();



                }
                else
                {
                    MessageBox.Show("Por favor, inserte todos los datos completos, o verifique su informacion");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (comboBox1.Text != ""))
            {
                DAO.TelasDAO telasdao = new GrupoSM_Recepcion.DAO.TelasDAO();

                telasdao.cliente = int.Parse(label10.Text);

                telasdao.fecha_entrada = dateTimePicker1.Value;

                telasdao.proveedor = int.Parse(label11.Text);

                telasdao.metros = double.Parse(textBox3.Text);

                telasdao.nombre_descripcion = (textBox4.Text);

                telasdao.composicion = textBox5.Text;

                telasdao.color = textBox6.Text;

                telasdao.ancho = double.Parse(textBox7.Text);

                if (comboBox1.Text == "Tela")
                {
                    telasdao.tipo = 1;
                }

                if (comboBox1.Text == "Combinacion")
                {
                    telasdao.tipo = 2;
                }

                if (comboBox1.Text == "Forro")
                {
                    telasdao.tipo = 3;
                }

                //if(telasdao.ingresatelaalmacen()==1)
                //{
                //    MessageBox.Show("Correcto");
                //}
                

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            else
            {
                MessageBox.Show("Por favor, inserte todos los datos completos, o verifique su informacion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
