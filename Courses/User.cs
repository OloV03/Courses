using System;
using System.Collections.Generic;
using System.Text;

namespace Courses
{
    class User
    {
        public string Name { get; set; }
        public double Balance { get; set; } 
        public double Spent { get; set; } // кол-во потраченных денег

        public User(string name, double balance, double spent)
        {
            Name = name;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
