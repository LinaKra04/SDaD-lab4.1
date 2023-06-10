using NUnit.Framework;

namespace PaymentTests
{
    public class Payment_Testing
    {
        [Test]
        public void RemainderEqual()
        {
            Payment ob = new Payment(" ", " ", 100, 30);

            ob.SetRemainder(100, 30, 0);

            Assert.AreEqual(70, ob.RemainderPayment);
        }

        [Test]
        public void BiggerPayment()
        {
            Payment ob2 = new Payment(" ", " ", 10, 50);
            ob2.SetRemainder(10, 50, 0);

            ob2.Paid_More(false);

            Assert.AreEqual(true, ob2.PaidMore);
        }
    }
}