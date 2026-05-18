var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithDataVolume();

var itemsDb = postgres.AddDatabase("itemsdb");

builder.AddProject<Projects.worker>("worker")
    .WithReference(itemsDb)
    .WaitFor(itemsDb);

builder.AddProject<Projects.web_api>("web-api")
    .WithReference(itemsDb)
    .WaitFor(itemsDb);

builder.Build().Run();