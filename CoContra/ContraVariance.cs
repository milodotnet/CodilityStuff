using System;
using NUnit.Framework;

namespace CoContra
{
    [TestFixture]
    public class ContraVariance
    {
        static void SetObject(object o) { }

        private delegate void DoSomething<in T1, in T2>(T1 t1, T2 t2);

        //contrac variance doesnt work for return types only params
        [Test]
        public void ObjectDelegateToStringDoesntThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                Action<string> stringAction = SetObject;
                stringAction("something");
            });
        }
        [Test]
        public void ContraVariantWithGenericAction()
        {
            DoSomething<object, object> logStuff = (p1, p2) =>
            {
                Console.WriteLine(p1);
                Console.WriteLine(p2);
            };

            logStuff("a", "b");

            //do do this the original delegate must be declared with contravariant generic params
            DoSomething<string, string> logStringStuff = logStuff;

            logStringStuff("b", "c");
        }


    }
}