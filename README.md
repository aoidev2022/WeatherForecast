# WeatherForecast

To create a webapi with net core 5
```terminal
dotnet new webapi -f net5.0
```

To build a docker image 
```terminal
docker build -t aoidev2022/weather-forecast:v1.0 .
```

To run a container based on an image
```terminal
docker run --rm -d -p 80:80/tcp --name forecast aoidev2022/weather-forecast:v1.0
```

To run seq service locally as a container https://hub.docker.com/r/datalust/seq/
```terminal
docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
```

To run a container and pass environment variable on it
```terminal
docker run --rm -d -p 5678:80/tcp -e SimpleProperty="_SimpleProperty" -e ConnectionStrings__Db="_ConnectionStrings__Db" --name forecast aoidev2022/weather-forecast:v1.0
```

To show the current docker account details and more
```terminal
docker info
```
---

To setup git user properties
```terminal
git config --local user.email "aoi.dev@hotmail.com"
git config --local user.name "adonis cruz villarraga"
```
