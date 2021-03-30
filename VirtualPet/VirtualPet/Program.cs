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
            Console.WriteLine(" 1 - Cachorro \n 2 - Gato \n 0 - Sair \nDigite o código do animal que deseja:");
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

                    while (opcao != "")
                    {
                        //Escolhendo a ação com seu Pet.
                        Console.Clear();
                        Console.WriteLine($"PET--> Name: {dog.Name} | Color: {dog.Color} | Weight: {dog.Weight}KG | Height: {dog.Height}CM |");
                        Console.Write($"O que deseja fazer com { dog.Name}?" +
                        "\n 1 - Comer \n 2 - Passear \n 3 - Dormir \n 0 - Sair" + "\nDigite um número:");
                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.Clear();
                                dog.comer();
                                Console.WriteLine("Bora comer! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "2":
                                Console.Clear();
                                dog.passear();
                                Console.WriteLine("Passear! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "3":
                                Console.Clear();
                                dog.dormir();
                                Console.WriteLine("Vamos dormir! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "0":
                                Console.Clear();
                                Console.WriteLine("Até mais! \n Pressione Enter para sair...");
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;

                            default:
                                break;
                        }
                    }
                    break;


                case "2":
                    Console.Clear();
                    Console.Write("Vamos criar o seu gatinho!" +
                        "\nQual o nome dele(a)? \nDigite: ");
                    name = Console.ReadLine();

                    //Colocando cor no pelo do seu Pet.
                    Console.Clear();
                    Console.Write("Qual a cor do pelo? \nDigite: ");
                    color = Console.ReadLine();

                    //Criação do Dog.
                    Cat cat = new Cat(name, color);

                    while (opcao != "")
                    {
                        //Escolhendo a ação com seu Pet.
                        Console.Clear();
                        Console.WriteLine($"PET--> Name: {cat.Name} | Color: {cat.Color} | Weight: {cat.Weight}KG | Height: {cat.Height}CM |\n" +
                            $"-------------------------------------------------------|");
                        Console.Write($"O que deseja fazer com { cat.Name}?" +
                        "\n 1 - Comer \n 2 - Passear \n 3 - Dormir \n 0 - Sair" + "\nDigite um número:");
                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.Clear();
                                cat.comer();
                                Console.WriteLine("Bora comer! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "2":
                                Console.Clear();
                                cat.passear();
                                Console.WriteLine("Passear! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "3":
                                Console.Clear();
                                cat.dormir();
                                Console.WriteLine("Vamos dormir! \n Pressione Enter para continuar...");
                                Console.ReadLine();
                                break;

                            case "0":
                                Console.Clear();
                                Console.WriteLine("Até mais! \n Pressione Enter para sair...");
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;

                            default:
                                break;
                        }
                    };
                    Console.ReadLine();
                    break;

                case "0":
                    Console.Clear();
                    Console.WriteLine("Até mais! \n Pressione Enter para sair...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            Console.Clear();
        }
    }
}
