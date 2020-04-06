using System;

namespace RentARoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Rent a Room===");
            Console.Write("Digite quantos quartos vão ser alugados: ");
            int qtdRooms = int.Parse(Console.ReadLine());
                      
            Room[] rooms = new Room[10];            
            
            for (int i = 0; i < qtdRooms; i++)
            {
                Console.Write("Digite o numero do quarto de 0 a 9: ");
                int nRoom = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do locatário do quarto "+nRoom+": ");
                string name = Console.ReadLine();
                Console.Write("Digite o email do locatário " + name + " que está no quarto " + nRoom+": ");
                string email = Console.ReadLine();
                rooms[nRoom] = new Room(name, email);
                Console.WriteLine();
            }
            for (int i = 0; i <= 9; i++)
            {
                if (rooms[i]!= null)
                {
                    Console.WriteLine("Rent #"+i+":");
                    Console.WriteLine(rooms[i]);
                    Console.WriteLine("Room: "+i);
                    Console.WriteLine();                    
                }
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i <= 9; i++)
            {                
                if (rooms[i] != null)
                {                    
                    Console.WriteLine(i + ": " + rooms[i].Name + "," + rooms[i].Email);
                }
            }
            Console.ReadLine();
        }
    }
}
