using Microsoft.EntityFrameworkCore;
using Notely_App.Model;

namespace Notely_App.ConnectDb;

    public class ApplicationData:DbContext
    {
    public ApplicationData(DbContextOptions<ApplicationData> options):base(options)
    {

    }

    public DbSet<Items> Items { get; set; }
    }

