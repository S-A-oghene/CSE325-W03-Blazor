# W03 Assignment — Blazing Pizza (Blazor)

A beginner-friendly Blazor application for the BYU–Idaho CSE 325 W03 assignment. It includes a pizza menu, interactive pizza customization, an order summary, routed pages, a shared layout, and the two assignment-specific changes:

**Important source note:** this ZIP is a .NET 10 practice implementation of the Blazing Pizza concepts, not a byte-for-byte copy of the Microsoft Learn sample repository. The BYU–Idaho instructions say to use the Blazing Pizza app completed in the final module as your starting point. If your instructor expects the exact module project, complete the module project and apply the two changes in `PATCH-FOR-MICROSOFT-SAMPLE.md` to that project. The official Microsoft sample repository is https://github.com/MicrosoftDocs/mslearn-blazor-navigation.

1. **Dutch euro prices:** all displayed prices go through `CurrencyFormatter.Euro`, which uses `nl-NL` formatting.
2. **Personalized footer:** the footer displays the country as `Nederland (Netherlands)` and has a `YOUR FULL NAME` placeholder that must be replaced before submission.

## Requirements

- .NET 10 SDK
- Visual Studio Code (or another .NET editor)
- C# Dev Kit extension for Visual Studio Code (recommended)
- Git and a GitHub account for the repository submission

## Run locally

1. Extract the ZIP.
2. Open the extracted `BlazingPizza-W03` folder in Visual Studio Code. Open the folder that contains `BlazingPizza.csproj`.
3. Open **Terminal → New Terminal**.
4. Check the SDK: `dotnet --version` (it should report a 10.0 SDK).
5. Restore packages: `dotnet restore`.
6. Build: `dotnet build`.
7. Run: `dotnet run`.
8. Open the HTTPS or HTTP localhost URL printed in the terminal. The launch profile uses `https://localhost:7184` and `http://localhost:5184`.

Press `Ctrl+C` in the terminal to stop the app.

## IMPORTANT — personalize the footer

Open:

`Components/Layout/MainLayout.razor`

Find:

```razor
<span>Gemaakt door: <strong>YOUR FULL NAME</strong></span>
```

Replace `YOUR FULL NAME` with your real full name. Save the file and refresh the browser. Do not submit the placeholder.

The country is already shown as `Nederland (Netherlands)`.

## Currency implementation

Open `Services/CurrencyFormatter.cs`. The helper formats decimal prices with `CultureInfo.GetCultureInfo("nl-NL")`. Every visible pizza/order price uses `CurrencyFormatter.Euro(...)`, so the UI uses Dutch euro formatting (for example, `€ 12,50`) in the menu, customization page, and order summary.

If you add another price display, use `CurrencyFormatter.Euro(amount)` rather than outputting the raw decimal value.

## Test the app

- Open `/` and confirm all pizza menu prices display with `€` and Dutch decimal formatting.
- Select **Kies pizza** on a pizza card.
- Change the pizza size and/or toppings. Confirm the total remains in euros.
- Select **Voeg toe aan bestelling**.
- On **Mijn bestelling**, confirm each line item and the total are shown in euros.
- Remove an item and confirm it disappears.
- Test **Bestelling afronden**. This tutorial app displays a demonstration confirmation and does not place a real order.
- Check the footer: it must show your full name and Netherlands.

## Capture the required Canvas screenshot

The assignment asks for a screenshot of the **locally running application** showing all of the following at once:

- the application header / Blazing Pizza brand;
- the pizza list with prices in euros;
- the footer with your full name and country.

For the screenshot, run the app locally, open the menu page (`/`), maximize the browser, and zoom out slightly (for example, `Ctrl+-` once or twice) until the header, the list of pizzas, and the entire footer fit on screen. Make sure the name placeholder has been replaced. Capture the screen using your operating system's screenshot feature and save a PNG file. Do not upload a screenshot of the source code, this README, or a static mock-up.

## GitHub submission

Create a **new public** GitHub repository, for example `CSE325-W03-Blazor`.

From this project folder run:

```bash
git init
git add .
git commit -m "Complete W03 Blazor Blazing Pizza assignment"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/CSE325-W03-Blazor.git
git push -u origin main
```

Replace `YOUR-USERNAME` and the repository name with your actual GitHub details. Refresh GitHub and verify that the project files appear. Submit the public repository URL and the screenshot image file in Canvas.

## Course materials

- BYU–Idaho W03 assignment: https://byui-cse.github.io/cse325-ww-course/week03/assignment-03.html
- BYU–Idaho W03 learning activities: https://byui-cse.github.io/cse325-ww-course/week03/prepare-blazor-app-build-03.html
- Microsoft: Introduction to Web Development with Blazor: https://learn.microsoft.com/en-us/training/modules/blazor-introduction/
- Microsoft: Interact with data in Blazor web apps: https://learn.microsoft.com/en-us/training/modules/interact-with-data-blazor-web-apps/
- Microsoft: Use pages, routing, and layouts to improve Blazor navigation: https://learn.microsoft.com/en-us/training/modules/use-pages-routing-layouts-control-blazor-navigation/
- Microsoft navigation sample repository: https://github.com/MicrosoftDocs/mslearn-blazor-navigation

This is a learning/demo application. It does not connect to a real payment processor or place real food orders.
