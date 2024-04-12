﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_6_loops
{
    public class Die
    {

        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public int Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }
        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }
        public override string ToString()
        {
            return _roll.ToString();
        }
        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
            }
        }
    }
}
