using Gem_Management_System.Enums;

namespace Gem_Management_System.Entities
{
    public class Trainer:UserGem
    {
        public string Speciality { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<Session> Sessions { get; set; }

    }
}
