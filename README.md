BlazorApp – Blazor Login Demo with Playwright Testing

This project serves as a practical exercise in using ARIA roles for automation testing of web pages that are subject to frequent changes. It also provided an opportunity to explore Blazor, enabling hands-on experience in developing rapid web applications using C# and Razor components.

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
