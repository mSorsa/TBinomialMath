namespace BinomTests;

[TestClass]
public class NegativeBinomialDistributionTests
{
    [TestMethod]
    public void NegativeBinomialDistribution_StandardCase_CorrectResult()
    {
        double probabilityOfSuccess = 0.5;
        int numberOfSuccesses = 3;
        int numberOfFailures = 2;
        double expected = 0.1875; 

        double result = BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void NegativeBinomialDistribution_SmallProbabilityOfSuccess_CorrectResult()
    {
        double probabilityOfSuccess = 0.1;
        int numberOfSuccesses = 2;
        int numberOfFailures = 5;
        double expected = 0.0354; 

        double result = BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    public void NegativeBinomialDistribution_HighProbabilityOfSuccess_CorrectResult()
    {
        double probabilityOfSuccess = 0.9;
        int numberOfSuccesses = 2;
        int numberOfFailures = 1;
        double expected = 0.162; 

        double result = BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);

        Assert.AreEqual(expected, result, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void NegativeBinomialDistribution_NegativeProbabilityOfSuccess_ThrowsArgumentOutOfRangeException()
    {
        double probabilityOfSuccess = -0.1;
        int numberOfSuccesses = 2;
        int numberOfFailures = 3;

        BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void NegativeBinomialDistribution_ProbabilityOfSuccessGreaterThanOne_ThrowsArgumentOutOfRangeException()
    {
        double probabilityOfSuccess = 1.1;
        int numberOfSuccesses = 2;
        int numberOfFailures = 3;

        BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void NegativeBinomialDistribution_NonPositiveNumberOfSuccesses_ThrowsArgumentOutOfRangeException()
    {
        double probabilityOfSuccess = 0.5;
        int numberOfSuccesses = 0;
        int numberOfFailures = 3;

        BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void NegativeBinomialDistribution_NegativeNumberOfFailures_ThrowsArgumentOutOfRangeException()
    {
        double probabilityOfSuccess = 0.5;
        int numberOfSuccesses = 3;
        int numberOfFailures = -1;

        BinomialMathematics.BinomialMathematics.NegativeBinomialDistribution(probabilityOfSuccess, numberOfSuccesses, numberOfFailures);
    }
}