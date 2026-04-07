using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlAutor
    {
        DAOAutor autor;
        public int opcao;
        public ControlAutor()
        {
            this.autor = new DAOAutor();//abrindo conexão com o bd



        }//fim do construct

        //menu
        public void MostrarMenu()
        {
            Console.WriteLine("-------- MENU --------\n\n"     +
                             "\n 0. Sair"                      +
                             "\n 1. Cadastrar"                 +
                             "\n 2. Consultar tudo"            +
                             "\n 3. Consultar por código"      +
                             "\n 4. Atualizar"                 +
                             "\n 5. Excluir\n"                 +
                             "\nEscolha uma das opções acima");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void ExecutarOperacao()
        {
            do 
            {   
                this.MostrarMenu();
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Autor");
                        //formulario de cadastro
                        Console.WriteLine("informe o nome do autor:");
                        string nome = Console.ReadLine();

                        Console.WriteLine("informe o genero do autor: ");
                        string genero = Console.ReadLine();

                        Console.WriteLine("informe o endereço do autor: ");
                        string endereco = Console.ReadLine();

                        //dadods
                        this.autor.Inserir(nome, genero, endereco);

                        break;
                    case 2:
                        Console.WriteLine("Consultar Tudo - Autor");
                        Console.WriteLine(this.autor.consultarTudo());
                        break;
                    case 3:
                        Console.WriteLine("Consultar por código - Autor");
                        //pedir código
                        Console.WriteLine("informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        //chamar metodo
                        Console.WriteLine(this.autor.consultarPorCodigo(codigo));
                        break;
                    case 4:
                        Console.WriteLine("Atualizar Autor");
                        Console.WriteLine("Informe o código do autor para atualizar");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //menu de atualização
                        Console.WriteLine("Escolha o que quer atualizar: \n\n " +
                                          "\n 1-Nome"                             +
                                          "\n 2-Gênero"                           +
                                          "\n 3-Endereço\n");

                        int opcaocampo = Convert.ToInt32(Console.ReadLine());
                        string campo = "";
                        //Escolha
                        switch (opcaocampo)
                        {
                            case 1:
                                campo = "nome";
                                break;
                            case 2:
                                campo = "genero";
                                break;
                            case 3:
                                campo = "endereco";
                                break;
                            default:
                                Console.WriteLine("Não é possivel atulizar Escolha um código válido");
                                break;
                        }//fim do escolha 
                        Console.WriteLine($"Informe um novo {campo}");
                        string novoDado = Console.ReadLine();   
                        Console.WriteLine(this.autor.Atualiazar(codigo, campo, novoDado));//chamar para atualizar
                        break;

                    case 5:
                        Console.WriteLine("Excluir Autor");
                        //solicita
                        Console.WriteLine("Informe o autor que deseja excluir");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine( this.autor.Deletar(codigo));
                        break;

                    default:
                        Console.WriteLine("Código  informado é invalido");
                        break;
                

                }//fim do mostar menu
            }while (this.opcao != 0);
        }//fim do executar operacão 




    }//fim do controlAutor

}//fim da projeto
