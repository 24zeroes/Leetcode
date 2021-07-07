FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["N_9_PalindromeNumber/N_9_PalindromeNumber.csproj", "N_9_PalindromeNumber/"]
RUN dotnet restore "N_9_PalindromeNumber/N_9_PalindromeNumber.csproj"
COPY . .
WORKDIR "/src/N_9_PalindromeNumber"
RUN dotnet build "N_9_PalindromeNumber.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N_9_PalindromeNumber.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N_9_PalindromeNumber.dll"]
