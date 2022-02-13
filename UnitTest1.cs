using Xunit;
using System;

namespace CalculadoraExceptionTest;

public class UnitTest1
{
    [Fact]
    public void Dividir_dezPorZero_retornarException()
    {
        //Arrange
        double a = 10;
        double b = 0;
        Program objeto = new Program();
        //Act
        var ex = Assert.Throws<DividirPorZeroException>(() => objeto.Dividir(a,b));
        //Assert

        Assert.IsAssignableFrom<Exception>(ex.GetBaseException());
        Assert.Equal("Voce tentou dividir por zero!",ex.Message);

    }
}