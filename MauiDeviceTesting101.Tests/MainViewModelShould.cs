using MauiDeviceTesting101.Core;
using Xunit;

namespace MauiDeviceTesting101.Tests;

public class MainViewModelShould
{
    [Fact]
    public void IncrementcountOnCounterClicked()
    {
        // Arrange
        var sut = new MainViewModel();
        // Act
        sut.CounterClickedCommand.Execute(null);
        // Assert
        Assert.Equal(1, sut.Count);
    }
}
