#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Basket/PolyCart.Basket.API/PolyCart.Basket.API.csproj", "Services/Basket/PolyCart.Basket.API/"]
COPY ["BuildingBlocks/PolyCart.Common.Logging/PolyCart.Common.Logging.csproj", "BuildingBlocks/PolyCart.Common.Logging/"]
COPY ["BuildingBlocks/PolyCart.EventBus.Messages/PolyCart.EventBus.Messages.csproj", "BuildingBlocks/PolyCart.EventBus.Messages/"]
RUN dotnet restore "Services/Basket/PolyCart.Basket.API/PolyCart.Basket.API.csproj"
COPY . .
WORKDIR "/src/Services/Basket/PolyCart.Basket.API"
RUN dotnet build "PolyCart.Basket.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PolyCart.Basket.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PolyCart.Basket.API.dll"]