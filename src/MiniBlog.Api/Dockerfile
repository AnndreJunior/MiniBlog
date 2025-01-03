FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5137

ENV ASPNETCORE_URLS=http://+:5137

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/MiniBlog.Api/MiniBlog.Api.csproj", "src/MiniBlog.Api/"]
COPY ["src/MiniBlog.Application/MiniBlog.Application.csproj", "src/MiniBlog.Application/"]
COPY ["src/MiniBlog.Domain/MiniBlog.Domain.csproj", "src/MiniBlog.Domain/"]
COPY ["src/MiniBlog.Infra/MiniBlog.Infra.csproj", "src/MiniBlog.Infra/"]
COPY ["src/MiniBlog.Presentation/MiniBlog.Presentation.csproj", "src/MiniBlog.Presentation/"]
COPY ["src/MiniBlog.SharedKernel/MiniBlog.SharedKernel.csproj", "src/MiniBlog.SharedKernel/"]
RUN dotnet restore "src/MiniBlog.Api/MiniBlog.Api.csproj"
COPY . .
WORKDIR "/src/src/MiniBlog.Api"
RUN dotnet build "MiniBlog.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "MiniBlog.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiniBlog.Api.dll"]
