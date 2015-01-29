using System;
using System.Collections.Generic;

namespace Codility.PerfectChannel
{
    public class StackStateMachine
    {
        public static short Solve(string expression)
        {
            var processingStack = new Stack<short>();
            try
            {
                foreach (var character in expression)
                {

                    switch (character)
                    {
                        case '+':
                        {
                            var a = processingStack.Pop();
                            var b = processingStack.Pop();
                            var initialResult = Convert.ToInt16(a + b);
                            if(initialResult > 2048)
                                throw new OverflowException();

                            processingStack.Push(initialResult);
                            break;
                        }

                        case '*':
                        {
                            var a = processingStack.Pop();
                            var b = processingStack.Pop();
                            var initialResult = Convert.ToInt16(a * b);
                            if (initialResult > 2048)
                                throw new OverflowException();

                            processingStack.Push(initialResult);
                            break;
                        }
                        default :
                        {
                            processingStack.Push(Int16.Parse(character.ToString()));
                            break;
                        }
                    }

                }
            }
            catch (InvalidOperationException)
            {
                return -1;
            }

            catch (OverflowException)
            {
                return -1;
            }
           
            return processingStack.Pop();
        }
    }
}