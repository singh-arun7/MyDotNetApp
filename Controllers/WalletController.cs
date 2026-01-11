using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWalletBalance()
        {
            // Placeholder logic for retrieving wallet balance
            var walletBalance = new
            {
                UserId = 12345,
                Balance = 250.75,
                Currency = "INR"
            };
            return Ok(walletBalance);
        }
        [HttpPost]
        public IActionResult AddFunds([FromBody] AddFundsRequest request)
        {
            // Placeholder logic for adding funds to the wallet
            if (request.Amount <= 0)
            {
                return BadRequest("Amount must be greater than zero.");
            }
            var updatedBalance = 250.75 + request.Amount; // Example logic
            var response = new
            {
                UserId = 12345,
                NewBalance = updatedBalance,
                Currency = "INR"
            };
            return Ok(response);
        }
    }
}
