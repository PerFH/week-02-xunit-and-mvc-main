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
    public void GetPending_MixedBoard_ReturnsOnlyIncompleteTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        board.Complete(first.Id);
        var pending = board.GetPending();
        Assert.Single(pending);
        Assert.Same(second, pending[0]);
        Assert.Equal(2, board.Count);
    }
    [Fact]
    public void GetPending_ReturnsEmptyCopy()
    {
        var board = new MissionBoard();
        var pending = board.GetPending();
        Assert.Empty(pending);
    }

    [Fact]
    public void GetPending_ReturnsOnlyIncompleteTasks()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        var pending = board.GetPending();
        Assert.Equal(2, pending.Count);
        
    }
    [Fact]
    public void AllMissionsComplete_GetPendingReturnsEmptyList()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        board.Complete(first.Id);
        board.Complete(second.Id);
        var pending = board.GetPending();
        Assert.Equal(2, board.Count);
        Assert.Empty(pending);
    }
    [Fact]
    public void MissionOrder_IsPreservedInPendingList()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        var third = board.Add("Kontroller drivstoff");
        board.Complete(second.Id);
        var pending = board.GetPending();
        Assert.Same(first, pending[0]);
        Assert.Same(third, pending[1]);
        Assert.Equal(3, board.Count);
    }
    [Fact]
    public void GetPending_ReturnsFullCopyWhenAllMissionsArePending()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        var pending = board.GetPending();
        Assert.Same(first, pending[0]);
        Assert.Same(second, pending[1]);
        pending.Clear();
        Assert.Equal(2, board.Count);
        pending = board.GetPending();
        Assert.Same(first, pending[0]);
        Assert.Same(second, pending[1]);

    }
    // TODO: Tom, alle ufullførte, alle fullførte, rekkefølge og samlingskopi.
}
/*

Test E: Resultatlisten er en kopi

Legg til to ufullførte oppdrag.

Hent listen med GetPending() og kontroller at den inneholder begge oppdragene.

Kall deretter Clear() på resultatlisten.

Kontroller at:

Tavlens Count fortsatt er 2.
Et nytt kall til GetPending() fortsatt returnerer begge oppdragene.
Dette viser at du kan endre den returnerte listen uten å endre tavlens interne liste.

Kjør testene på nytt.

Noen av de nye testene kan allerede bestå. Det er helt greit. Hvis en test feiler, undersøk hvorfor og rett implementasjonen.

Når du er ferdig, skal du ha ti beståtte tester totalt: fem ferdige og fem du har skrevet selv.
*/