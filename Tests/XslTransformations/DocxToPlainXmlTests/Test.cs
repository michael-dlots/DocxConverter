using System.Reflection;
using DocxConverter.XslTransformations;
using NUnit.Framework;

namespace Tests.XslTransformations.DocxToPlainXmlTests
{
  [TestFixture]
  public class Test : XslTransformationsTestBase
  {
    protected override XslTransformation CreateXslTransformation ()
    {
      return CreateXslTransformation ("DocxToPlainXml.xslt");
    }

    [Test]
    public void Paragraph ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod());
    }

    [Test]
    public void Italic ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod());
    }

    [Test]
    public void Bold ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void ItalicAndBold ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void Whitespace ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod());
    }

    [Test]
    public void EmptyTags ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod());
    }

    [Test]
    public void HeadingLevelOne ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void HeadingLevelTwo ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void HeadingLevelThree ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void Integration ()
    {
      AssertTransformXml (MethodBase.GetCurrentMethod());
    }
  }
}