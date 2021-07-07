FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExpressionInterpreter.App/ExpressionInterpreter.App.csproj", "ExpressionInterpreter.App/"]
RUN dotnet restore "ExpressionInterpreter.App/ExpressionInterpreter.App.csproj"
COPY . .
WORKDIR "/src/ExpressionInterpreter.App"
RUN dotnet build "ExpressionInterpreter.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExpressionInterpreter.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExpressionInterpreter.App.dll"]
