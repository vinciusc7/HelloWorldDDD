# Use a imagem oficial do SDK para buildar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build


# Copiar csproj e restaurar dependências
COPY ["Itau.Uv8.Worker.Monitoracao.Worker/Itau.Uv8.Worker.Monitoracao.Worker.csproj", "Itau.Uv8.Worker.Monitoracao.Worker/"]
COPY ["Itau.Uv8.Worker.Monitoracao.Domain/Itau.Uv8.Worker.Monitoracao.Domain.csproj", "Itau.Uv8.Worker.Monitoracao.Domain/"]
COPY ["Itau.Uv8.Worker.Monitoracao.Infrastructure/Itau.Uv8.Worker.Monitoracao.Infrastructure.csproj", "Itau.Uv8.Worker.Monitoracao.Infrastructure/"]
COPY ["Itau.Uv8.Worker.Monitoracao.Services/Itau.Uv8.Worker.Monitoracao.Services.csproj", "Itau.Uv8.Worker.Monitoracao.Services/"]


RUN dotnet restore "Itau.Uv8.Worker.Monitoracao.Worker/Itau.Uv8.Worker.Monitoracao.Worker.csproj"

# Copiar todo o código fonte
COPY . .

WORKDIR /Itau.Uv8.Worker.Monitoracao.Worker

# Build da aplicação
RUN dotnet publish -c Release -o /app/publish

# Build da imagem runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0

WORKDIR /app
COPY --from=build /app/publish .

# Definir o comando padrão
ENTRYPOINT ["dotnet", "Itau.Uv8.Worker.Monitoracao.Worker.dll"]