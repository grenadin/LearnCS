using System;
using System.Linq;

namespace LearnConsole
{
    class Program
    {
        static void Main()
        {
            SimpleTypeSystem();
            SpeciType();

        }

        public static void SimpleTypeSystem()
        {
            int a = 5;
            int b = a + 2; //OK

            bool test = true;

            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            //int c = a + test;
        }

        public static void SpeciType()
        {
            // Declaration only:
            float temperature;
            string name;
            MyClass myClass;

            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
        }

        
    }

}
