using Lab3.Models;

namespace Lab3.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Rsvps.Any())
                return;

            context.Rsvps.AddRange(
                new Rsvp
                {
                    FullName = "Chris How",
                    NeedsAccommodation = true,
                    WorkshopTitle = "Programming Basics"
                },
                new Rsvp
                {
                    FullName = "Chenhao Wei",
                    NeedsAccommodation = true,
                    WorkshopTitle = "Database Design"
                },
                new Rsvp
                {
                    FullName = "Etienne Boutete",
                    NeedsAccommodation = false,
                    WorkshopTitle = "Programming Basics"
                }
            );

            context.SaveChanges();
        }
    }
}