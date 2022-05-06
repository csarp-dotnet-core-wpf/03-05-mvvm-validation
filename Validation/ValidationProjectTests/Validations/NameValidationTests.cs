using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;

using ValidationProject.Validations;
using ValidationProject.Static;

namespace ValidationProject.Validations.Tests
{

    [TestClass()]
    public class NameValidationTests
    {
        [TestMethod()]
        public void ShortName()
        {            
            NameValidation nv = new NameValidation();
            ProjectLocalization projectLocalization = new ProjectLocalization();


            ValidationResult actual = nv.Validate("Ag", System.Globalization.CultureInfo.CurrentCulture);            
            Assert.IsFalse(actual.IsValid,"NameValidation: Rövid név esetén a nevet elfogadja.");

            string expectedErrorString = projectLocalization.GetStringResource("validationNameIsShort");
            string actualErrorString = actual.ErrorContent.ToString();
            int actualCompare = expectedErrorString.CompareTo(actualErrorString);

            if (actualErrorString == string.Empty)
                Assert.Fail("NameValidation: Rövid név esetén hibád dob, de a hiba szövege üres");

            Assert.AreEqual(0, actualCompare, "NameValidation: Rövid név esetén hibád dob, de a hiba szövege nem megfelelő");
        }

        [TestMethod()]
        public void FirstLetterNotUppercase()
        {
            NameValidation nv = new NameValidation();
            ProjectLocalization projectLocalization = new ProjectLocalization();


            ValidationResult actual = nv.Validate("nemecsek", System.Globalization.CultureInfo.CurrentCulture);
            Assert.IsFalse(actual.IsValid, "NameValidation: Nem nagybetűvel kezdődő nevet elfogad.");

            string expectedErrorString = projectLocalization.GetStringResource("validationNameFirstLetterNotUppercase");
            string actualErrorString = actual.ErrorContent.ToString();
            int actualCompare = expectedErrorString.CompareTo(actualErrorString);

            if (actualErrorString == string.Empty)
                Assert.Fail("NameValidation: Nem nagybetűvel kezdődő név esetén hibát dob, de a hiba szövege üres");

            Assert.AreEqual(0, actualCompare, "NameValidation: Nem nagybetűvel kezdődő név esetén hibát dob, de a hiba szövege nem megfelelő");
        }
    }
}