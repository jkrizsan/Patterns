﻿using Mediator.ConcreteColleagues;

namespace Mediator
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(
            string from, string to, string message);
    }
}
