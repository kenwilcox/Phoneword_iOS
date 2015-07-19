using NUnit.Framework;
using System;

namespace Phoneword_iOS.Tests
{
  [TestFixture]
  public class PhoneTranslatorTests
  {
    [Test]
    public void TestToNumberWithJustNumbers()
    {
      var number = PhoneTranslator.ToNumber("1234567890");
      Assert.AreEqual("1234567890", number);
    }

    [Test]
    public void TestToNumberWithJustAlpha()
    {
      var number = "DEADBEEF";
      var len = number.Length;
      number = PhoneTranslator.ToNumber(number);
      Assert.AreEqual("33232333", number);
      Assert.AreEqual(len, number.Length);
    }

    [Test]
    public void TestToNumberWithJennysNumber()
    {
      var number = PhoneTranslator.ToNumber("8675309");
      Assert.AreEqual("8675309", number);
    }

    [Test]
    public void TestToNumberWithMissingAlpha()
    {
      var number = PhoneTranslator.ToNumber("***##");
      Assert.AreEqual("", number);
      Assert.AreEqual(0, number.Length);
    }
  }
}
