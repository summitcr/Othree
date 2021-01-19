#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Othree.API/Othree.API.csproj", "Othree.API/"]
RUN dotnet restore "Othree.API/Othree.API.csproj"
COPY . .
WORKDIR "/src/Othree.API"
RUN dotnet build "Othree.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Othree.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Othree.API.dll"]
