using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastramento_Empresa
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cnpj = textBox2.Text;
                string razao = textBox3.Text;
                string fantasia = textBox4.Text;
                string situacao = comboBox1.Text;

                string regime = "";
                if (radioButton1.Checked == true)
                {
                    regime = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    regime = radioButton2.Text;
                }
                else if (radioButton3.Checked == true)
                {
                    regime = radioButton3.Text;
                }

                string data = dateTimePicker1.Text;
                string telefone = maskedTextBox1.Text;
                string capital = textBox1.Text;
                string endereco = textBox5.Text;
                string bairro = textBox8.Text;
                string numero = textBox9.Text;

                string tipo = "";
                if (radioButton4.Checked == true)
                {
                    tipo = radioButton4.Text;
                }
                else if (radioButton5.Checked == true)
                {
                    tipo = radioButton5.Text;
                }

                string porte = "";
                if (radioButton6.Checked == true)
                {
                    porte = radioButton6.Text;
                }
                else if (radioButton7.Checked == true)
                {
                    porte = radioButton7.Text;
                }
                else if (radioButton8.Checked == true)
                {
                    porte = radioButton8.Text;
                }

                string natureza = comboBox2.Text;
                string nome = textBox7.Text;
                string cpf = textBox6.Text;
                string estado = comboBox3.Text;

                MessageBox.Show($"CNPJ: {cnpj}\nRAZÃO SOCIAL: {razao}\nNOME FANTASIA: {fantasia}\nSITUACAO: {situacao}\nREGIME: {regime}\nDATA: {data}\n" +
                    $"TELEFONE: {telefone}\nCAPITAL: {capital}\nENDERECO: {endereco}\nBAIRRO: {bairro}\nNUMERO: {numero}\nESTADO: {estado}\nTIPO: {tipo}\n" +
                    $"PORTE: {porte}\nNATUREZA: {natureza}\nNOME: {nome}\nCPF: {cpf}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
