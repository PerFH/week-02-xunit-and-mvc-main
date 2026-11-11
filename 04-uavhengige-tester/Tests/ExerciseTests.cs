using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay();
        Assert.Equal(0, bay.Count);
    }
    
    [Fact]
    public void Constructor_HasOne()
    {
        var bay = new CargoBay();
        Assert.True(bay.TryAdd("mat"));
        Assert.Equal(1, bay.Count);
    }
    
    [Fact]
    public void Constructor_HasTwo()
    {
        var bay = new CargoBay();
        bay.TryAdd("mat");
        Assert.True(bay.TryAdd("vann"));
        Assert.Equal(2, bay.Count);
    }

    [Fact]
    public void Constructor_CantAddMore()
    {
        var bay = new CargoBay();
        bay.TryAdd("mat");
        bay.TryAdd("vann");
        Assert.False(bay.TryAdd("verktøy"));
        Assert.Equal(2, bay.Count);
        
    }
    [Fact]
    public void Constructor_TwoBays()
    {
        var bay1 = new CargoBay();
        var bay2 = new CargoBay();
        bay1.TryAdd("mat");
        Assert.Equal(1, bay1.Count);
        Assert.Equal(0, bay2.Count);
    }
    // TODO: Flere tester. Opprett et nytt CargoBay i hver test.
}