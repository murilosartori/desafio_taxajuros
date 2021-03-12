#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 59030

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ServiceCalculaJuros/ServiceCalculaJuros.csproj", "ServiceCalculaJuros/"]
COPY ["ApplicationCalculaJuros/ApplicationCalculaJuros.csproj", "ApplicationCalculaJuros/"]
COPY ["RepositoryCalculaJuros/RepositoryCalculaJuros.csproj", "RepositoryCalculaJuros/"]
COPY ["DomainCalculaJuros/DomainCalculaJuros.csproj", "DomainCalculaJuros/"]
RUN dotnet restore "ServiceCalculaJuros/ServiceCalculaJuros.csproj"
COPY . .
WORKDIR "/src/ServiceCalculaJuros"
RUN dotnet build "ServiceCalculaJuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceCalculaJuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServiceCalculaJuros.dll"]