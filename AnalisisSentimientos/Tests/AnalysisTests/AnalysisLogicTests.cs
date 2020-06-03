using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Type = Domain.Analysis.Type;

namespace Tests
{
    [TestClass]
    public class AnalysisLogicTests
    {
        DateTime d1;
        Entity e1;
        Analysis a1;

        [TestInitialize]
        public void SetUp()
        {
            a1 = new Analysis();
            e1 = new Entity("Baldo");
            d1 = DateTime.Now;
        }

        
    }
}
