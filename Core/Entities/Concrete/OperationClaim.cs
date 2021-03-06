using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
