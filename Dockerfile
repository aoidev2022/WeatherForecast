FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development
ENV SimpleProperty='SimpleProperty from dockerfile'
ENV ConnectionStrings__Db='ConnectionStrings__Db from dockerfile'
ENV Inventory__NestedProperty='Inventory__NestedProperty from dockerfile'

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["WeatherForecast.csproj", "./"]
RUN dotnet restore "WeatherForecast.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WeatherForecast.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "WeatherForecast.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherForecast.dll"]
