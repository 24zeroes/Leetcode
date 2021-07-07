FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ShortestSubarrayWithSumAtLeastK862/ShortestSubarrayWithSumAtLeastK862.csproj", "ShortestSubarrayWithSumAtLeastK862/"]
RUN dotnet restore "ShortestSubarrayWithSumAtLeastK862/ShortestSubarrayWithSumAtLeastK862.csproj"
COPY . .
WORKDIR "/src/ShortestSubarrayWithSumAtLeastK862"
RUN dotnet build "ShortestSubarrayWithSumAtLeastK862.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShortestSubarrayWithSumAtLeastK862.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShortestSubarrayWithSumAtLeastK862.dll"]
