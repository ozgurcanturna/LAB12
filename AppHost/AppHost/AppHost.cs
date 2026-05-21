var builder = DistributedApplication.CreateBuilder(args);

var rabbitmq = builder.AddRabbitMQ("rabbitmq");
    

    //commnet in main branch.
builder.Build().Run();
