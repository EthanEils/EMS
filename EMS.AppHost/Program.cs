IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.EMS_Web>("ems-web");

await builder.Build().RunAsync();
