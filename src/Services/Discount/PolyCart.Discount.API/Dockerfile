#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/Discount/PolyCart.Discount.API/PolyCart.Discount.API.csproj", "Services/Discount/PolyCart.Discount.API/"]
RUN dotnet restore "Services/Discount/PolyCart.Discount.API/PolyCart.Discount.API.csproj"
COPY . .
WORKDIR "/src/Services/Discount/PolyCart.Discount.API"
RUN dotnet build "PolyCart.Discount.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PolyCart.Discount.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PolyCart.Discount.API.dll"]