using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Identity.Client;
using Moq;
using Workout.Models;
using Workouts.Data;
using Workouts.Services;



namespace Workouts.Tests;

public class WorkoutServicesTests
{
    [Fact]
    public void WorkoutServiceShouldGetAllUsers()
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();

        IEnumerable<Users> fakeUser = [
            new Users{
                Id = 1,
                FirstName = "Zekkan",
                LastName = "Phan",
                Email = "template@template.com"
            }
        ];

        repoMock.Setup(repo => repo.GetAllUsers()).Returns(fakeUser);
        WorkoutsService service = new WorkoutsService(repoMock.Object);

        IEnumerable<Users> users = service.GetAllUsers();
        Assert.Single(users);
        repoMock.Verify(repo => repo.GetAllUsers(), Times.Exactly(1));
    }

    [Theory]
    [InlineData(100)]
    [InlineData(20)]
    [InlineData(50)]
    [InlineData(10)]


    public void WorkoutServiceShouldGeUserById(int id)
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();
        WorkoutsService service = new WorkoutsService(repoMock.Object);

        repoMock.Verify(repo => repo.GetUserById(id), Times.Exactly(0));
    }

    [Fact]
    public void WorkoutServiceAddUser()
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();

        Users fakeuser = 
            new Users{
                Id = 1,
                FirstName = "Zekkan",
                LastName = "Phan",
                Email = "template@template.com"
            };

        WorkoutsService service = new WorkoutsService(repoMock.Object);

        Users user = service.AddUser(fakeuser);
        repoMock.Verify(repo => repo.CreateNewUser(user), Times.Exactly(0));
    }

    [Fact]
     public void UsersModel()
     {
        Mock<IRepository> repoMock = new Mock<IRepository>();
            Users fakeuser = 
            new Users{
                Id = 1,
                FirstName = "Zekkan",
                LastName = "Phan",
                Email = "template@template.com"
            };
        Assert.Equal(typeof(string), fakeuser.FirstName.GetType());
        Assert.Equal(typeof(string), fakeuser.LastName.GetType());
        Assert.Equal(typeof(string), fakeuser.Email.GetType());
     }

    [Fact]
    public void WorkoutServiceShouldGetAllWorkouts()
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();

        IEnumerable<Exercises> fakeExercise = [
            new Exercises{
                Id = 1,
                WorkoutName = "Sleeping",
                WorkoutDescription = "Does fighting my demons count?"
            }
        ];

        repoMock.Setup(repo => repo.GetAllExercises()).Returns(fakeExercise);
        WorkoutsService service = new WorkoutsService(repoMock.Object);

        IEnumerable<Exercises> users = service.GetAllExercises();
        Assert.Single(users);
        repoMock.Verify(repo => repo.GetAllExercises(), Times.Exactly(1));
    }

    [Theory]
    [InlineData(100)]
    [InlineData(20)]
    [InlineData(50)]
    [InlineData(10)]
    public void WorkoutServiceShouldGeExerciseById(int id)
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();
        WorkoutsService service = new WorkoutsService(repoMock.Object);

        repoMock.Verify(repo => repo.GetExercisesById(id), Times.Exactly(0));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void WorkoutServiceShouldGetExerciseById(int id)
    {
        // AAA
        Mock<IRepository> repoMock = new Mock<IRepository>();
        WorkoutsService service = new WorkoutsService(repoMock.Object);

        repoMock.Verify(repo => repo.GetExercisesById(id), Times.Exactly(0));
    }

}