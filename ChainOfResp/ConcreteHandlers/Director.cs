﻿using System;
using ChainOfResp.Handlers;
using ChainOfResp.Requests;

namespace ChainOfResp.ConcreteHandlers
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
