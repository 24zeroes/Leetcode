FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MinimumSizeSubarraySum209/MinimumSizeSubarraySum209.csproj", "MinimumSizeSubarraySum209/"]
RUN dotnet restore "MinimumSizeSubarraySum209/MinimumSizeSubarraySum209.csproj"
COPY . .
WORKDIR "/src/MinimumSizeSubarraySum209"
RUN dotnet build "MinimumSizeSubarraySum209.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimumSizeSubarraySum209.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimumSizeSubarraySum209.dll"]
