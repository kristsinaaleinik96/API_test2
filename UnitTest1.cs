using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace API_Test2
{
    [TestFixture]
    public class Tests
    {
        private readonly string url = "https://gorest.co.in/public-api/users";

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
            List<UserAtributes> expectedUsers = new List<UserAtributes>()
            {
                new UserAtributes { id = 7450529, name = "Bhagwanti Ahuja", email = "ahuja_bhagwanti@toy-grimes.test", gender ="male", status ="active"}
               // new UserAtributes { id = 4, name = "Maria Ivanova", email = "maria_bhagwanti@toy-grimes.test", gender ="female", status ="active"}
            };
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            APIResponse? apiResponse = JsonConvert.DeserializeObject<APIResponse>(response);

            Assert.IsNotNull(apiResponse);
            Assert.That(apiResponse.data, Is.EqualTo(expectedUsers));
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