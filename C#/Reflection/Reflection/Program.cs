using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mathmatic mathmatic = new Mathmatic(3, 5);
            //Console.WriteLine(mathmatic.Plus(2, 3));
            //Console.WriteLine(mathmatic.Plus2());

            var type = typeof(Mathmatic);

            //Mathmatic math = (Mathmatic)Activator.CreateInstance(type, 5, 6);
            //Console.WriteLine(math.Plus(3, 4));
            //Console.WriteLine(math.Plus2());

            var instance = Activator.CreateInstance(type, 6, 7);

            //Console.WriteLine(instance.GetType().GetMethod("Plus2").Invoke(instance, null));

            MethodInfo methodInfo = instance.GetType().GetMethod("Plus2");
            Console.WriteLine(methodInfo.Invoke(instance, null)); ;

            Console.WriteLine("--------------------");
            var methods = type.GetMethods();

            foreach ( var info in methods )
            {
                //Console.WriteLine("Method name: " + info.Name);  //SAME
                Console.WriteLine("Method name: {0}", info.Name);  //SAME
                foreach( var parameterInfo in info.GetParameters())
                    Console.WriteLine("Parameter: " + parameterInfo.Name);

                foreach(var attribute in info.GetCustomAttributes())
                    Console.WriteLine("Attribute name: {0}",attribute.GetType());

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }

    class Mathmatic
    {
        int _s1;
        int _s2;

        public Mathmatic()
        {

        }
        public Mathmatic(int s1, int s2)
        {
            _s1 = s1;
            _s2 = s2;
        }

        public int Plus(int s1, int s2)
        {
            return s1 + s2;
        }

        [MethodName("Other Plus")]
        public int Plus2()
        {
            return _s1 + _s2;
        }
    }

    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string text)
        {

        }
    }
}
