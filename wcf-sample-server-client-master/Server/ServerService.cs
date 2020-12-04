using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    public class ServerService : IServerService
    {
        private string _sessionName = "";

        public void StoreSession(string sessionName)
        {
            _sessionName = sessionName;
        }

        public string GetSessionName()
        {
            return _sessionName;
        }

        public void SendString(string name)
        {
            Console.WriteLine($"Received: {name}");
        }

        public bool Test(string input)
        {
            Console.WriteLine($"Test: {input}");
            return true;
        }
    }
}
