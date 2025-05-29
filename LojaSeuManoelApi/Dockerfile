FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copie apenas o .csproj e faça o restore antes de copiar o restante
COPY LojaSeuManoelApi.csproj ./
RUN dotnet restore "LojaSeuManoelApi.csproj"

# Agora sim copie o restante do código
COPY . .

# Compile o projeto
RUN dotnet build "LojaSeuManoelApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LojaSeuManoelApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LojaSeuManoelApi.dll"]
