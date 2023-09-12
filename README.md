# PolyCart
PolyCart is a polyglot microservices e-commerce platform designed for scalability and resilience. Built on a diverse tech stack including ASP.NET Core, Redis, MongoDB, and PostgreSQL, it features an array of services such as Catalog, Basket, and Discount, optimized for RESTful and gRPC inter-service communication. The architecture incorporates industry best practices such as DDD, CQRS, and Clean Architecture, and utilizes RabbitMQ with MassTransit for event-driven asynchronous messaging. Resilience patterns with Polly, centralized logging via the ELK stack, and container orchestration through Docker Compose further enhance the system's robustness and manageability.

# Project Architecture
<img src="https://github.com/tyagishubham177/PolyCart/blob/main/img/projarch.png" alt="GitHub Logo" width="600" height="400">

# What's included in this repository

### Catalog Microservice
- **Stack**: ASP.NET Core Web API, MongoDB
- **Features**: RESTful CRUD ops, Repository Pattern, Swagger API docs

### Basket Microservice
- **Stack**: ASP.NET Core Web API, Redis
- **Features**: RESTful CRUD ops, Discount calculations via gRPC, MassTransit-RabbitMQ for event queues

### Discount Microservice
- **Stack**: ASP.NET Grpc, PostgreSQL, Dapper micro-ORM
- **Features**: High-performance gRPC inter-service comms, Protobuf message serialization

### Ordering Microservice
- **Stack**: DDD, CQRS, Clean Architecture, SqlServer, Entity Framework Core
- **Features**: MediatR, FluentValidation, AutoMapper, MassTransit-RabbitMQ consumer

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

# Prerequisites for project
You will **need** these :
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.Net7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

## Installing PolyCart

Follow these steps to set up your development environment. **Note: Make sure to start Docker Desktop before proceeding.**

1. **Clone the repository**
   
2. **Configure Docker Settings**:  
   - Once Docker for Windows is installed, navigate to `Settings > Advanced` from the Docker system tray icon.
   - Configure the minimum system requirements:
     - Memory: 4 GB
     - CPU: 2

3. **Run Docker Compose**:  
   Navigate to the root directory that includes `docker-compose.yml` files and run the following command:
> docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

- **Note**: If you encounter a connection timeout error on Docker for Mac, please turn off Docker's "Experimental Features".

4. **Wait for Microservices to Initialize**:  
Please allow some time for all microservices to be up and running. 

### Microservice Endpoints

| Service Name        | URL                                                         |
|---------------------|-------------------------------------------------------------|
| Catalog API         | `http://host.docker.internal:8000/swagger/index.html`        |
| Basket API          | `http://host.docker.internal:8001/swagger/index.html`        |
| Discount API        | `http://host.docker.internal:8002/swagger/index.html`        |
| Ordering API        | `http://host.docker.internal:8004/swagger/index.html`        |
| Shopping.Aggregator | `http://host.docker.internal:8005/swagger/index.html`        |
| API Gateway         | `http://host.docker.internal:8010/Catalog`                   |
| RabbitMQ Dashboard  | `http://host.docker.internal:15672` (Credentials: guest/guest)|
| Portainer           | `http://host.docker.internal:9000` (Credentials: admin/admin1234)|
| pgAdmin             | `http://host.docker.internal:5050` (Credentials: admin@aspnetrun.com/admin1234)|
| Elasticsearch       | `http://host.docker.internal:9200`                           |
| Kibana              | `http://host.docker.internal:5601`                           |
| Web Status          | `http://host.docker.internal:8007`                           |
| Web UI              | `http://host.docker.internal:8006`                           |



<img src="https://github.com/tyagishubham177/PolyCart/blob/main/img/polycart.jpeg" alt="GitHub Logo" width="300" height="300">
