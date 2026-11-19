# Apply the two W03 changes to the exact Microsoft Learn Blazing Pizza project

**Use this file when you have already completed the third BYU–Idaho/Microsoft Learn module and want to make the two required changes directly in that tutorial project.** The course assignment says that the Blazing Pizza app from the final module is the starting point. The downloadable project in this ZIP is a .NET 10 practice implementation of the same Blazing Pizza concepts; it is not a byte-for-byte copy of Microsoft's module repository.

Official sample repository: https://github.com/MicrosoftDocs/mslearn-blazor-navigation

## Change 1 — Display euros using Dutch formatting

The country for this walkthrough is the Netherlands. Use the culture code `nl-NL`.

### Option A (recommended): explicitly format every price

In every Razor component where a monetary value is shown, format that value with the Dutch culture. For example, where a component currently displays a pizza price, change the expression to:

```razor
@pizza.Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"))
```

Use the correct variable/property name from the component you are editing. Apply the same pattern to the menu price, customized-pizza price, order-line price, subtotal, and order total wherever they are displayed. Do not change non-price numbers such as pizza IDs or quantities into currency.

### Option B: set the application culture globally

If the tutorial sample uses `ToString("C")` for each price, you can also set the default server culture in `Program.cs`. Add this `using` at the top:

```csharp
using System.Globalization;
```

Immediately after the line that creates the builder (`var builder = WebApplication.CreateBuilder(args);`), add:

```csharp
var dutchCulture = CultureInfo.GetCultureInfo("nl-NL");
CultureInfo.DefaultThreadCurrentCulture = dutchCulture;
CultureInfo.DefaultThreadCurrentUICulture = dutchCulture;
```

This makes standard culture-aware currency formatting use the Netherlands locale. After making this change, verify the visible price values in the browser. If any component outputs a raw decimal instead of using currency formatting, change that component to an explicit `ToString("C", CultureInfo.GetCultureInfo("nl-NL"))` expression as shown in Option A.

**Verification:** prices should display a euro symbol (`€`) and Dutch decimal punctuation (for example, `€ 12,50`). Search the whole project (`Ctrl+Shift+F` / `Command+Shift+F`) for `.Price`, `Total`, `Subtotal`, `ToString("C")`, and other money-related properties to find every displayed price.

## Change 2 — Put your full name and country in the footer

1. Open `Shared/MainLayout.razor` in the older Blazor Server sample. (If your module output has a different folder arrangement, locate the component named `MainLayout.razor`.)
2. Find the outer layout markup and locate the bottom of the layout, after the main page content (`@Body`).
3. Add a footer before the final closing tag of the outer layout container:

```razor
<footer class="student-footer">
    <p>Created by: <strong>YOUR FULL NAME</strong></p>
    <p>Country: <strong>Netherlands</strong></p>
</footer>
```

4. Replace `YOUR FULL NAME` with your real first and last name. Do not leave the placeholder.
5. Save the file.

Add this CSS to the application's main stylesheet if you want the footer to be clearly visible:

```css
.student-footer {
    margin-top: 2rem;
    padding: 1.5rem;
    text-align: center;
    color: #fff;
    background: #292821;
}

.student-footer p {
    margin: 0.35rem 0;
}
```

## Run and verify

Run the application from the folder containing its `.csproj` file:

```bash
dotnet restore
dotnet build
dotnet run
```

Open the local URL printed by the terminal. On the menu page verify that the header, every pizza card and price, and the footer appear. Confirm the footer shows your actual full name and `Netherlands`.

If the page is long, maximize the browser and zoom out just enough for the header, menu, euro prices, and footer to fit together while remaining readable. Capture a real PNG screenshot of the running browser window. The screenshot—not a mock-up—must be the image uploaded to Canvas.
