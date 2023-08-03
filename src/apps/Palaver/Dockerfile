FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/apps/Palaver/Palaver.csproj", "src/apps/Palaver/"]
RUN dotnet restore "src/apps/Palaver/Palaver.csproj"
COPY . .
WORKDIR "/src/src/apps/Palaver"
RUN dotnet build "Palaver.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Palaver.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Palaver.dll"]
