using Syncfusion.Blazor;
using SmardenV3.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<IUserService, UserService>();
builder.Services.AddHttpClient<IPlantService, PlantService>();
builder.Services.AddHttpClient<IGardenService, GardenService>();
builder.Services.AddHttpClient<IKanbanService, KanbanService>();
builder.Services.AddHttpClient<IEventService, EventService>();
builder.Services.AddSyncfusionBlazor();
builder.WebHost.UseUrls("https://*:7103");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
