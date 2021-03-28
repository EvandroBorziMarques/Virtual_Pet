using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Menu de escolha de Pet
            Console.WriteLine(" 1 - Cachorro \n 2 - Gato \nDigite o código do animal que deseja:");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                //Escolher Dog como Pet.
                case "1":

                    //Colcando nome no Pet.
                    Console.Clear();
                    Console.Write("Vamos criar o seu doguinho! " +
                        "\nQual o nome dele(a)? \nDigite: ");
                    string name = Console.ReadLine();

                    //Colocando cor no pelo do seu Pet.
                    Console.Clear();
                    Console.Write("Qual a cor do pelo? \nDigite: ");
                    string color = Console.ReadLine();

                    //Criação do Dog.
                    Dog dog = new Dog(name, color);

                    Console.WriteLine(dog.Name);
                    Console.WriteLine(dog.Color);
                    Console.WriteLine(dog.Peso);
                    Console.WriteLine(dog.Altura);

                    Console.ReadLine();

                    while (opcao != "")
                    {
                        //Escolhendo a ação com seu Pet.
                        Console.Clear();
                        Console.Write(" 1 - Comer \n 2 - Passear \n 3 - Dormir " +
                            $"\n O que deseja fazer com {dog.Name}? \nDigite um número:");
                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.WriteLine("Bora comer");
                                dog.comer();

                                Console.WriteLine(dog.Peso);
                                Console.WriteLine(dog.Altura);
                                Console.ReadLine();
                                break;

                            default:
                                break;
                        }
                    }
                    Console.ReadLine();
                    break;


                case "2":
                    Console.Clear();
                    Console.WriteLine("Vamos criar o seu gatinho! " +
                        "\nPressione Enter para continuar...");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            Console.Clear();
        }
    }
}
