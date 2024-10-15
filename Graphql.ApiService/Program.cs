var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddQueryConventions()
    .ModifyOptions(options =>
    {
        options.DefaultBindingBehavior = BindingBehavior.Explicit;
    });

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
