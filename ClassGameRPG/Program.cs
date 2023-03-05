// See https://aka.ms/new-console-template for more information
using System;

namespace ClassGameRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var warrior = new Warrior();
            warrior.Attack();

            var mage = new Mage();
            mage.Attack();

            var archer = new Archer();
            archer.Attack();
        }
    }
    
}

