using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace when_do_backend.Models
{
    public class Condition
    {
        public int Id { get; set; }
        public int? RuleId { get; set; }
        public Rule? Rule { get; set; }
        public string Field { get; set; } = string.Empty;
        public string Operator { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string LogicalOperator { get; set; } = string.Empty;
        public int Order { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}