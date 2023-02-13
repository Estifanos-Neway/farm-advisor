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
    public class UsersControllerTests
    {
        private HttpClient _httpClient;
        private static string userSignupVerificationToken = "";

        public UsersControllerTests()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            _httpClient = webAppFactory.CreateDefaultClient();
        }
        [TestMethod]
        public async Task UsersSignUp_InvalidPhone_ReturnsInvalid_Phone()
        {
            UserSignup userSignup = new UserSignup()
            {
                phone = "invalid"
            };

            HttpContent userSignupContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignup), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/users/signup", userSignupContent);
            var stringResult = await response.Content.ReadAsStringAsync();

            Assert.AreEqual("Invalid_Phone", stringResult);
        }

        [TestMethod]
        public async Task UsersSignUp_ValidPhone_ReturnsUserSignVerificationToken()
        {
            UserSignup userSignup = new UserSignup()
            {
                phone = "0987654321"
            };

            HttpContent userSignupContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignup), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/users/signup", userSignupContent);
            var stringResult = await response.Content.ReadAsStringAsync();
            UserSignupVerification userSignupVerification = JsonConvert.DeserializeObject<UserSignupVerification>(stringResult)!;
            Assert.IsTrue(userSignupVerification.userSignVerificationToken is string);
            this.userSignupVerificationToken = userSignupVerification.userSignVerificationToken;
        }

        [TestMethod]
        public async Task UsersSignUpVerify_InvalidToken_ReturnsInvalid_Token()
        {
            UserSignupVerificationInput userSignupVerificationInput = new UserSignupVerificationInput()
            {
                userSignVerificationToken = "invalid",
                userSignVerificationCode = "12345",
                name = "Test Name",
                email = "test@test.test",
                passwordHash = "pwh"
            };

            HttpContent userSignupContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignupVerificationInput), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/users/signup/verify", userSignupContent);
            var stringResult = await response.Content.ReadAsStringAsync();

            Assert.AreEqual("Invalid_Token", stringResult);
        }

        [TestMethod]
        public async Task UsersSignUpVerify_InvalidVerificationCode_ReturnsInvalid_Verification_Code()
        {
            UserSignupVerificationInput userSignupVerificationInput = new UserSignupVerificationInput()
            {
                userSignVerificationToken = this.userSignupVerificationToken,
                userSignVerificationCode = "invalid",
                name = "Test Name",
                email = "test@test.test",
                passwordHash = "pwh"
            };

            HttpContent userSignupContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignupVerificationInput), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/users/signup/verify", userSignupContent);
            var stringResult = await response.Content.ReadAsStringAsync();

            Assert.AreEqual("Invalid_Token", stringResult);
        }

        // [TestMethod]
        // public async Task UsersSignUpVerify_ValidUserSignupVerificationInput_ReturnsInvalid_Verification_Code()
        // {
        //     UserSignupVerificationInput userSignupVerificationInput = new UserSignupVerificationInput()
        //     {
        //         userSignVerificationToken = userSignupVerificationToken,
        //         userSignVerificationCode = "invalid",
        //         name = "Test Name",
        //         email = "test@test.test",
        //         passwordHash = "pwh"
        //     };

        //     HttpContent userSignupContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(userSignupVerificationInput), Encoding.UTF8, "application/json");

        //     var response = await _httpClient.PostAsync("/users/signup/verify", userSignupContent);
        //     var stringResult = await response.Content.ReadAsStringAsync();

        //     Assert.AreEqual("Invalid_Verification_Code", stringResult);
        // }
    }
}