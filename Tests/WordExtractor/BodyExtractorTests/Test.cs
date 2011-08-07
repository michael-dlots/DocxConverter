using System;
using System.Reflection;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocxConverter.WordExtractor;
using Jolt.Testing.Assertions.NUnit.SyntaxHelpers;
using NUnit.Framework;

namespace Tests.WordExtractor.BodyExtractorTests
{
  [TestFixture]
  public class Test : TestBase
  {
    private BodyExtractor _bodyExtractor;

    [SetUp]
    public void SetUp ()
    {
      _bodyExtractor = new BodyExtractor();
    }

    [Test]
    public void GetBody ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod());
    }

    [Test]
    public void AcceptTextFormatChange ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    [Ignore]
    public void AcceptParagraphFormatChange ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void AcceptTextInsertion ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void AcceptParagraphWithTextInsertion ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void AcceptParagraphInsertion ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    public void AcceptMultipleRunInsertion ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    [Ignore]
    public void RejectTable ()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }

    [Test]
    [Ignore]
    public void RejectMath()
    {
      AssertGetBody (MethodBase.GetCurrentMethod ());
    }


    private void AssertGetBody (MethodBase currentMethod)
    {
      XDocument actual;
      using (WordprocessingDocument document = WordprocessingDocument.Open (GetSourceFileName (currentMethod), true))
      {
        actual = _bodyExtractor.GetBody (document);
      }

      XDocument expected = XDocument.Load (GetResultFileName (currentMethod));

      using (var actualReader = actual.CreateReader())
      {
        using (var expectedReader = expected.CreateReader())
        {
          Assert.That (actualReader, IsXml.EquivalentTo (expectedReader));
        }
      }
    }

    private string GetSourceFileName (MethodBase currentMethod)
    {
      return GetFileName (currentMethod, "Source", "docx");
    }

    private string GetResultFileName (MethodBase currentMethod)
    {
      return GetFileName (currentMethod, "Result", "xml");
    }
  }
}