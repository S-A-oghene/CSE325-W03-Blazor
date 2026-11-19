# W03 Blazor Assignment — Step-by-step Beginner Guide

## What you are building

The BYU–Idaho assignment asks you to complete the assigned Blazor learning modules and use the Blazing Pizza application from the final module as the starting point. Then make two changes: format all prices in your country's currency and put your full name and country in the footer. The submission is a public GitHub repository URL plus a screenshot of the locally running application.

This prepared project targets .NET 10 and includes the key Blazing Pizza concepts: Razor components, interactive UI, data passed through services, page routing, route parameters, navigation links, and a shared layout. It is a study-ready implementation, not proof that you have completed the Microsoft Learn activities; complete the required learning modules yourself as part of the assignment.

## Part 1 — Complete the assigned Microsoft Learn modules

Open the BYU–Idaho learning activity page:

https://byui-cse.github.io/cse325-ww-course/week03/prepare-blazor-app-build-03.html

It assigns these three modules:

1. **Introduction to Web Development with Blazor** — understand what Blazor is, how it runs, and when it is useful.
   https://learn.microsoft.com/en-us/training/modules/blazor-introduction/
2. **Interact with data in Blazor web apps** — learn to build components, obtain data, share state between components, and bind controls to variables.
   https://learn.microsoft.com/en-us/training/modules/interact-with-data-blazor-web-apps/
3. **Use pages, routing, and layouts to improve Blazor navigation** — learn `@page`, the router, `NavLink`, route parameters, and reusable layouts. The Blazing Pizza app completed in this final module is the assignment starting point.
   https://learn.microsoft.com/en-us/training/modules/use-pages-routing-layouts-control-blazor-navigation/

Sign in to Microsoft Learn with a free Microsoft account if you want completion progress recorded. Work through the units and module assessments. The BYU–Idaho page explicitly says to finish the last module before making the two assignment changes.

## Part 2 — Install your tools

1. Install the **.NET 10 SDK** from https://dotnet.microsoft.com/en-us/download/dotnet/10.0 . Download the SDK, not only the runtime.
2. Install Visual Studio Code from https://code.visualstudio.com/ .
3. In VS Code, open Extensions (the four-square icon), search for **C# Dev Kit** by Microsoft, and install it.
4. Install Git from https://git-scm.com/downloads if `git --version` does not work.
5. Open a terminal and run:

   ```bash
   dotnet --version
   git --version
   ```

   The .NET command should show a 10.0 SDK version. Git should show a version number.

## Part 3 — Open this project

1. Download `BlazingPizza-W03-Complete-Source.zip`.
2. Extract it to a folder you can find easily, such as Documents or Desktop.
3. Open Visual Studio Code.
4. Select **File → Open Folder**.
5. Select the extracted `BlazingPizza-W03` folder. It is important to open the folder containing `BlazingPizza.csproj`.
6. Select **Terminal → New Terminal**.
7. In the terminal run `dir` on Windows or `ls` on macOS/Linux. Confirm you can see `BlazingPizza.csproj`, `Program.cs`, `Components`, `Models`, `Services`, and `wwwroot`.

## Part 4 — Personalize your footer (required change 2)

1. In VS Code Explorer, expand `Components`.
2. Expand `Layout`.
3. Open `MainLayout.razor`.
4. Find this line:

   ```razor
   <span>Gemaakt door: <strong>YOUR FULL NAME</strong></span>
   ```

5. Replace only `YOUR FULL NAME` with your actual first and last name, for example `Alex Example` (use your real full name, not this example).
6. Leave the country as `Nederland (Netherlands)`.
7. Save with `Ctrl+S` (Windows/Linux) or `Command+S` (macOS).

Do not leave the placeholder in your submitted screenshot.

## Part 5 — Understand and verify the euro change (required change 1)

The country used for this version is the Netherlands, so the correct currency is the euro. Dutch formatting also uses a comma for decimals.

1. Open `Services/CurrencyFormatter.cs`.
2. Read the method `Euro(decimal amount)`. It uses `CultureInfo.GetCultureInfo("nl-NL")` and the .NET currency format `C`.
3. Open `Components/Pages/Home.razor`. Menu prices use `CurrencyFormatter.Euro(pizza.BasePrice)`.
4. Open `Components/Pages/Order.razor`. The extra-size price, extra cheese price, and running total use the same formatter.
5. Open `Components/Pages/OrderSummary.razor`. Line-item prices and the total use the same formatter.

The result should look like `€ 12,50`. Do not type a dollar sign or manually replace only the visible menu price. Use the shared formatter for every monetary value.

## Part 6 — Restore, build, and run the app

In the VS Code terminal (make sure it is in the folder containing `BlazingPizza.csproj`):

1. Restore dependencies:

   ```bash
   dotnet restore
   ```

2. Build the app:

   ```bash
   dotnet build
   ```

   Look for `Build succeeded.` If there are build errors, stop and fix them before continuing.

3. Run the app:

   ```bash
   dotnet run
   ```

4. Wait for the terminal to display the local listening URL. The included launch profile normally uses `https://localhost:7184` and `http://localhost:5184`. Use the URL actually printed in your terminal.
5. If a browser warning appears about the local HTTPS development certificate, try the HTTP localhost URL or run `dotnet dev-certs https --trust` and follow the operating-system prompt.
6. Keep the terminal open while using the application. To stop it, return to the terminal and press `Ctrl+C`.

## Part 7 — Test the Blazor features

### Menu and components

1. Open the home page at `/`.
2. Confirm the Blazing Pizza header appears.
3. Confirm that six pizza cards are displayed.
4. Confirm every menu price uses the euro symbol and Dutch decimal format.

### Page routing and navigation

1. Select **Kies pizza** on any pizza card.
2. Confirm the browser address changes to `/order/` followed by the pizza number.
3. Confirm the customize page opens for that pizza.
4. Select **Mijn bestelling** in the header to open `/order-summary`.
5. Use the back-to-menu link to return to `/`.

### Data binding and interactive state

1. On a pizza customization page, change the size.
2. Select or clear toppings and the extra-cheese checkbox.
3. Confirm the price updates when you choose a larger size or extra cheese.
4. Add the pizza to your order.
5. Confirm it appears on the order summary page.
6. Add another pizza, then remove one using the × button.
7. Confirm the total updates and all displayed prices remain in euros.
8. Complete the demonstration order if desired. The app clearly states that no real order is placed.

### Footer

Scroll to the very bottom of the menu page. Confirm the footer displays your actual full name and `Nederland (Netherlands)`.

## Part 8 — Create a new public GitHub repository

1. Sign in at https://github.com/ or create an account.
2. Select the **+** menu and then **New repository**.
3. Name it `CSE325-W03-Blazor` (or another clear name).
4. Add a description such as `CSE 325 W03 Blazor Blazing Pizza application`.
5. Set visibility to **Public**. The assignment explicitly requests a new public repository.
6. Do not initialize another README or `.gitignore`; these files are already in this project.
7. Select **Create repository**.
8. Copy the repository HTTPS URL shown by GitHub.

Back in the VS Code terminal, run these commands one at a time, replacing the example URL with your own URL:

```bash
git init
git add .
git status
git commit -m "Complete W03 Blazor assignment"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/CSE325-W03-Blazor.git
git push -u origin main
```

If Git asks you to identify yourself, configure your name and email using your own details:

```bash
git config --global user.name "Your Name"
git config --global user.email "you@example.com"
```

Then repeat the commit and push commands if needed. Authenticate to GitHub in the browser if prompted. Never put a password or access token in a source-code file.

Refresh your GitHub repository page. Confirm your project files are visible and that the repository is public. Copy the public repository URL; this is one Canvas submission item.

## Part 9 — Capture the required screenshot image

The Canvas submission asks for an image file showing the **locally running application**. A screenshot of code or a screenshot from this guide is not acceptable.

1. Make sure you replaced the name placeholder first.
2. Start the app with `dotnet run`.
3. Open the local home page (`/`) in your browser, not the pizza customization or order page.
4. Maximize the browser window.
5. Scroll to the top of the home page.
6. Adjust browser zoom down one or two steps (`Ctrl+-` on Windows/Linux or `Command+-` on macOS) if needed so the header, all pizza cards with euro prices, and the footer are visible together. Do not zoom so far out that the text is unreadable.
7. Check that the screenshot visibly contains all three rubric evidence items: (a) Blazing Pizza header, (b) pizza list and € prices, (c) footer containing your own full name and the Netherlands.
8. Capture the screen:
   - **Windows:** press `Win+Shift+S`, choose rectangular snip, drag around the browser content, then save the captured image as a PNG.
   - **macOS:** press `Shift+Command+4`, drag around the browser content, then find the PNG on your Desktop.
   - **Linux:** use your desktop screenshot utility or the `PrtSc` key, then save the image as PNG.
9. Use a clear filename such as `W03-Blazing-Pizza-Screenshot.png`.
10. Open the saved PNG to verify it is readable and is not cropped before uploading.

## Part 10 — Submit in Canvas

The assignment instructions ask for two items:

1. Your **public GitHub repository URL**.
2. The **PNG screenshot image file** captured from your locally running app.

Upload the screenshot file in the Canvas file-upload area and include the repository URL in the appropriate submission field or assignment comments, following the Canvas interface. Re-open the submission details after submitting to make sure the image is attached and the repository URL is present.

## Final W03 checklist

- [ ] Completed the three assigned Microsoft Learn modules.
- [ ] Finished the final module's Blazing Pizza app.
- [ ] The application runs locally without build errors.
- [ ] Every displayed pizza/order price uses Dutch euro formatting.
- [ ] Footer contains my real full name.
- [ ] Footer contains the country Netherlands.
- [ ] Header, pizza list, euro prices, and footer are visible in one screenshot.
- [ ] Screenshot is a real PNG captured from my locally running application.
- [ ] Application is pushed to a new public GitHub repository.
- [ ] I copied and checked the public repository URL.
- [ ] I submitted the repository URL and screenshot image in Canvas.

## Troubleshooting

**`dotnet` is not recognized:** install the .NET 10 SDK, close and reopen the terminal, then run `dotnet --version` again.

**`dotnet restore` fails:** check your internet connection and confirm the terminal is in the folder that contains `BlazingPizza.csproj`.

**Build fails:** read the first actual `error` in the terminal, not just the final summary. Confirm you extracted the whole ZIP and did not omit files.

**Browser says the site cannot be reached:** confirm `dotnet run` is still running and use the exact localhost address printed in the terminal.

**HTTPS certificate warning:** use the HTTP localhost address or trust the .NET development certificate with `dotnet dev-certs https --trust`.

**Euro values appear as dollars:** check that the visible price uses `CurrencyFormatter.Euro(...)`, and that `CurrencyFormatter.cs` uses `nl-NL`.

**Footer still says YOUR FULL NAME:** edit `Components/Layout/MainLayout.razor`, save, and refresh the browser.

**Git push is rejected:** make sure the remote URL is correct and the GitHub repository was created empty (without an auto-created README). Run `git remote -v` to inspect the remote URL.
