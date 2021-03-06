﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckCode.Ducks;
using DuckCode.FlyBehaviors;

namespace DuckCode
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {

            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();


            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();
            Console.ReadKey();
        }
    }
}
