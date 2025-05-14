BlazorApp – Blazor Login Demo with Playwright Testing

- This project serves as a exercise to get comforable with Blazor as well as
- using ARIA roles for altenative element selection in automation testing.

- Possible use case:
  Developing automation testing for web pages that are subject to frequent changes. Blazor was useful for quickly putting together a web app to test the automation.

Features

- Utilize Blazor to quickly create a testable UI
- `@bind` inputs and `@onclick` button for login flow
- Displays result message on success or failure
- Playwright test using:
  - `page.GetByRole(AriaRole.Button, new() { Name = "Log In" })`
  - ARIA role selectors for resilient test logic even if HTML changes

---Getting Started

====Run the Blazor App Locally

```bash
cd BlazorApp1
dotnet run
```

====Run the test

```bash
dotnet test
```
