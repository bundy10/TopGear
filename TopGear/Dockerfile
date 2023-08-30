FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TopGear/TopGear.csproj", "TopGear/"]
RUN dotnet restore "TopGear/TopGear.csproj"
COPY . .
WORKDIR "/src/TopGear"
RUN dotnet build "TopGear.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TopGear.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TopGear.dll"]
