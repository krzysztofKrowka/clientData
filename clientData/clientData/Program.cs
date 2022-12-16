namespace clientData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            while (true)
            {
                try
                {
                    Console.WriteLine($"\nAdd client nr {clients.Count+1} (name,surname,height)");
                    var client=new Client();
                    client.Name = Console.ReadLine();
                    client.Surname = Console.ReadLine();
                    client.Height = int.Parse(Console.ReadLine());
                    clients.Add(client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("\n---------------------------------------");
                    for (int i = 0; i < clients.Count; i++)
                    {
                        Console.WriteLine($"\nClient nr {i+1}");
                        Console.WriteLine(clients[i].Name);
                        Console.WriteLine(clients[i].Surname);
                        Console.WriteLine(clients[i].Height);                  
                    }
                    Console.WriteLine("---------------------------------------");
                };
            }
        }
    }
}