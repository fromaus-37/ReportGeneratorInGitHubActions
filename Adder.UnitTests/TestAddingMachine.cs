using Xunit;
using Adder;

namespace Adder.UnitTests;

public class TestAddingMachine
{
    [Fact]
    public void Add_NonZero()
    {
        //arrange
        AddingMachine obj = new AddingMachine();

        //act
        double result = obj.Add(3.4, 5.6);

        //assert
        Assert.Equal(9, result);
    }


    [Fact]
    public void Add_OneParameterIsZero()
    {
        //arrange
        AddingMachine obj = new AddingMachine();

        //act
        double result = obj.Add(0, 3.4);

        //assert
        Assert.Equal(3.4, result);
    }
}