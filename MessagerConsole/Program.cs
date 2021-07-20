using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace MessagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HubConnection hub = new HubConnectionBuilder()
                                    .WithUrl("http://localhost:48456/Talking")
                                    .Build();

            hub.On<string>("PublicMessage", msg => Console.WriteLine($" TALKING: {msg}"));

            hub.StartAsync();


            while (true)
            {

                Console.Write("Жду сообщение.. :");
                string message = Console.ReadLine();

                if (message == "exit") break;
                
                    
               

                hub.SendAsync("SendMessage", message);

            }

            Console.WriteLine("До свидания !!");
            Console.ReadLine();





        }



    }
}
