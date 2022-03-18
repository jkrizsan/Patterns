﻿using System;

namespace Mediator.ConcreteColleagues
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public Chatroom Chatroom { get; set; }
        
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}
