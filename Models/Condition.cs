using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace when_do_backend.Models
{
    public class Condition
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public string LogicalOperator { get; set; }
        public int Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}