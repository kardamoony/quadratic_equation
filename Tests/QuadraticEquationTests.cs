using NUnit.Framework;
using QuadraticEquation.Core;

namespace quadratic_equation.Tests
{
    [TestFixture]
    public class QuadraticEquationTests
    {
        [Test]
        public void Solution_WithArgs_a1_b0_c1_ReturnsEmpty()
        {
            var a = 1d;
            var b = 0d;
            var c = 1d;
            
            var roots = Solution.Solve(a, b, c);
            
            CollectionAssert.AreEqual(roots, Array.Empty<double>());
        }

        [Test]
        public void Solution_WithArgs_a1_b0_c1neg_Returns_1neg_1()
        {
            var a = 1d;
            var b = 0d;
            var c = -1d;

            var rootsExpected = new[]{ -1d, 1d };
            var roots = Solution.Solve(a, b, c);
            
            CollectionAssert.AreEquivalent(rootsExpected,roots);
        }

        [Test]
        public void Solution_WithArgs_a1_b2_c1_Returns_1neg()
        {
            var a = 1d;
            var b = 2d;
            var c = 1d;

            var rootsExpected = new[]{ -1d };
            var roots = Solution.Solve(a, b, c);
            
            CollectionAssert.AreEquivalent(rootsExpected,roots);
        }
        
        [Test]
        public void Solution_WithArgs_a0_ThrowsArgumentException()
        {
            var a = 0d;
            var b = 0d;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }

        [Test]
        public void Solution_WithArgs_a0Approximate_ThrowsArgumentException()
        {
            var a = double.Epsilon / 2d;
            var b = 0d;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }

        [Test]
        public void Solution_WithArgs_aNan_ThrowsArgumentException()
        {
            var a = double.NaN;
            var b = 0d;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_aPositiveInf_ThrowsArgumentException()
        {
            var a = double.PositiveInfinity;
            var b = 0d;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_aNegativeInf_ThrowsArgumentException()
        {
            var a = double.NegativeInfinity;
            var b = 0d;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_bNan_ThrowsArgumentException()
        {
            var a = 1d;
            var b = double.NaN;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_bPositiveInf_ThrowsArgumentException()
        {
            var a = 1d;
            var b = double.PositiveInfinity;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_bNegativeInf_ThrowsArgumentException()
        {
            var a = 1d;
            var b = double.NegativeInfinity;
            var c = 1d;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_cNan_ThrowsArgumentException()
        {
            var a = 1d;
            var b = 0d;
            var c = double.NaN;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_cPositiveInf_ThrowsArgumentException()
        {
            var a = 1d;
            var b = 0d;
            var c = double.PositiveInfinity;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
        
        [Test]
        public void Solution_WithArgs_cNegativeInf_ThrowsArgumentException()
        {
            var a = 1d;
            var b = 0d;
            var c = double.NegativeInfinity;
            
            Assert.Throws<ArgumentException>(() => Solution.Solve(a, b, c));
        }
    }
}

