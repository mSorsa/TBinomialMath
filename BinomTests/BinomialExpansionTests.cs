using System.Numerics;

namespace BinomTests;

[TestClass]
public class BinomialExpansionTests
{
    [TestMethod]
    public void BinomialExpansion_Int_Test()
    {
        int a = 1;
        int b = 1;
        int n = 2;
        int expected = 4; 

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void BinomialExpansion_Double_Test()
    {
        double a = 2.0;
        double b = 3.0;
        int n = 2;
        double expected = 25.0;

        double result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void BinomialExpansion_BigInteger_Test()
    {
        BigInteger a = new BigInteger(2);
        BigInteger b = new BigInteger(3);
        int n = 2;
        BigInteger expected = new BigInteger(25);

        BigInteger result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(OverflowException))]
    public void BinomialExpansion_Int_Overflow_ThrowsOverflowException()
    {
        int a = int.MaxValue;
        int b = 1;
        int n = 2;

        BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);
    }

    // Tests with small numbers
    [TestMethod]
    public void BinomialExpansion_SmallNumbers_Test()
    {
        int a = 2;
        int b = 3;
        int n = 2;
        int expected = 25; // (2 + 3)^2 = 25

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    // Tests with zero
    [TestMethod]
    public void BinomialExpansion_ZeroExponent_Test()
    {
        int a = 2;
        int b = 3;
        int n = 0;
        int expected = 1; // (2 + 3)^0 = 1

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void BinomialExpansion_ZeroBase_Test()
    {
        int a = 0;
        int b = 3;
        int n = 2;
        int expected = 9; // (0 + 3)^2 = 9

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    // Tests with one as base
    [TestMethod]
    public void BinomialExpansion_OneAsBase_Test()
    {
        int a = 1;
        int b = 1;
        int n = 3;
        int expected = 8; // (1 + 1)^3 = 8

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    // Tests with a negative base
    [TestMethod]
    public void BinomialExpansion_NegativeBase_Test()
    {
        int a = -2;
        int b = 3;
        int n = 3;
        int expected = 1; // (-2 + 3)^3 = 1

        int result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void BinomialExpansion_LargeNumbers_Test()
    {
        BigInteger a = new BigInteger(100);
        BigInteger b = new BigInteger(100);
        int n = 2;
        BigInteger expected = BigInteger.Pow(new BigInteger(200), 2); // (100 + 100)^2

        BigInteger result = BinomialMathematics.BinomialMathematics.BinomialExpansion(a, b, n);

        Assert.AreEqual(expected, result);
    }
}