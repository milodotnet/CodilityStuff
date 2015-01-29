using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CoContra
{


    [TestFixture]
    public class CoVariance
    {
        [Test]
        public void StringToObjectDoesntThrow()
        {
            string str = "test";
            Assert.DoesNotThrow(() =>
            {
                object obj = str;    
            });
            
        }

        [Test]
        public void ListToEnuemrable()
        {
            IEnumerable<string> strings = new List<string>();
            Assert.DoesNotThrow(() =>
            {
                IEnumerable<object> objects = strings;
            });

        }

        [Test]
        public void StringToObjArray()
        {
          

            Assert.DoesNotThrow(() =>
            {
                object[] objs = new String[10];
                
            });

        }
        [Test]
        public void IncorrectAssignmentThrowsArrayTypeMismatchException()
        {


            Assert.Throws<ArrayTypeMismatchException>(() =>
            {
                object[] objs = new String[10];
                objs[0] = 5;
            });

        }


        private static void DoSomething(string str){}
        private static string GetSomething()
        {
            return "derp";
        }

        
        [Test]
        public void CovariantAction()        
        {
            //CoVariance for arguments not supported
            //Action<object> doSomething = DoSomething;
        }

        [Test]
        public void CovariantFunc()
        {
            //CoVariance for arguments not supported only returns
             Assert.DoesNotThrow(() =>
             {
                 Func<object> getSomething = GetSomething;
                 Assert.AreEqual("derp", getSomething());
             });
        }

        [Test]
        public void CovariantDelConversion()
        {
            Func<string> getSomethingS = GetSomething;
            //CoVariance for arguments not supported
            Assert.DoesNotThrow(() =>
            {
                Func<object> getSomething = getSomethingS;
                Assert.AreEqual("derp", getSomething());
            });
        }

        [Test]
        public void UnsupportedCovariants()
        {

            //none of these are valie
            //List<object> objs1 = new List<string>();
            //IList<object> objs1 = new List<string>();
            //IEnumerable<object> objs2 = new List<int>();
        }

           [Test]
        public void CoVariantIntefaces()
        {
            var employeGetter = new GetEmployee();
            var employees = employeGetter.Get();
            Assert.AreEqual(1, employees.Count());

            IGet<Person> peopleGetter = employeGetter;
            var people = peopleGetter.Get();
            Assert.AreEqual(1, people.Count());
        }

        public interface IGet<out T>
        {
            IEnumerable<T> Get();
        }
    
        public class GetEmployee : IGet<Employee>
        {
            public IEnumerable<Employee> Get()
            {
                return new List<Employee>{new Employee()};
            }
        }

        public class Person
        {
            
        }

        public class Employee : Person
        {
            
        }
    }


    //out = covariant - spec to gen
    //in = contravariant - gen to spec
}


