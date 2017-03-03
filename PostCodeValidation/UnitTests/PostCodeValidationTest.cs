using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PostCodeValidation;

namespace UnitTests
{
    [TestFixture]
    public class PostCodeValidationTest
    {
        string[] postCodes = {      "$%± ()()",
                                    "XX XXX",
                                    "A1 9A",
                                    "LS44PL",
                                    "Q1A 9AA",
                                    "V1A 9AA",
                                    "X1A 9BB",
                                    "LI10 3QP",
                                    "LJ10 3QP",
                                    "LZ10 3QP",
                                    "A9Q 9AA",
                                    "AA9C 9AA",
                                    "FY10 4PL",
                                    "SO1 4QQ",
                                    "EC1A 1BB",
                                    "W1A 0AX",
                                    "M1 1AE",
                                    "B33 8TH",
                                    "CR2 6XH",
                                    "DN55 1PT",
                                    "GIR 0AA",
                                    "SO10 9AA",
                                    "FY9 9AA",
                                    "WC1A 9AA"};

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheFirstIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[0];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheSecondIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[1];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheThirdIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[2];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheFourthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[3];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheFifthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[4];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheSixthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[5];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheSeventhIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[6];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheEightIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[7];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheNinthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[8];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTenthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[9];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheEleventhIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[10];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwelfthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[11];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheThirteenthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[12];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheFourtheenthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[13];
            int expected = 1;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheFifteenIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[14];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheSixteenIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[15];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheSeventeenIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[16];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheEighteenIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[17];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheNineteenIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[18];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwentiethIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[19];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwetyfirstIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[20];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwentysecondIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[21];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwentythirdIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[22];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PostCodeValidator_ReturnsIntegerOfValueOne_WhenTheTwentyfourthIterationOfPostCodeListIsInputed()
        {
            // Arrage
            var validator = new PostCodeValidation.PostCodeValidation();
            string postCode = postCodes[23];
            int expected = 0;

            // Act
            int actual = validator.PostCodeValidator(postCode);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
