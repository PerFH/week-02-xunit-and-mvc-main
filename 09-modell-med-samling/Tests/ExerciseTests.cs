using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Add_TwoTasks_AssignsIdsAndStoresTitles()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        Assert.Equal(1, first.Id);
        Assert.Equal(2, second.Id);
        Assert.Equal("Sjekk antenne", first.Title);
        Assert.Equal("Lad rover", second.Title);
        Assert.Equal(2, board.Count);
        Assert.False(first.IsCompleted);
        Assert.False(second.IsCompleted);
    }

    [Fact]
    public void Complete_KnownId_CompletesOnlySelectedTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        bool result = board.Complete(second.Id);
        Assert.True(result);
        Assert.False(first.IsCompleted);
        Assert.True(second.IsCompleted);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void Complete_UnknownId_DoesNotChangeTasks()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad rover");
        Assert.False(board.Complete(99));
        Assert.False(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void GetAll_ReturnsCollectionCopy()
    {
        var board = new MissionBoard();
        board.Add("Lad rover");
        var copy = board.GetAll();
        copy.Clear();
        Assert.Equal(1, board.Count);
    }
    [Fact]
    public void GetAll_ReturnsEmptyCopy()
    {
        var board = new MissionBoard();
        Assert.Equal(0, board.Count);
        var copy = board.GetAll();
        Assert.Empty(copy);

    }
    [Fact]
    public void CanCompleteSameIDTwice()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad Rover");
        Assert.True(board.Complete(1));
        Assert.True(board.Complete(1));
        Assert.True(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }
    [Fact]
    public void TwoIndependentMissionBoards()
    {
        var board = new MissionBoard();
        var board2 = new MissionBoard();
        var task = board.Add("Lad Rover");
        Assert.Equal(1, board.Count);
        Assert.Equal(0, board2.Count);
        Assert.Equal(1, task.Id);
    }
    [Fact]
    public void CopiesListWithObjects()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad rover");
        var copy = board.GetAll();
        Assert.Same(task, copy[0]);
    }
}
