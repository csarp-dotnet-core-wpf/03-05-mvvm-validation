using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ValidationProject.Validations.ValidationRules;

namespace ValidationProject.Validations.ValidationRules.Tests
{
    [TestClass()]
    public class NameValidationTests
    {
        [TestMethod()]
        public void NameValidationTest()
        {
            // 1. A név rövid
            NameValidationRules nameValidationShortName = new NameValidationRules("Ag");
            bool expected = true;
            bool actual = nameValidationShortName.IsNameShort;
            Assert.AreEqual(expected, actual, "IsNameShort: rövid név esetén nem true");

            // 1. A név hosszú
            NameValidationRules nameValidationLongName = new NameValidationRules("János");
            expected = false;
            actual = nameValidationLongName.IsNameShort;
            Assert.AreEqual(expected, actual, "IsNameShort: hosszú név esetén nem false");


            // 2. A név nagy betűvel kezdődik
            NameValidationRules nameValidationFirstLetterUppercase = new NameValidationRules("PéteRRR");
            expected = true;
            actual = nameValidationFirstLetterUppercase.IsFirstLetterUppercase;
            Assert.AreEqual(expected, actual, "IsFirstLetterUppercase: nagybetűvel kezdődő név esetén nem true");

            // 2. A név kis betűvel kezdődik
            NameValidationRules nameValidationFirstLetterLowercase = new NameValidationRules("péter");
            expected = false;
            actual = nameValidationFirstLetterLowercase.IsFirstLetterUppercase;
            Assert.AreEqual(expected, actual, "IsFirstLetterUppercase: kisbetűvel kezdődő név esetén nem false");

            // 3. A név többi része kisbetű és helyes név is egyben
            NameValidationRules nameValidationOtherLetterLowercase = new NameValidationRules("Péter");
            expected = true;
            actual = nameValidationFirstLetterLowercase.IsOtherLetterLowercase;
            Assert.AreEqual(expected, actual, "IsOtherLetterLowercase: a többi betű kisbetű, de nem true");

            // 3. A név többi részében van nagybetű
            NameValidationRules nameValidationOtherLetterUppercase = new NameValidationRules("PéteR");
            expected = false;
            actual = nameValidationOtherLetterUppercase.IsOtherLetterLowercase;
            Assert.AreEqual(expected, actual, "IsOtherLetterLowercase: a többi betű nem kisbetű, de nem false");

 
            NameValidationRules nvr = new NameValidationRules("Ágnes123@");
            expected = false;
            actual = nvr.IsOnlyLetters;
            Assert.AreEqual(expected, actual, "IsOnlyLetters:Nem betűt elfogad.");

        }
    }
}