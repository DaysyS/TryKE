using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.AbstractFactory
{
    public interface IBear
    {
        string Message { get; }
    }

    public class TeddyBear : IBear
    {
        public string Message => "I am Teddy Bear";
    }

    public class WoodenBear : IBear
    {
        public string Message => "I am Wooden Bear";
    }
}
