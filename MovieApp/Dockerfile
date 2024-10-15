FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MovieApp.csproj", "./"]
RUN dotnet restore "./MovieApp.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MovieApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieApp.dll"]
HEALTHCHECK CMD curl --fail http://localhost:80 || exit 1
