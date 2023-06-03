using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyScriptureJournalContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyScriptureJournalContext>>()))
        {
            if (context == null || context.Entry == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Entry.Any())
            {
                return;   // DB has been seeded
            }

            context.Entry.AddRange(
                new Entry
                {
                    Title = "Giants",
                    Notes = "There were agiants in the earth in those days; and also after that, when the sons of God came in unto the daughters of men, and they bare children to them, the same became mighty men which were of old, men of renown.",
                    AddedDate = DateTime.Parse("1989-2-12"),
                    Book = "Genesis",
                    Scripture = "03:12"
                },

                new Entry
                {
                    Title = "A ship",
                    Notes = "And he entered into a ship, and passed over, and came into his own city.",
                    AddedDate = DateTime.Parse("1984-3-13"),
                    Book = "Matthew ",
                    Scripture = "04:29"
                },

                new Entry
                {
                    Title = "I had prayed",
                    Notes = "There were agiants in the earth in those days;  men of renown.",
                    AddedDate = DateTime.Parse("1986-2-23"),
                    Book = "Enos",
                    Scripture = "01:12"
                },

                new Entry
                {
                    Title = "Purchase the lands",
                    Notes = "And they shall be appointed to apurchase the lands, and to make a commencement to lay the foundation of the city;",
                    AddedDate = DateTime.Parse("1959-4-15"),
                    Book = "Doctrine and Covenants",
                    Scripture = "48:6"
                }
            );
            context.SaveChanges();
        }
    }
}