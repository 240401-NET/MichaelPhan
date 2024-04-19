using Workout.Models;
namespace Workouts.Data;

public class WorkoutsRepository
{
    private readonly WorkoutsDbContext _context;
    public WorkoutsRepository (WorkoutsDbContext context)
    {
            _context = context;
    }

    public IEnumerable<Users> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public Users CreateNewUser(Users user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }
}
