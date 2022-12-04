#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["weatherforecast.api/weatherforecast.api.csproj", "weatherforecast.api/"]
RUN dotnet restore "weatherforecast.api/weatherforecast.api.csproj"
COPY . .
WORKDIR "/src/weatherforecast.api"
RUN dotnet build "weatherforecast.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "weatherforecast.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "weatherforecast.api.dll"]