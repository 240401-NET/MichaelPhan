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
}