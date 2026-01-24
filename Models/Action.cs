using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace when_do_backend.Models
{
    public class Action
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string ActionType { get; set; }
        public JsonElement Parameters { get; set; }
        public int Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}