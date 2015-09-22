using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional namespaces
using eRestaurantSystem.Entities;
using System.Data.Entity;
#endregion

namespace eRestaurantSystem.DAL
{
    //this class should be restricted to the access by ONLY 
    //the BLL methods.
    //This class should NOT be accessable outside of the component library
    internal class eRestaurantContext : DbContext
    {
        public eRestaurantContext() : base ("name=EatIn")
        {
            //constructor is used to pass web config string name
        }

        //set up the DbSet mappings
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }

        //When overriding OnModelCreating() it is important to remember to call the base method's implementation before you exit the method

        //the ManyToManyNavigationPropertyConfiguration.Map method lets you
        //configure the tables and columns used for many-to-many relationships
        //it takes a ManyToManyNavigationPropertyConfiguration instance in which
        //you specify the column name b calling the MapLeftKe, malpRightKey,
        //and ToTable

        //the "left" key is the one specified in the HasMany method
        //the "right" key is the one specified in the WithMany method

        // we have a many to many relationship between reservation and tables
        //a reservation may need many tables
        //a table can have over time many reservations

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(x => x.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("TableID");
                    mapping.MapRightKey("ReservationID");
                });
        }
    }
}
