using System;

namespace GameBackendSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                Birthyear = 1998,
                Firstname = "Enver",
                Lastname="yıldırım",
                IdentityNumber=12345
            }) ;
        }
    }
}
