#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Ordering/PolyCart.Ordering.API/PolyCart.Ordering.API.csproj", "Services/Ordering/PolyCart.Ordering.API/"]
COPY ["BuildingBlocks/PolyCart.EventBus.Messages/PolyCart.EventBus.Messages.csproj", "BuildingBlocks/PolyCart.EventBus.Messages/"]
COPY ["Services/Ordering/PolyCart.Ordering.Application/PolyCart.Ordering.Application.csproj", "Services/Ordering/PolyCart.Ordering.Application/"]
COPY ["Services/Ordering/PolyCart.Ordering.Domain/PolyCart.Ordering.Domain.csproj", "Services/Ordering/PolyCart.Ordering.Domain/"]
COPY ["Services/Ordering/PolyCart.Ordering.Infrastructure/PolyCart.Ordering.Infrastructure.csproj", "Services/Ordering/PolyCart.Ordering.Infrastructure/"]
RUN dotnet restore "Services/Ordering/PolyCart.Ordering.API/PolyCart.Ordering.API.csproj"
COPY . .
WORKDIR "/src/Services/Ordering/PolyCart.Ordering.API"
RUN dotnet build "PolyCart.Ordering.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PolyCart.Ordering.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PolyCart.Ordering.API.dll"]