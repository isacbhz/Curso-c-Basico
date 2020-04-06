using System;
using System.Collections.Generic;
using System.Text;

namespace RentARoom
{
    class Room
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Room() { }
        public Room(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return "Name: "+Name +"\nEmail: "+Email; 
        }
    }
}
