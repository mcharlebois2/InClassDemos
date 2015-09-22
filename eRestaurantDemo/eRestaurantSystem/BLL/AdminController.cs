using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region additional namespaces
using eRestaurantSystem.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel; //use for ODS access
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class AdminController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            using (var context = new eRestaurantContext())
            {
                //retrieve the data from the specialEvents table
                //to do so we will use the DbSet on eRestaurantContext
                //  call special events (done by mapping)

                //method syntax
                return context.SpecialEvents.OrderBy(x => x.Description).ToList();

            }
        }
    }
}
