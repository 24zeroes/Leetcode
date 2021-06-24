FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LongestRepeatingCharacterReplacement424/LongestRepeatingCharacterReplacement424.csproj", "LongestRepeatingCharacterReplacement424/"]
RUN dotnet restore "LongestRepeatingCharacterReplacement424/LongestRepeatingCharacterReplacement424.csproj"
COPY . .
WORKDIR "/src/LongestRepeatingCharacterReplacement424"
RUN dotnet build "LongestRepeatingCharacterReplacement424.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LongestRepeatingCharacterReplacement424.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LongestRepeatingCharacterReplacement424.dll"]
