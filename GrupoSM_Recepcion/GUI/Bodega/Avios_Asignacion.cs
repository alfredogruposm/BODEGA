using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Resources; 

namespace GrupoSM_Recepcion.GUI.Bodega
{
    public partial class Avios_Asignacion : Form
    {
        public Avios_Asignacion()
        {
            InitializeComponent();
        }
        //comentario de prueba para github

        private void Avios_Asignacion_Load(object sender, EventArgs e)
        {
            
            //aviosdao.id_ficha_avio = int.Parse(label7.Text);
            //aviosdao.fecha = dateTimePicker1.Value;
            //aviosdao.verificaavios();
            verificaavios();
            devuelvecampos();
            
        }





        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            //textBox3.Text = Convert.ToString(double.Parse(label2.Text) * Convert.ToDouble(dataGridView1.CurrentRow.Cells["Ficha"].Value));
            //textBox4.Text = Convert.ToString(double.Parse(textBox1.Text) - Convert.ToDouble(dataGridView1.CurrentRow.Cells["Almacen"].Value));
            //textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Almacen"].Value);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DAO.AviosDAO aviosdao = new GrupoSM_Recepcion.DAO.AviosDAO();
            //aviosdao.idavios = int.Parse(dataGridView1.CurrentRow.Cells["Clave Avio"].Value.ToString());
            //dataGridView2.DataSource = aviosdao.devuelveaviossubgruposcolor();
        }

        

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                 mensaje = "¿" + "De verdad desea agregar el avio " + dataGridView2.CurrentRow.Cells[2].Value.ToString() + " por el avio " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "?" + " Tenga en cuenta que si esta incorrecto el avio tendra que reingresar los datos de nuevo";
            }
            catch
            {
                 mensaje = "¿" + "De verdad desea agregar el avio " + comboBox3.Text + " por el avio " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "?" + " Tenga en cuenta que si esta incorrecto el avio tendra que reingresar los datos de nuevo";
            }
           
            DialogResult result = MessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ingresaalmacen();
                devuelvecampos();
            }
                            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string campo = "Nombre";

            DAO.AviosDAO aviosdao = new GrupoSM_Recepcion.DAO.AviosDAO();
            DataView dv;
            dv = new DataView(aviosdao.devuelvealmacenavio());
            dv.RowFilter = campo + " like '%" + textBox5.Text + "%'";
            dataGridView2.DataSource = dv;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Avios_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string str = e.KeyChar.ToString().ToUpper();
            char[] ch = str.ToCharArray();
            e.KeyChar = ch[0];
        }
        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = e.KeyChar.ToString().ToUpper();
            char[] ch = str.ToCharArray();
            e.KeyChar = ch[0];
        }

        public void verificaavios()
        {
            int comprobacion;
            DAO.AviosDAO aviosdao1 = new GrupoSM_Recepcion.DAO.AviosDAO();
            aviosdao1.idproduccion = int.Parse(label6.Text);
            comprobacion = aviosdao1.existe_produccionavios();
            if (comprobacion == 0)
            {
                MessageBox.Show("Es necesario primero guardar el listado de avios que se utilizaran en la prenda");

            }
            else
            {
                button2.Enabled = true;
            }
        }

        public void devuelvecampos()
        {
            dataGridView5.Visible = false;

            DAO.AviosDAO aviosdao = new GrupoSM_Recepcion.DAO.AviosDAO();

            dataGridView5.DataSource = aviosdao.almacenavioslistado();

            aviosdao.idproduccion = int.Parse(label6.Text);

            dataGridView3.DataSource = aviosdao.devuelvehojadecorteavios();

            Generardatagrid();
            
            aviosdao.idproduccion = int.Parse(label6.Text);

            dataGridView1.DataSource = aviosdao.devuelveaviosasignaciones();

        }

        public void Generardatagrid()
        {
            DAO.AviosDAO aviosdao = new DAO.AviosDAO();

            BindingSource source = new BindingSource();

            string nombre, tipo;
            int clave, id;


            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                aviosdao.nombre = row.Cells[0].Value.ToString();
                dataGridView4.DataSource = aviosdao.datosalmacen();
                nombre = row.Cells[0].Value.ToString();
                tipo = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt16(dataGridView4.CurrentRow.Cells[1].Value.ToString());
                clave = Convert.ToInt16(dataGridView4.CurrentRow.Cells[2].Value.ToString());
                source.Add(new Services.Avios.Avio(nombre, tipo, clave, id));
            }

            dataGridView2.DataSource = source;

            cargacombobox();



        }

        public void cargacombobox()
        {
            comboBox3.Items.Clear();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                comboBox3.Items.Add(row.Cells[2].Value.ToString());
            }
            comboBox3.SelectedIndex = -1;
        }
        
        
        public void ingresaalmacen()
        {
            if (textBox7.Text != "")
            {
                DAO.AviosDAO aviosdao1 = new GrupoSM_Recepcion.DAO.AviosDAO();
                aviosdao1.idproduccion = int.Parse(label6.Text);

                aviosdao1.cantidadd = int.Parse(textBox7.Text);
                aviosdao1.tipoo = comboBox2.Text;
                aviosdao1.nombre = comboBox3.Text;

                string resultado = aviosdao1.insertaalmacen();

                if(resultado=="Correcto")
                {
                    aviosdao1.cantidadd = decimal.Parse(textBox7.Text);
                    aviosdao1.idavioproduccion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Clave"].Value);
                    aviosdao1.ingresaprimeralmacen();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
                
            }
            else
            {
                DAO.AviosDAO aviosdao1 = new GrupoSM_Recepcion.DAO.AviosDAO();
                aviosdao1.idproduccion = int.Parse(label6.Text);

                aviosdao1.cantidadd = int.Parse(textBox2.Text);

                aviosdao1.tipoo = dataGridView2.CurrentRow.Cells["Tipo"].Value.ToString();

                aviosdao1.nombre = dataGridView2.CurrentRow.Cells["Nombre"].Value.ToString();

                string resultado = aviosdao1.insertaalmacen();

                if(resultado=="Correcto")
                {

                    aviosdao1.cantidadd = decimal.Parse(textBox2.Text);
                    aviosdao1.cantidadbodegaa = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Almacen"].Value);

                    aviosdao1.idavioproduccion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Clave"].Value);

                    aviosdao1.ingresaalmacencatalogo();

                }
                else
                {
                    MessageBox.Show(resultado);
                }

            }
            
            limpiatextos();
        }

        public void limpiatextos()
        {
            comboBox2.SelectedIndex = -1;
            textBox7.Text = "";
            textBox2.Text = "";
        }

        public void guardanumeroprendas()
        {
            DAO.AviosDAO aviosdao = new GrupoSM_Recepcion.DAO.AviosDAO();
            aviosdao.idproduccion = int.Parse(label6.Text);
            aviosdao.Color = dataGridView1.CurrentRow.Cells["Color"].Value.ToString();
            label2.Text = aviosdao.numerocolorprendas().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tenga en cuenta que la entrada del avio se eliminara de bodega y de catalogo", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                DAO.AviosDAO aviosdao = new DAO.AviosDAO();
                aviosdao.IDAvioAlmacen = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID"].Value);
                aviosdao.eliminadebodegaalmacen();
                devuelvecampos();
                Generardatagrid();
                cargacombobox();

            }
        }
    }
}
