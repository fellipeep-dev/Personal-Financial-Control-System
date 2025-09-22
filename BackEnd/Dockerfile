# stage build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["Api/Api.csproj", "Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]

RUN dotnet restore "Api/Api.csproj" -r linux-musl-x64

COPY . .

RUN dotnet publish "Api/Api.csproj" --no-restore -c Release -o /app/publish /p:PublishSingleFile=false /p:PublishTrimmed=true -r linux-musl-x64

# stage runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS runtime
WORKDIR /app

RUN addgroup -S aspnetapp && adduser -S aspnetapp -G aspnetapp
USER aspnetapp

ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Api.dll"]