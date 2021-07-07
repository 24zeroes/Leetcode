FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExpressionInterpreter.Test/ExpressionInterpreter.Test.csproj", "ExpressionInterpreter.Test/"]
RUN dotnet restore "ExpressionInterpreter.Test/ExpressionInterpreter.Test.csproj"
COPY . .
WORKDIR "/src/ExpressionInterpreter.Test"
RUN dotnet build "ExpressionInterpreter.Test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExpressionInterpreter.Test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExpressionInterpreter.Test.dll"]
