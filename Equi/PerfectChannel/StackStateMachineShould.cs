using Codility.PerfectChannel;
using NUnit.Framework;

namespace Codility.Tests.PerfectChannel
{
    public class StackStateMachineShould
    {
        [TestCase("13+62*7+*", ExpectedResult = 76)] //test normal
        [TestCase("13++62*7+*", ExpectedResult = -1)] //test double operand
        [TestCase("99*9*9*9*9*9*9*9", ExpectedResult = -1)] //test uint12 overflow
        [TestCase("88*8*4*", ExpectedResult = 2048)] //test uint12 overflow
        [TestCase("88*8*4*1+", ExpectedResult = -1)] //test uint12 overflow
        public short Should(string expression)
        {
            return StackStateMachine.Solve(expression);
        }
    }
}