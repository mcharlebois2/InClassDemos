using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.Entities
{
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage="An Even Code is required (only one character).")]
        [StringLength(1, ErrorMessage="Event code can only use a single character code.")]
        public string EventCode { get; set; }
        [Required(ErrorMessage="Description is required (5-30 characters).")]
        [StringLength(30, MinimumLength=5, ErrorMessage="The description must be 5-30 characters long.")]
        public string Description { get; set; }
        public bool Active { get; set; }
        
        //Navigation virtual proporty(s)
        public virtual ICollection<Reservation> Reservations { get; set; }

        //all classes can have there own constructor
        //constructors can contain initialization values
        public SpecialEvent()
        {
            Active = true;
        }
        
    }
}
