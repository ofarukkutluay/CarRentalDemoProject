using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class PaymentCard:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardExpiration { get; set; }
        public int CardCvv { get; set; }
    }
}
