namespace WebAPI2TutorialClaseDGM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPI2TutorialClaseDGM.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2TutorialClaseDGM.Models.WebAPI2TutorialClaseDGMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI2TutorialClaseDGM.Models.WebAPI2TutorialClaseDGMContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
           new Contact
           {
               ContactId = 1,
               Name = "Jessica Diaz",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jdiaz@etsisi.upm.es",
           },
           new Contact
           {
               ContactId = 2,
               Name = "Jennifer Perez",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jperez@etsisi.upm.es",
           },
           new Contact
           {
               ContactId = 1,
               Name = "Agustin Yague",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "ayague@etsisi.upm.es",
           }

 );
        }
    }
}
