using Xunit;
using SpaceAcademy;
namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsInvalidOperationException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Equal(0, stack.Count);
        stack.Push("A");
        stack.Pop();
        Assert.Equal(0, stack.Count);
        stack.Push("C");
        Assert.Equal("C", stack.Pop());
        Assert.Equal(0, stack.Count);
    }
    // TODO: Test LIFO, telling, gjenbruk og en annen type.
[Fact]
public void Pop_ReturnsItemsInLifoOrderString()
{
var stringStack = new CargoStack<string>();
stringStack.Push("A");
stringStack.Push("B");
Assert.Equal("B", stringStack.Pop());
Assert.Equal(1, stringStack.Count);
Assert.Equal("A", stringStack.Pop());
Assert.Equal(0, stringStack.Count);
}
[Fact]
public void Pop_ReturnsItemsInLifoOrderInt()
    {
        var intStack = new CargoStack<int>();
        intStack.Push(7);
        Assert.Equal(7, intStack.Pop());
        Assert.Equal(0, intStack.Count);
    }
}