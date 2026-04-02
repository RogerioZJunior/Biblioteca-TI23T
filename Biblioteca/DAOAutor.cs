 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Biblioteca
{

    class DAOAutor
    {
        public MySqlConnection conexao;//variavel do sql
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] nome;
        public string[] genero;
        public string[] endereco;
        public int i;
        public int contar;
        public string msg;

        public DAOAutor()
        {
            //conexão com o banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=registro;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                this.conexao.Open();//abrir conexão
                Console.WriteLine("Conectado com sucesso");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado! \n\n {erro}");
                this.conexao.Close();//fecha conexão com bd
            }//fim do try catch
        }//fim do DAOAutor

        //Inserir dados no bd

        public void Inserir(string nome, string genero, string endereco)
        {
            try
            {
                this.dados = $"('','{nome}','{genero}','{endereco}')";
                this.comando = $"Insert into autor (codigo, nome, genero, endereco) values{this.dados}";
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" +  sql.ExecuteNonQuery();
                Console.WriteLine($"Inserido com sucesso! \n\n{resultado}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado\n\n {erro}");
            }//fim do catch           
        }
         
       //preencher vetor 

        public void PreecherVetor()
        {
            string query = "select * from autor";
            //instaciar vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.genero = new string[100];
            this.endereco = new string[100];

            //preencher os vetores com valores
            for(i = 0; i < 100; i++)
            {
                this.codigo[i]   = 0;
                this.nome[i]     = "";
                this.genero[i]   = "";
                this.endereco[i] = "";
            }//fim do for

            //executar comando
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //Leitura de dados
            MySqlDataReader leitura = coletar.ExecuteReader();//percore o banco e traz dados

            i= 0;
            this.contar = 0;
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["Nome"] + "";
                this.genero[i] = leitura["genero"] + "";
                this.endereco[i] = leitura["endereco"] + "";
                i++;
                this.contar++;//contar dados no banco
            }//fim do while
                
           leitura.Close();//fim da busca
        }//fim do metodo

        public string consultarTudo()
        {
            PreecherVetor();//preecher os vetores
            this.msg = "";
            for(int i = 0;i < this.contar; i++)
            {
                this.msg += $"\nCódigo: {this.codigo[i]}"         +
                            $"\nNome: {this.nome[i]}"             +
                            $"\nGenero: {this.genero[i]}"         +
                            $"\nEndereço: {this.endereco[i]}\n\n ";
            } 
            return this.msg;
        }//fim do tudo


        public string consultarPorCodigo(int codigo)
        {
            PreecherVetor();//preecher os vetores
            this.msg = "";
            for (int i = 0; i < this.contar; i++)
            {
                if (this.codigo[i] == codigo)
                {

                    this.msg += $"\nCódigo: {this.codigo[i]}" +
                                $"\nNome: {this.nome[i]}" +
                                $"\nGenero: {this.genero[i]}" +
                                $"\nEndereço: {this.endereco[i]}\n\n ";


                    return this.msg;
                }//fim do if
            }
            return "Código informado não existe!";
        }//fim do consulta por código

        public string Atualiazar(int codigo, string campo,  string novoDado)
        {
            try
            {
                string query = $"update autor set{campo} = '{novoDado}' where codigo = '{codigo}' ";

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return $"Atualizado com sucesso\n\n {resultado}";

            }catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }
        }//fim do metodo

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"Delete from autor where codigo = '{codigo}'";

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return $"Atualizado com sucesso\n\n {resultado}";

            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }
        }//fim do metodo






    }//fim da classe
}//fim do projeto
