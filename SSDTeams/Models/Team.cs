using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Class that represents the teams in the database
namespace SSDTeams.Models
{
    public class Team
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime EstablishedDate { get; set; }
    }
}
