using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Granota.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        [Display(Name = "Owner")]
        public virtual int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; }
    


        public Restaurant(int restaurantId, string restaurantName, int ownerId)
        {
            RestaurantId = restaurantId;
            RestaurantName = restaurantName;
            OwnerId = ownerId;
        }
    }
}
