using Workouts.Data;
using Workout.Models;
using Microsoft.EntityFrameworkCore;

namespace Workouts.Services;

public class WorkoutsService : IWorkoutsServices
{
    private readonly IRepository _workRepo;

    public WorkoutsService (IRepository repo)
    {
        this._workRepo = repo;
    }
    public IEnumerable<Users> GetAllUsers()
    {
        return _workRepo.GetAllUsers();       
    }

    public Users GetUserById(int id)
    {
        return _workRepo.GetUserById(id);
    }

    public Users AddUser(Users user)
    {
        return _workRepo.CreateNewUser(user);
    }


}