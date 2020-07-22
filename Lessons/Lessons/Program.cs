using System;
using System.Collections.Generic;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            var examples
                = new Dictionary<string, Action>
                {
                    ["Fields"] = Lesson02.FieldExamples.Run,
                    ["Properties"] = Lesson02.PropertyExamples.Run,
                    ["ExtensionMethods"] = Lesson03.ExtensionMethodExamples.Run,
                    ["Cities"] = Lesson03.Cities.Run
                };

            foreach (var example in examples)
                if (example.Key.Equals("Cities"))
                    example.Value();
        }
    }
}
