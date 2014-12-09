using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLibrary;
using NUnit.Framework;

namespace MyLibrary.Test
{
    public class Class1
    {
        [Test]
        public void Test()
        {
            const int a = 1;
            const int b = 2;
            var c = MyLibrary.Class1.Foo(a, b);
            Assert.AreEqual(3, c);
            var d = MyLibrary.FS.Class1.Bar(a, b);
            Assert.AreEqual(3, d);
        }
    }
}
