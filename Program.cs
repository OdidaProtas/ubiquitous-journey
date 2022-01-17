using System;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UDPSocket s = new UDPSocket();
                s.Server("192.168.88.21", 27000);
                // UDPSocket c = new UDPSocket();
                // c.Client("192.168.88.21", 27000);
                // c.Send("ping ping pong, it works!n!!");

                Console.ReadKey();
 
                // s._socket.Close();
                Console.WriteLine("Closed Server \n Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
