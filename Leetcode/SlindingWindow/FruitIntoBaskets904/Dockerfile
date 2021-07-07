FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FruitIntoBaskets904/FruitIntoBaskets904.csproj", "FruitIntoBaskets904/"]
RUN dotnet restore "FruitIntoBaskets904/FruitIntoBaskets904.csproj"
COPY . .
WORKDIR "/src/FruitIntoBaskets904"
RUN dotnet build "FruitIntoBaskets904.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FruitIntoBaskets904.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FruitIntoBaskets904.dll"]
