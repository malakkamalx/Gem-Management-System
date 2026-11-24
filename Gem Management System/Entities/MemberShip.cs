using System.ComponentModel.DataAnnotations.Schema;

namespace Gem_Management_System.Entities
{
    public class MemberShip
    {
        public int Id { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        [NotMapped]
        public string Status => EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
