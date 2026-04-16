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
    public partial class Consutar : Form
    {
        DAOAutor dao;

        public Consutar()
        {
            this.dao = new DAOAutor();
            ChamarMetodo(dataGridView1);//configurar metodo
        }

        //chamar metodo
        public void ChamarMetodo(DataGridView dataGrid)
        {
            InitializeComponent();
            ConfigurarDataGrid(dataGrid);//configura estrutura
            nomeColunas(dataGrid);//configura nomes
            AdicinarDados(dataGrid);// configura dados
        }//fim do metodo





        //chamar colunas

        public void nomeColunas(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Name = "Código";
            dataGrid.Columns[1].Name = "Nome";
            dataGrid.Columns[2].Name = "Gênero";
            dataGrid.Columns[3].Name = "Endereço";
        }// fim do metodo

        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGrid.AllowUserToAddRows = false;//Não permitir usuario
            dataGrid.AllowUserToDeleteRows = false;//Não permitir usuario
            dataGrid.AllowUserToResizeColumns = false;//Não permitir usuario
            dataGrid.AllowUserToResizeRows = false;//Não permitir usuario

            dataGrid.ColumnCount = 4;

        }

        public void AdicinarDados(DataGridView dataGrid)
        {
            //primeiro coisa
            this.dao.PreecherVetor();
            for (int i = 0; i < this.dao.contar;i++)
            {
                dataGrid.Rows.Add(this.dao.codigo[i], this.dao.nome[i], this.dao.genero[i], this.dao.endereco[i]);

            }//preencher vetor
        }//fim do adicionar dados







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//fim da classe    
}//fim do projeto
