using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Text.Json;

namespace parchis
{
    class parchis
    { //server
        private static IPAddress ServerIP;
        
        static readonly object locker = new object();
        static void Main(String[] args)
        {
            int tictactoePort = 50000;
            ServerIP = IPAddress.Parse("127.0.0.1");
            TcpListener Server = new TcpListener(ServerIP, tictactoePort);
            Console.WriteLine("Server Creat");
            Server.Start();

            while (true)
            {
                TcpClient Client = Server.AcceptTcpClient();
                Console.WriteLine("Client connectat");
                Thread new_client = new Thread(() => connectedPlayer(Client, player));
                new_client.Start();
            }
        }

        static void connections(String ID) {
            
            
        }

        //static void connectedPlayer(TcpClient Client, Player player)
        //{
        //    NetworkStream ServerNS = Client.GetStream();
        //    byte[] BufferLocal = new byte[1024];
        //    try
        //    {
        //        // Convertir objeto a JSON
        //        string jsonString = JsonSerializer.Serialize(player);
        //        byte[] fraseBytes = Encoding.UTF8.GetBytes(jsonString); // Convertir JSON a bytes

        //        // Enviar respuesta al cliente
        //        ServerNS.Write(fraseBytes, 0, fraseBytes.Length);
        //        Console.WriteLine($"Player {player.PlayerID} sent to client.");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        Console.ReadLine();
        //    }
        //}
    }
}