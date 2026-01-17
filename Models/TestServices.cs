using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment.Controllers;

namespace Payment.Models
{
    public class TestServices
    {
        public object ServiceName(AddFundsRequest request, string operation)
        { Double updatedBalance =250.75;
            if (operation == "Add")
            {  updatedBalance = 250.75 + request.Amount;}
            if (operation == "Withdraw")
            { updatedBalance = 250.75 - request.Amount;}
           //  updatedBalance = 250.75 + request.Amount; // Example logic
            var response = new
            {
                UserId = 12345,
                NewBalance = updatedBalance,
                Currency = "INR"
            };
            return response;
        }
    }
}