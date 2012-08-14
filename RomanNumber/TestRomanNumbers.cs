using NUnit.Framework;

namespace SuperMarket
{
    [TestFixture]
    public class TestRomanNumbers:RomanNumber
    {

        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        public void Given_Yekan_when_GetRomanNumber_Then_Return_RomanNumber(int giveNumber, string expectedRomanNumber)
        {


            var number =GetRomanYekan(giveNumber);
            Assert.That(number, Is.EqualTo(expectedRomanNumber));
        }

        [TestCase(1, "X")]
        [TestCase(2, "XX")]
        [TestCase(3, "XXX")]
        [TestCase(4, "XL")]
        [TestCase(5, "L")]
        [TestCase(6, "LX")]
        [TestCase(7, "LXX")]
        [TestCase(8, "LXXX")]
        [TestCase(9, "XC")]
        [Test]
        public void Given_Dahgan_when_GetRomanNumber_Then_Return_RomanNumber(int givennumber, string expectedRomanNumber)
        {
            string number =GetRomanDahgan(givennumber);
            Assert.That(number, Is.EqualTo(expectedRomanNumber));
        }

        [TestCase(1, "C")]
        [TestCase(2, "CC")]
        [TestCase(3, "CCC")]
        [TestCase(4, "CD")]
        [TestCase(5, "D")]
        [TestCase(6, "DC")]
        [TestCase(7, "DCC")]
        [TestCase(8, "DCCC")]
        [TestCase(9, "CM")]
        [Test]
        public void Given_sadgan_when_GetRomanNumber_Then_Return_RomanNumber(int givennumber, string expectedRomanNumber)
        {
            string number = GetRomanSadgan(givennumber);
            Assert.That(number, Is.EqualTo(expectedRomanNumber));
        }




        [TestCase(11, "XI")]
        [TestCase(24, "XXIV")]
        [TestCase(37, "XXXVII")]
        [TestCase(43, "XLIII")]
        [TestCase(50, "L")]
        [TestCase(63, "LXIII")]
        [TestCase(72, "LXXII")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(99, "XCIX")]
        [TestCase(311, "CCCXI")]
        [TestCase(224, "CCXXIV")]
        [TestCase(537, "DXXXVII")]
        [TestCase(743, "DCCXLIII")]
        [TestCase(150, "CL")]
        [TestCase(863, "DCCCLXIII")]
        [TestCase(972, "CMLXXII")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(299, "CCXCIX")]
        [Test]
        public void Given_Number_when_GetRomanNumber_Return_RomanNumebr(int givenNumebr, string expectedNumber)
        {
           RomanNumber romanNumber=new RomanNumber();   
            string roman = romanNumber.GetRomanNumber(givenNumebr);
            Assert.That(roman, Is.EqualTo(expectedNumber));
        }


    }

}
