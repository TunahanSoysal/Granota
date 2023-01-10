using System.ComponentModel.DataAnnotations;

namespace Granota.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? Address { get; set; }

        public Buyer(int id, string name, string password, string? email, int? phone, string? address)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Address = address;
        }
        public Buyer() { }
    }

}
