

var builder = WebApplication.CreateBuilder(args);



// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowIonic",
        policy =>
        {
            policy.WithOrigins("http://localhost:8100") // Allow Ionic app to access the API
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});




// Add services to the container.
builder.Services.AddControllers();   // Add controllers

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors("AllowIonic");  // Enable the CORS policy

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


// Map controllers
app.UseRouting();  // Enable routing

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();  // Map your API routes to controllers
});

app.MapControllers();

app.Run();
