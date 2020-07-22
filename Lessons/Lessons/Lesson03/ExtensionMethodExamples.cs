using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson03
{
    public class ExtensionMethodExamples
    {
        public static void Run()
        {
            var myClass = new MyClass();
            myClass.M1();
            myClass.M2();
            myClass.M3();
            myClass.M4();
            myClass.M5("This is method five.");
        }
    }
}
