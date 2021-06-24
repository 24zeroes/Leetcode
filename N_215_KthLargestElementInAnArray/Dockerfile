FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["N_215_KthLargestElementInAnArray/N_215_KthLargestElementInAnArray.csproj", "N_215_KthLargestElementInAnArray/"]
RUN dotnet restore "N_215_KthLargestElementInAnArray/N_215_KthLargestElementInAnArray.csproj"
COPY . .
WORKDIR "/src/N_215_KthLargestElementInAnArray"
RUN dotnet build "N_215_KthLargestElementInAnArray.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N_215_KthLargestElementInAnArray.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N_215_KthLargestElementInAnArray.dll"]
