using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests.BusinessLogic
{
    [TestFixture]
    public class IniFileTests
    {
        private List<string> _testLines = new List<string>
            {
                "ABC=123",
                "defgh = true"
            };
        [Test]
        public void ConstructorTest()
        {
            var iniConfig = new IniConfig(_testLines);
            Assert.That(iniConfig.Count, Is.EqualTo(2));
            Assert.That(iniConfig["ABC"], Is.EqualTo("123"));
            Assert.That(iniConfig["abc"], Is.EqualTo("123"));
            Assert.That(iniConfig["Defgh"], Is.EqualTo("true"));
            Assert.That(iniConfig["wrongKey"], Is.Empty);
        }

        [Test]
        public void SetExistingTest()
        {
            var iniConfig = new IniConfig(_testLines);
            iniConfig["abc"] = "456";
            Assert.That(iniConfig["ABC"], Is.EqualTo("456"));
        }

        [Test]
        public void SetNewKeyTest()
        {
            var iniConfig = new IniConfig(_testLines);
            iniConfig["newKey"] = "newValue";
            Assert.That(iniConfig["NEWKEY"], Is.EqualTo("newValue"));
        }

        [Test]
        [ExpectedException]
        public void SetForbiddenNewKeyTest()
        {
            var iniConfig = new IniConfig(_testLines);
            iniConfig.ForbidNewKeys = true;
            iniConfig["newKey"] = "newValue";
        }

        [Test]
        public void GetIniLinesTest()
        {
            var iniConfig = new IniConfig(_testLines);
            iniConfig["newKey"] = "newValue";
            iniConfig["abc"] = "456";
            CollectionAssert.AreEquivalent(iniConfig.GetIniLines(),
                new List<string>
                {
                    "ABC=456",
                    "defgh=true",
                    "newKey=newValue"
                });
        }
    }
}
