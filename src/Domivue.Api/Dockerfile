FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5122
EXPOSE 7148

ENV ASPNETCORE_URLS=https://+:7148;http://+:5122

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
# COPY Domivue.Api.csproj ./
COPY . .
RUN dotnet restore Domivue.Api.csproj

RUN dotnet build Domivue.Api.csproj -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish Domivue.Api.csproj -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Domivue.Api.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Domivue.Api.dll
