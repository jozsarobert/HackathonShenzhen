FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Tracking.Api/Tracking.Api.csproj", "Tracking.Api/"]
RUN dotnet restore "./Tracking.Api/./Tracking.Api.csproj"
COPY . .
WORKDIR "/src/Tracking.Api"
RUN dotnet build "./Tracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Tracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Replace the placeholder in appsettings.json and start the API
CMD sed -i "s|\"BasePath\": \"__BASE_PATH__\"|\"BasePath\": \"$API2_BASE_URL\"|g" /app/appsettings.json && dotnet Tracking.Api.dll
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8280

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Tracking.Api/Tracking.Api.csproj", "Tracking.Api/"]
RUN dotnet restore "./Tracking.Api/./Tracking.Api.csproj"
COPY . .
WORKDIR "/src/Tracking.Api"
RUN dotnet build "./Tracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Tracking.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Replace the placeholder in appsettings.json and start the API
CMD sed -i "s|\"BasePath\": \"__BASE_PATH__\"|\"BasePath\": \"$REELABLES_BASE_URL\"|g" /app/appsettings.json && dotnet Tracking.Api.dll
