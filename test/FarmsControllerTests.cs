using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using FarmAdvisor.Models;
using System.Text;
using Newtonsoft.Json;

namespace FarmAdvisor.Test
{
    [TestClass]
    public class FarmsControllerTests
    {
        private HttpClient _httpClient;
        private static string accessToken = "";
        private static string phone = "0963654321";
        public FarmsControllerTests()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            _httpClient = webAppFactory.CreateDefaultClient();
        }
        [TestMethod]
        public async Task UsersSignUp()
        {
            UserSignup userSignup = new UserSignup()
            {
                phone = phone
            };
            HttpContent userSignupContentSignup = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignup), Encoding.UTF8, "application/json");

            var responseSignup = await _httpClient.PostAsync("/users/signup", userSignupContentSignup);
            var stringResultSignup = await responseSignup.Content.ReadAsStringAsync();
            UserSignupVerification userSignupVerification = JsonConvert.DeserializeObject<UserSignupVerification>(stringResultSignup)!;
            UserSignupVerificationInput userSignupVerificationInput = new UserSignupVerificationInput()
            {
                userSignVerificationToken = userSignupVerification.userSignVerificationToken,
                userSignVerificationCode = "123456",
                name = "Test Name",
                email = "test@gmail.com",
                passwordHash = "pwh"
            };
            HttpContent userSignupContentVerify = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignupVerificationInput), Encoding.UTF8, "application/json");

            var responseVerify = await _httpClient.PostAsync("/users/signup/verify", userSignupContentVerify);
            var stringResultVerify = await responseVerify.Content.ReadAsStringAsync();
            UserLogin userLogin = JsonConvert.DeserializeObject<UserLogin>(stringResultVerify)!;

            Assert.IsTrue(userLogin.accessToken is string);

            FarmsControllerTests.accessToken = userLogin.accessToken;
        }
    }
}