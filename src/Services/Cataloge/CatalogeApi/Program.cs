var builder = WebApplication.CreateBuilder(args);

//Add Services to the containers
var app = builder.Build();

//configure the HTTP request pipeline


app.Run();
