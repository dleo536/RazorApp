BlazorApp – Blazor Login Demo with Playwright Testing

This project is a practice run for utilizing ARIA roles when writing automation testing for web pages that might see a lot of changes. I also wanted to try out Blazor and get some experience working with making quick web programs.

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
