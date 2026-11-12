using Xunit;
using SpaceAcademy;
using System.Net.NetworkInformation;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_PreservesDataAndStartsIncomplete()
    {
        var task = new MissionTask(7, "Sjekk antenne");
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
        Assert.False(task.IsCompleted);
    }
    // TODO: Skriv fullføringstesten før du implementerer Complete.
    [Fact]
    public void Calling_CompleteMethod()
    {
        var task = new MissionTask(8, "Check engine");
        task.Complete();
        Assert.True(task.IsCompleted);
    }
    [Fact]
    public void Calling_CompleteMethodTwice()
    {
        var task = new MissionTask(7, "Sjekk antenne");
        task.Complete();
        task.Complete();
        Assert.True(task.IsCompleted);
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
    }
}
