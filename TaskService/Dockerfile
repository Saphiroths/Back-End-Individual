#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Back-End-Individual-.csproj", "."]
RUN dotnet restore "./Back-End-Individual.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Back-End-Individual.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Back-End-Individual.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "b=Back-End-Individual.dll"]
