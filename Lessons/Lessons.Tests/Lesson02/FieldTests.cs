using Lessons.Lesson02;
using NUnit.Framework;

namespace Lessons.Tests.Lesson02
{
    class FieldTests
    {
        [Test]
        public void Seperate_Instance_Field_References_Contain_Same_Value()
        {
            var person1 = new Person();
            var person2 = new Person();

            Assert.AreEqual(person1.Name, person2.Name);
        }

        [Test]
        public void Updating_Instance_Field_Does_Not_Affect_Other_References()
        {
            var person1 = new Person();
            var person2 = new Person();

            person1.Name = "Jimmy";

            Assert.AreEqual("Jimmy", person1.Name);
            Assert.AreEqual("Bob", person2.Name);
            Assert.AreNotEqual(person1.Name, person2.Name);
        }

        [Test]
        public void Seperate_Static_Field_References_Contain_Same_Value()
        {
            var reference1 = Weekdays.Monday;
            var reference2 = Weekdays.Monday;

            Assert.AreEqual(reference1, reference2);
        }

        [Test]
        public void Updating_Static_Field_Affects_Only_New_References()
        {
            var oldReference = Weekdays.Monday;
            
            Weekdays.Monday = "Tuesday";
            
            var newReference = Weekdays.Monday;

            Assert.AreEqual("Monday", oldReference);
            Assert.AreEqual("Tuesday", newReference);
            Assert.AreEqual("Tuesday", Weekdays.Monday);
        }
    }
}
