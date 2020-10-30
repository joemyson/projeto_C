using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace projeto_C
{
    class exemplo01
    {

        static void linha()
        {

            Console.Write("=========================================")



}

        static void Main(string[] args)
        {
            bool inicio = false;
            while (inicio != true)
            {



                Console.Clear();

                int op;

                ClassConvertString muda = new ClassConvertString();
                ClassOrdena ordena = new ClassOrdena();
                linha();

                Console.SetCursorPosition(15, 1);
                Console.Write("Menu de opções\n");
                linha();
                Console.SetCursorPosition(10, 4);
                Console.Write("1- conversão de string");
                Console.SetCursorPosition(10, 6);
                Console.Write("2-oderna número");
                Console.SetCursorPosition(10, 8);
                Console.Write("3-Finalizar\n\n");
                linha();
                Console.SetCursorPosition(15, 11);
                Console.Write("Opção []");
                Console.SetCursorPosition(21, 11);

                try
                {

                    op = int.Parse(Console.Read());

                    if (op == 1)
                    {

                        Console.WriteLine("\nA frase convertida ->" + muda.entrada());


                    }

                    if (op == 2)
                    {


                        ordena.organizar();
                    }
                    if (op == 3)
                    {

                        Console.Clear();
                        inicio = true;

                        Console.WriteLine("********************************FIM DA EXECUÇÃO*******************************")



                    }
                    else if (op != 1 && op != 2 && op != 3)
                    {
                        Console.WriteLine("\n\n ********************OPÇÃO INVALIDA********************")






                    }
                    Console.ReadLine();


                }
                catch (Exception)
                {
                    Console.Clear();
                    linha();
                    Console.WriteLine("\n digite um dos valores das opções !\n \n tente novamente,ok");

                    linha();
                    Console.Clear();







                }



            }
        }
    }
}
