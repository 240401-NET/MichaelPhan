using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Workout.Models;

namespace Workouts.Data;

public class WorkoutsDbContext : DbContext {

    public WorkoutsDbContext() : base () {}

    public WorkoutsDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Exercises> Exercises {get; set;}

    public DbSet<Users> Users {get; set;}

}