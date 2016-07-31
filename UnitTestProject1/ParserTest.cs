using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using topitworks_hackathon_csharp.com.topitworks.parser;
using topitworks_hackathon_csharp.com.topitworks.parser.impl;

namespace UnitTestProject1
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void testParse()
        {
            Parser parser = new ResumeParser();
            parser.parse(null);
        }
    }
}
