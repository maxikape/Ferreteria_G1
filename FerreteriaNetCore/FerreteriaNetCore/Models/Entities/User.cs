namespace FerreteriaNetCore.Models.Entities
{
    public class UserModel
    {
        public virtual long Id { get; set; }

        public virtual string Username { get; set; }

        public virtual string Password { get; set; }

        public virtual string Email { get; set; }

        public virtual string Birthdate { get; set; }
    }
}
