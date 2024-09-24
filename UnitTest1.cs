namespace API_Test2
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void FindSubstring()
        {
            string subString = "";
            string mainString = "";
            Assert.That(mainString, Does.Contain(subString));
        }

        [Test]
        public void StrinsandRegularexpression()
        {
            string email = "";
            string patternEmail = @"(^[a-zA-z0-9._-]*)[@]([a-zA-Z0-9.-]*)(a-zA-Z)";
            Assert.That(email, Does.Match(patternEmail));
        }

        [Test]
        public void IsConditionTrue()
        {
            bool isTrue = 0 < 3;
            Assert.IsTrue(isTrue);
        }

        [Test]
        public void IsConditionFalse()
        {
            bool isTrue = 0 < 3;
            Assert.IsFalse(isTrue);
        }

        [Test]
        public void CompareCollection()
        {
            var collecton1 = new List<int> { 1, 2, 3 };
            var collecton2 = new List<int> { 3, 4, 5 };
            Assert.That(collecton1, Is.EqualTo(collecton2));
        }

        [Test]
        public void CollectionContainsElemetn()
        {
            var collecton = new List<int> { 1, 2, 3 };
            Assert.That(collecton, Does.Contain('2'));
        }

        [Test]
        public void CheckException()
        {
            Assert.Throws<ArgumentException>(
                delegate {throw new ArgumentException(); });
        }
    }
}