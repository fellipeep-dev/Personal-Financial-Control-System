# stage build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["BackEnd.sln", "."]
COPY ["Api/Api.csproj", "Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]

RUN dotnet restore "BackEnd.sln" --runtime linux-x64

COPY . .

RUN dotnet publish "Api/Api.csproj" --no-restore -c Release -o /app/publish /p:PublishSingleFile=false /p:PublishTrimmed=true

# stage runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

RUN groupadd -r aspnetapp && useradd -r -g aspnetapp aspnetapp
USER aspnetapp

ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Api.dll"]