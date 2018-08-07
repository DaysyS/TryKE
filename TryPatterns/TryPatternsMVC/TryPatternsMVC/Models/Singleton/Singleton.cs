using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance {
            get=>instance;
        }

    }
}
