﻿using System;
namespace LiskovSubstitution
{
	public class RubberDuck : Duck
	{
        public override void Quack()
        {
            Console.WriteLine("Mountain duck quack.");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountain duck swim.");
        }
    }
}

