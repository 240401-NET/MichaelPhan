using Workout.Models;
using Workouts.Data;

namespace Workouts.Services;

public interface IWorkoutsServices
{
    IEnumerable<Users> GetAllUsers();

    Users GetUserById(int id);

    Users AddUser(Users user);
}