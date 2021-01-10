using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular dispositvo = new Celular();

            Console.WriteLine($"Digite a modelo do celular");
            dispositvo.modelo = Console.ReadLine();
            Console.WriteLine($"Digite a cor do celular");
            dispositvo.cor = Console.ReadLine();
            Console.WriteLine($"Digite o tamanho do celular (cm x cm)");
            dispositvo.tamanho = Console.ReadLine();

            int opcao = 0;
            do
            {
                Console.WriteLine($"Seleciona uma ação com o celular");
                Console.WriteLine($"[1] - Ligar");
                Console.WriteLine($"[2] - Desligar");
                Console.WriteLine($"[3] - Ligação");
                Console.WriteLine($"[4] - Mensagem");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(dispositvo.DispostivoLigado());
                        
                        Console.WriteLine(dispositvo.DispotivoAlerta());
                        break;
                    case 2:
                        Console.WriteLine(dispositvo.DispostivoDesligado());
                        Console.WriteLine(dispositvo.DispotivoAlerta());
                    break;
                    case 3:
                        Console.WriteLine(dispositvo.DispostivoChamada());
                    break;
                    case 4:
                        Console.WriteLine(dispositvo.DispostivoMensagem());
                    break;
                    default:
                        break;
                }
                
            }while(opcao != 0);
        }
    }
}
