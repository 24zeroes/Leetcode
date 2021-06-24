FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["N_49_GroupAnagrams/N_49_GroupAnagrams.csproj", "N_49_GroupAnagrams/"]
RUN dotnet restore "N_49_GroupAnagrams/N_49_GroupAnagrams.csproj"
COPY . .
WORKDIR "/src/N_49_GroupAnagrams"
RUN dotnet build "N_49_GroupAnagrams.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N_49_GroupAnagrams.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N_49_GroupAnagrams.dll"]
