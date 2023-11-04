using System.Numerics;

namespace BinomTests;

[TestClass]
public class FactorialTests
{
    [TestMethod]
    public void Factorial_Short_CorrectResult()
    {
        short number = 5;
        short expected = 120;

        short result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_UShort_CorrectResult()
    {
        ushort number = 5;
        ushort expected = 120;

        ushort result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_UInt_CorrectResult()
    {
        uint number = 5;
        uint expected = 120;

        uint result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_Long_CorrectResult()
    {
        long number = 5;
        long expected = 120;

        long result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_ULong_CorrectResult()
    {
        ulong number = 5;
        ulong expected = 120;

        ulong result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_Float_CorrectResult()
    {
        float number = 5.0f;
        float expected = 120.0f;

        float result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result, 0.0001f); // Using a delta for floating-point comparison
    }

    [TestMethod]
    public void Factorial_Double_CorrectResult()
    {
        double number = 5.0;
        double expected = 120.0;

        double result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result, 0.0001); // Using a delta for floating-point comparison
    }

    [TestMethod]
    public void Factorial_Decimal_CorrectResult()
    {
        decimal number = 5m;
        decimal expected = 120m;

        decimal result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Factorial_BigInteger_CorrectResult()
    {
        BigInteger number = new BigInteger(5);
        BigInteger expected = new BigInteger(120);

        BigInteger result = BinomialMathematics.BinomialMathematics.Factorial(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_NegativeInt_Throws()
    {
        int negativeNumber = -5;

        BinomialMathematics.BinomialMathematics.Factorial(negativeNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void Factorial_Float_NotSupportedException()
    {
        float nonIntegerNumber = 5.5f;

        BinomialMathematics.BinomialMathematics.Factorial(nonIntegerNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void Factorial_Decimal_NotSupportedException()
    {
        decimal nonIntegerNumber = 5.5m;

        BinomialMathematics.BinomialMathematics.Factorial(nonIntegerNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_NegativeInt_ThrowsArgumentOutOfRangeException()
    {
        int negativeNumber = -1;

        BinomialMathematics.BinomialMathematics.Factorial(negativeNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_NegativeLong_ThrowsArgumentOutOfRangeException()
    {
        long negativeNumber = -1L;

        BinomialMathematics.BinomialMathematics.Factorial(negativeNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_NegativeDouble_ThrowsArgumentOutOfRangeException()
    {
        double negativeNumber = -1.0;

        BinomialMathematics.BinomialMathematics.Factorial(negativeNumber);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Factorial_NegativeBigInteger_ThrowsArgumentOutOfRangeException()
    {
        BigInteger negativeNumber = new BigInteger(-1);

        BinomialMathematics.BinomialMathematics.Factorial(negativeNumber);
    }
}