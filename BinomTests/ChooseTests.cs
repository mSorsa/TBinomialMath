using System.Numerics;

namespace BinomTests;

[TestClass]
public class ChooseTests
{
    [TestMethod]
    public void Choose_Int_CorrectResult()
    {
        int n = 5;
        int k = 3;
        int expected = 10;

        int result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_ZeroK_CorrectResult()
    {
        int n = 5;
        int k = 0;
        int expected = 1;

        int result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_ZeroN_CorrectResult()
    {
        int n = 0;
        int k = 0;
        int expected = 1;

        int result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_LargerKThanN_ResultIsZero()
    {
        int n = 3;
        int k = 5;
        int expected = 0;

        int result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Choose_NegativeN_ThrowsArgumentOutOfRangeException()
    {
        int n = -1;
        int k = 1;

        BinomialMathematics.BinomialMathematics.Choose(n, k);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Choose_NegativeK_ThrowsArgumentOutOfRangeException()
    {
        int n = 1;
        int k = -1;

        BinomialMathematics.BinomialMathematics.Choose(n, k);
    }

    [TestMethod]
    public void Choose_Long_CorrectResult()
    {
        long n = 10;
        long k = 3;
        long expected = 120;

        long result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_ULong_CorrectResult()
    {
        ulong n = 20;
        ulong k = 3;
        ulong expected = 1140;

        ulong result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_Float_CorrectResult()
    {
        float n = 10f;
        float k = 3f;
        float expected = 120f;

        float result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result, 0.0001f);
    }

    [TestMethod]
    public void Choose_Double_CorrectResult()
    {
        double n = 10.0;
        double k = 3.0;
        double expected = 120.0;

        double result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void Choose_Decimal_CorrectResult()
    {
        decimal n = 10m;
        decimal k = 3m;
        decimal expected = 120m;

        decimal result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Choose_BigInteger_CorrectResult()
    {
        BigInteger n = new BigInteger(10);
        BigInteger k = new BigInteger(3);
        BigInteger expected = new BigInteger(120);

        BigInteger result = BinomialMathematics.BinomialMathematics.Choose(n, k);

        Assert.AreEqual(expected, result);
    }
}