FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5229

ENV ASPNETCORE_URLS=http://+:5229

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["MiniBlog.Api/MiniBlog.Api.csproj", "MiniBlog.Api/"]
RUN dotnet restore "MiniBlog.Api/MiniBlog.Api.csproj"
COPY . .
WORKDIR "/src/MiniBlog.Api"
RUN dotnet build "MiniBlog.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "MiniBlog.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiniBlog.Api.dll"]
