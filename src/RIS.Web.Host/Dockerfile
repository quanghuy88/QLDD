FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/RIS.Web.Host/RIS.Web.Host.csproj", "src/RIS.Web.Host/"]
COPY ["src/RIS.Web.Core/RIS.Web.Core.csproj", "src/RIS.Web.Core/"]
COPY ["src/RIS.Application/RIS.Application.csproj", "src/RIS.Application/"]
COPY ["src/RIS.Core/RIS.Core.csproj", "src/RIS.Core/"]
COPY ["src/RIS.EntityFrameworkCore/RIS.EntityFrameworkCore.csproj", "src/RIS.EntityFrameworkCore/"]
WORKDIR "/src/src/RIS.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/RIS.Web.Host", "src/RIS.Web.Host"]
COPY ["src/RIS.Web.Core", "src/RIS.Web.Core"]
COPY ["src/RIS.Application", "src/RIS.Application"]
COPY ["src/RIS.Core", "src/RIS.Core"]
COPY ["src/RIS.EntityFrameworkCore", "src/RIS.EntityFrameworkCore"]
WORKDIR "/src/src/RIS.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "RIS.Web.Host.dll"]
