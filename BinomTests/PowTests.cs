using System.Numerics;

namespace BinomTests;

[TestClass]
public class PowTests
{
    [TestMethod]
    public void Pow_Int_Base2_Exponent3_CorrectResult()
    {
        int baseValue = 2;
        int exponent = 3;
        int expected = 8;

        int result = BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Pow_Double_Base1_5_Exponent2_CorrectResult()
    {
        double baseValue = 1.5;
        int exponent = 2;
        double expected = 2.25;

        double result = BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void Pow_Decimal_Base2_Exponent0_CorrectResult()
    {
        decimal baseValue = 2;
        int exponent = 0;
        decimal expected = 1;

        decimal result = BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Pow_BigInteger_Base3_Exponent4_CorrectResult()
    {
        BigInteger baseValue = new BigInteger(3);
        int exponent = 4;
        BigInteger expected = new BigInteger(81);

        BigInteger result = BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);

        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Pow_Int_NegativeExponent_ThrowsArgumentOutOfRangeException()
    {
        int baseValue = 2;
        int exponent = -1;

        BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Pow_Long_NegativeExponent_ThrowsArgumentOutOfRangeException()
    {
        long baseValue = 2L;
        int exponent = -1;

        BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Pow_Float_NegativeExponent_ThrowsArgumentOutOfRangeException()
    {
        float baseValue = 2f;
        int exponent = -1;

        BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Pow_Double_NegativeExponent_ThrowsArgumentOutOfRangeException()
    {
        double baseValue = 2.0;
        int exponent = -1;

        BinomialMathematics.BinomialMathematics.Pow(baseValue, exponent);
    }
}