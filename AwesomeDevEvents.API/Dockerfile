#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

ENV SA_PASSWORD="123456"
ENV ACCEPT_EULA=Y

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AwesomeDevEvents.API/AwesomeDevEvents.API.csproj", "AwesomeDevEvents.API/"]
COPY ["AwesomeDevEvents.API/", "AwesomeDevEvents.API/"]
RUN dotnet restore "AwesomeDevEvents.API/AwesomeDevEvents.API.csproj"
COPY . .
WORKDIR "/src/AwesomeDevEvents.API"
RUN dotnet build "AwesomeDevEvents.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AwesomeDevEvents.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AwesomeDevEvents.API.dll"]

