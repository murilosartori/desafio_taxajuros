#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 51752

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ServiceTaxaDeJuros/ServiceTaxaDeJuros.csproj", "ServiceTaxaDeJuros/"]
COPY ["ApplicationTaxaDeJuros/ApplicationTaxaDeJuros.csproj", "ApplicationTaxaDeJuros/"]
COPY ["RepositoryTaxaDeJuros/RepositoryTaxaDeJuros.csproj", "RepositoryTaxaDeJuros/"]
COPY ["DomainTaxaDeJuros/DomainTaxaDeJuros.csproj", "DomainTaxaDeJuros/"]
RUN dotnet restore "ServiceTaxaDeJuros/ServiceTaxaDeJuros.csproj"
COPY . .
WORKDIR "/src/ServiceTaxaDeJuros"
RUN dotnet build "ServiceTaxaDeJuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceTaxaDeJuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServiceTaxaDeJuros.dll"]