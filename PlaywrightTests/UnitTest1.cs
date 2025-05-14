using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlaywrightTests
{
    public class PlainLoginTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;

        [OneTimeSetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new() { Headless = true });
        }

        [OneTimeTearDown]
        public async Task Teardown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }

        [Test]
        public async Task Login_Succeeds_With_Valid_Credentials()
        {
            var context = await _browser.NewContextAsync();
            var page = await context.NewPageAsync();

            await page.GotoAsync("http://localhost:5000/login");
            await Task.Delay(1000);
            // Fill in username and password using label-based selectors
            await page.GetByLabel("Username:").FillAsync("admin");
            await page.GetByLabel("Password:").FillAsync("password");
            await Task.Delay(1000);
            // Click button using ARIA role and visible name (case insensitive)
            await page.GetByRole(AriaRole.Button, new() { Name = "Log In" }).ClickAsync();

            await Task.Delay(1000);

            // Verify success message
            var successMessage = page.Locator("text=Login successful!");
            bool visible = await successMessage.IsVisibleAsync();
            Assert.That(visible, Is.True);
        }
    }
}
