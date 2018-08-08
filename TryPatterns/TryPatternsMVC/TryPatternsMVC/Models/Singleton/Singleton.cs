using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int callCount = 0;
        private string currentMessage { get; set; }

        private Singleton() { }

        public static Singleton Instance {
            get=>instance;
        }

        public string IncreaseCounter()
        {
            currentMessage = $"Current count of calls: {callCount}";
            callCount++;
            return currentMessage;
        }

        public string ShowMessage(string message)
        {
            currentMessage = message;
            return currentMessage;
        }

    }
}
