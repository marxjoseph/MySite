using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MySite;

var builder = WebAssemblyHostBuilder.CreateDefault(args); // Creates an instance of WebAssemlyHostBuilder with a basic setup, allowing you to add more of a custom setup as well (args is the array of main method arguments)

// Root Components are directly rendered in the html document
builder.RootComponents.Add<App>("#app"); // Adds App.razor as a root component with an id of app
builder.RootComponents.Add<HeadOutlet>("head::after"); // Allows for PageTitle and HeadContent to render ("head::after" is making everything from HeadOutlet be appended to <head> in index.html")

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
