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
                    ["Cities"] = Lesson03.Cities.Run,
                    ["LambdaExpressionsBefore"] = Lesson04.LambdaExpressionsBefore.Run,
                    ["LambdaExpressionsAfter"] = Lesson04.LambdaExpressionsAfter.Run
                };

            foreach (var example in examples)
                if (example.Key.Equals("LambdaExpressionsBefore"))
                    example.Value();
        }
    }
}
