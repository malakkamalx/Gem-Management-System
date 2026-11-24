using Gem_Management_System.Enums;

namespace Gem_Management_System.Entities
{
    public class Member : UserGem
    {
        public DateTime JoinDate { get; set; }
        public string? Photo { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new List<MemberShip>();
    }
}
