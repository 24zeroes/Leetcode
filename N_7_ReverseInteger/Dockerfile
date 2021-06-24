FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["N_7_ReverseInteger/N_7_ReverseInteger.csproj", "N_7_ReverseInteger/"]
RUN dotnet restore "N_7_ReverseInteger/N_7_ReverseInteger.csproj"
COPY . .
WORKDIR "/src/N_7_ReverseInteger"
RUN dotnet build "N_7_ReverseInteger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N_7_ReverseInteger.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N_7_ReverseInteger.dll"]
