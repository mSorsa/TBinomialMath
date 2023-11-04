using System.Numerics;

namespace BinomialMathematics;

public static class BinomialMathematics
{
    public static T Factorial<T>(T number) 
        where T : INumber<T>
    {
        var result = T.One;

        // Check if the number is a non-integer value for floating point types.
        if ((number is float f && (f % 1) != 0) ||
            (number is double d && (d % 1) != 0) ||
            (number is decimal m && (m % 1) != 0))
        {
            throw new NotSupportedException("Factorial is not supported for non-integer values.");
        }

        // Check for negative values
        if (number < T.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Factorial of negative is not allowed.");
        }

        for (var i = T.One + T.One; i <= number; i += T.One)
        {
            result *= i;
        }

        return result;
    }

    public static T Choose<T>(T n, T k) 
        where T : INumber<T>
    {
        dynamic lowest = T.Zero;
        if (n < lowest)
            throw new ArgumentOutOfRangeException(nameof(n), "n cannot be a negative number");
        if (k < lowest)
            throw new ArgumentOutOfRangeException(nameof(k), "k cannot be a negative number");

        // If k > n, return 0 as per the definition of "n choose k"
        if (k > n)
            return T.Zero;

        // Since "n choose k" is the same as "n choose (n-k)"
        // we can optimize for the smaller k value to reduce the number of multiplications.
        if (n - k < k)
            k = n - k;

        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    public static T BinomialExpansion<T>(T a, T b, int n) 
        where T : INumber<T>
    {
        var result = T.Zero;

        for (var k = 0; k <= n; k++)
        {
            checked // Add this checked block to ensure overflow exceptions are thrown
            {
                var binomialCoefficient = Choose<T>(T.CreateChecked(n), T.CreateChecked(k));
                var aTerm = Pow(a, n - k);
                var bTerm = Pow(b, k);
                result += binomialCoefficient * aTerm * bTerm;
            }
        }

        return result;
    }

    public static T Pow<T>(T baseValue, int exponent) 
        where T : INumber<T>
    {
        if (exponent < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(exponent), "Exponent must be non-negative");
        }

        var result = T.One;

        while (exponent > 0)
        {
            if (exponent % 2 == 1) 
                result *= baseValue;

            baseValue *= baseValue;
            exponent /= 2;
        }

        return result;
    }

    public static T NegativeBinomialDistribution<T>(T probabilityOfSuccess, int numberOfSuccesses, int numberOfFailures) 
        where T : INumber<T>
    {
        if (probabilityOfSuccess < T.Zero || probabilityOfSuccess > T.One)
        {
            throw new ArgumentOutOfRangeException(nameof(probabilityOfSuccess), "Probability must be between 0 and 1.");
        }

        if (numberOfSuccesses <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfSuccesses), "Number of successes must be positive.");
        }

        if (numberOfFailures < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfFailures), "Number of failures cannot be negative.");
        }

        // Calculate the binomial coefficient for (numberOfFailures + numberOfSuccesses - 1) choose (numberOfSuccesses - 1)
        var binomialCoefficient = Choose<T>(T.CreateChecked(numberOfFailures + numberOfSuccesses - 1), T.CreateChecked(numberOfSuccesses - 1));

        // Calculate p^r and (1-p)^k
        var successProbabilityTerm = Pow(probabilityOfSuccess, numberOfSuccesses);
        var failureProbabilityTerm = Pow(T.One - probabilityOfSuccess, numberOfFailures);

        // Multiply them together to get the result
        var result = binomialCoefficient * successProbabilityTerm * failureProbabilityTerm;

        return result;
    }
}