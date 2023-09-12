# PolyCart
PolyCart is a polyglot microservices e-commerce platform designed for scalability and resilience. Built on a diverse tech stack including ASP.NET Core, Redis, MongoDB, and PostgreSQL, it features an array of services such as Catalog, Basket, and Discount, optimized for RESTful and gRPC inter-service communication. The architecture incorporates industry best practices such as DDD, CQRS, and Clean Architecture, and utilizes RabbitMQ with MassTransit for event-driven asynchronous messaging. Resilience patterns with Polly, centralized logging via the ELK stack, and container orchestration through Docker Compose further enhance the system's robustness and manageability.

# Project Architecture
<img src="https://github.com/tyagishubham177/PolyCart/blob/main/img/projarch.png" alt="GitHub Logo" width="600" height="400">

# What's Including In This Repository

### Catalog Microservice
- **Stack**: ASP.NET Core Web API, MongoDB
- **Features**: RESTful CRUD ops, Repository Pattern, Swagger API docs
- **Containerization**: MongoDB

### Basket Microservice
- **Stack**: ASP.NET Core Web API, Redis
- **Features**: RESTful CRUD ops, Discount calculations via gRPC, MassTransit-RabbitMQ for event queues
- **Containerization**: Redis

### Discount Microservice
- **Stack**: ASP.NET Grpc, PostgreSQL, Dapper micro-ORM
- **Features**: High-performance gRPC inter-service comms, Protobuf message serialization
- **Containerization**: PostgreSQL

### Ordering Microservice
- **Stack**: DDD, CQRS, Clean Architecture, SqlServer, Entity Framework Core
- **Features**: MediatR, FluentValidation, AutoMapper, MassTransit-RabbitMQ consumer
- **Containerization**: SqlServer, Auto-migration on startup

### API Gateway (Ocelot)
- **Features**: Route aggregation, support for multiple API Gateway types

### WebUI (ShoppingApp)
- **Stack**: ASP.NET Core, Bootstrap 4, Razor
- **Features**: Ocelot API integration, HttpClientFactory, Polly resilience

### Cross-Cutting Concerns
- **Logging**: ELK Stack (Elasticsearch, Logstash, Kibana), SeriLog
- **Health Monitoring**: HealthChecks, Watchdog service

### Resilience
- **Policies**: IHttpClientFactory, Retry/Circuit Breaker via Polly

### Ancillary Containers
- **Management**: Portainer, pgAdmin
- **Infrastructure**: Docker Compose for container orchestration, Env variable overrides

# Run The Project
You will **need** these :
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.Net7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

## Steps
1. First item
   - Sub-item 1
   - Sub-item 2
2. Second item
   1. Sub-item 1
   2. Sub-item 2


<img src="https://github.com/tyagishubham177/PolyCart/blob/main/img/polycart.jpeg" alt="GitHub Logo" width="300" height="300">
