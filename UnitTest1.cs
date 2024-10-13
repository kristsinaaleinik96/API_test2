using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace API_Test2
{
    [TestFixture]
    public class Tests
    {
        private readonly string url = "https://gorest.co.in/public/v2/users/6941858";

        [Test]
        public void FindSubstring()
        {
            string subString = "";
            string mainString = "";
            Assert.That(mainString, Does.Contain(subString));
        }

        [Test]
        public void StringandRegularexpression()
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

        public async Task CompareCollection()
        {
            UserAtributes expectedUsers = new UserAtributes { Id = 6941858, Name = "Bhagwanti Ahuja", Email = "dsfsdfsdf", Gender = "male", Status = "active" };
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            UserAtributes? apiResponse = JsonConvert.DeserializeObject<UserAtributes>(response);
            Assert.IsNotNull(apiResponse);
            Assert.That(apiResponse.Email, Is.EqualTo(expectedUsers.Email));
            Assert.That(apiResponse.Name, Is.EqualTo(expectedUsers.Name));
            Assert.That(apiResponse.Gender, Is.EqualTo(expectedUsers.Gender));
            Assert.That(apiResponse.Id, Is.EqualTo(expectedUsers.Id));
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