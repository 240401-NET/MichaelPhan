using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet("/users/{id}/favoriteworkouts")]
        public ActionResult<string> GetUsersFavoriteWorkouts(string? firstName)
        {
            return Ok("hello");        
            
        }

        [HttpGet("/users/{id}/favoriteworkouts/{workoutid}")]
        public ActionResult<string> GetUsersFavoriteWorkoutsById(string? firstName)
        {
            return Ok("hello");        
            
        }

        [HttpPut("/users/{id}/favoriteworkouts/{workoutid}")]
        public ActionResult<string> AddWorkoutToFavorites(string? firstName)
        {
            return Ok("hello");        
            
        }

        [HttpDelete("/users/{id}/favoriteworkouts/{workoutid}")]
        public ActionResult<string> DeleteFavoriteWorkoutById(string? firstName)
        {
            return Ok("hello");        
            
        }

        [HttpDelete("/users/{id}/favoriteworkouts")]
        public ActionResult<string> DeleteAllFavoritedWorkouts(string? firstName)
        {
            return Ok("hello");        
            
        }
    }

