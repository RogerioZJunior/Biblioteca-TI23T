using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Cadastrar : Form
    {
        DAOAutor autor;

        public Cadastrar()
        {
            InitializeComponent();
            //inserir
            this.autor = new DAOAutor();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Preencha os campos");

            }
            else 
            {
                string nome = textBox1.Text;
                string genero = textBox2.Text;
                string endereco = textBox3.Text;


                //inserir
                this.autor.Inserir(nome, genero, endereco);
                //Limpar campos 
                LimparCampo();
            }
        }//BOTÂO CADASTRAR

        public void LimparCampo()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do caixa de texto do nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do caixa de texto do genero

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do caixa de texto do endereço

    }//fim da classe
}//fim do projeto
