using NUnit.Framework;

namespace BscScanner.Extensions.Convert.Tests {
    public class BscConvertTests {

        [Test]
        public void RunGweiToBnbConversion() {
            const long gwei = 15700000000000000;
            var bnb = BscConvert.GweiToBnb(gwei);
            
            Assert.AreEqual(0.0157f, bnb);
        }

        [Test]
        public void RunBnbToGweiConversion() {
            const double bnb = 0.0157;
            var gwei = BscConvert.BnbToGwei(bnb);

            Assert.AreEqual(15700000000000000, gwei);
        }
    }
}