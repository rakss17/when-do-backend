using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace when_do_backend.Models
{
    public class Rule
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public bool IsActive { get; set; }
        public List<Condition> Conditions { get; set; } = new List<Condition>();
        public List<Action> Actions { get; set; } = new List<Action>();
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}