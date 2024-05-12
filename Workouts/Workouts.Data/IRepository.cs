using Workout.Models;

namespace Workouts.Data;

public interface IRepository
{
    IEnumerable<Users> GetAllUsers();

    Users CreateNewUser(Users user);

    Users GetUserById(int id);

    Users DeleteUserById(int id);

    Users EditUserById(int id, Users newUser);

    // IEnumerable<Exercises> GetFavoriteExercises(int id);

    IEnumerable<Exercises> GetAllExercises();

    Exercises AddNewExercise(Exercises exercise);

    Exercises GetExercisesById(int id);
}