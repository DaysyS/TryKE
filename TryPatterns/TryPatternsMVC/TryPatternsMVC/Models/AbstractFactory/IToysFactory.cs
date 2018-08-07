using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.AbstractFactory
{
    public interface IToysFactory
    {
        IBear GetBear();
        ICat GetCat();
    }

    // конкретна фабрика (concrete factory)
    public class TeddyToysFactory : IToysFactory
    {
        public IBear GetBear()
        {
            return new TeddyBear();
        }
        public ICat GetCat()
        {
            return new TeddyCat();
        }
    }
    // і ще одна конкретна фабрика
    public class WoodenToysFactory : IToysFactory
    {
        public IBear GetBear()
        {
            return new WoodenBear();
        }
        public ICat GetCat()
        {
            return new WoodenCat();
        }
    }

}
