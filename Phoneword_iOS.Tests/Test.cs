using NUnit.Framework;
using System;

namespace Phoneword_iOS.Tests
{
  [TestFixture()]
  public class Test
  {
    [Test()]
    public void TestCase()
    {
      var number = PhoneTranslator.ToNumber("1234567890");
      Assert.AreEqual("1234567890", number);
    }
  }
}

