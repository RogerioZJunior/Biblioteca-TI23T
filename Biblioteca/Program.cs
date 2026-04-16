using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal class Program
    {
        //definir ponto de entrada
        [STAThread]
        static void Main(string[] args)
        {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Menu());  



        }//fim do main

    }//fim da classe
}//fim do projeto 

