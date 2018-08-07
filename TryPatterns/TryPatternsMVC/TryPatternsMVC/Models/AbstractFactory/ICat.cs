using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.AbstractFactory
{
    public interface ICat
    {
        string Message { get; }
    }

    public class TeddyCat : ICat
    {
        public string Message => "I am Teddy Cat";
    }

    public class WoodenCat : ICat
    {
        public string Message => "I am Wooden Cat";
    }
}
