using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("ispaymentsuccess")]
        public ActionResult IsPaymentSuccess(PaymentCard paymentCard)
        {
            var result = _paymentService.IsPaymentSuccess(paymentCard);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);


        }
    }
}
