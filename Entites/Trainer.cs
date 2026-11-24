using GYMSystem_Part01.Enums;

namespace GYMSystem_Part01.Entites
{
    public class Trainer : GymUser
    {
        public Specailities Specailty { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
