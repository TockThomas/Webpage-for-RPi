﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore
COPY . ./
WORKDIR "/src/."
RUN dotnet build -c Release -o /app

FROM build as publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app/ .
ENTRYPOINT ["dotnet", "Webpage for RPi.dll"]
