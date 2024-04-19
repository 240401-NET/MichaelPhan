using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workouts.Data;
using Workout.Models;

namespace Workouts.Controllers;

// want to get an individual favorite workout for each user
// return all favorite workouts for a specific user
// add a workout to a user's favorites
// delete a workout from user's favorite list
// delete all workouts from favorites list

    [Route("api/[controller]")]
    [ApiController]
    public class UsersControllers : ControllerBase
    {
        private readonly IRepository _workRepo;

        public UsersControllers (IRepository repo)
        {
            _workRepo = repo;
        }
                
        [HttpGet("/users/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Users> GetAllUsers()
        {
            var allUsers = _workRepo.GetAllUsers();
            return allUsers;        
        }

        [HttpGet("/users/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Users GetUserById(int id)
        {
            var searchedUser = _workRepo.GetUserById(id);
            return searchedUser;        
        }

        [HttpPost("/users")]
        public Users AddUser(Users user)
        {
            return _workRepo.CreateNewUser(user);        
            
        }

        [HttpPut("/users/{id}")]
        public ActionResult<Users?> EditUserById(int id, Users newUser)
        {
            Users updatedUser = _workRepo.EditUserById(id, newUser);
            if (updatedUser == null)
            {
                return NoContent();
            }
            else
            {
                return updatedUser;
            }
        }


        [HttpDelete("/users/{id}")]
        public ActionResult<Users?> DeleteUserById(int id)
        {
            try {
                Users deletedUser = _workRepo.DeleteUserById(id)!;
                return deletedUser;
            }
            catch(Exception) {
                return Problem();
            }         
        }

        // [HttpGet("/users/{id}/favoriteworkouts")]
        // [ProducesResponseType(StatusCodes.Status200OK)]
        // public ActionResult<string> GetUsersFavoriteWorkouts(int id)
        // {
        //     return Ok("hello");        
            
        // }

        // [HttpGet("/users/{id}/favoriteworkouts/{workoutid}")]
        // public ActionResult<string> GetUsersFavoriteWorkoutsById(string? firstName)
        // {
        //     return Ok("hello");        
            
        // }

        // [HttpPut("/users/{id}/favoriteworkouts/{workoutid}")]
        // public ActionResult<string> AddWorkoutToFavorites(string? firstName)
        // {
        //     return Ok("hello");        
            
        // }

        // [HttpDelete("/users/{id}/favoriteworkouts/{workoutid}")]
        // public ActionResult<string> DeleteFavoriteWorkoutById(string? firstName)
        // {
        //     return Ok("hello");        
            
        // }

        // [HttpDelete("/users/{id}/favoriteworkouts")]
        // public ActionResult<string> DeleteAllFavoritedWorkouts(string? firstName)
        // {
        //     return Ok("hello");        
            
        // }
    }

