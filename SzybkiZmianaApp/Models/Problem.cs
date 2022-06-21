using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SzybkiZmianaApp.Models
{
    [Table("Problems")]
    public class Problem
    {
            [Key]
            public int IdProblem { get; set; }
            public string Phone { get; set; }
            public string Fault { get; set; }
            public string Details { get; set; }
            public int Cost { get; set; }
            public bool IsDone { get; set; }

            [ForeignKey("Client")]
            public int IdClient { get; set; }
            public Client Client { get; set; }
    }

    [Table("Clients")]
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Problem> Problems { get; set; }

    }
}
