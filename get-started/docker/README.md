# Implementing IronWord in Docker Environments

***Based on <https://ironsoftware.com/get-started/docker/>***


IronWord provides comprehensive support in Docker environments across both Linux and Windows platforms. This makes it an excellent choice for deployments on cloud platforms such as Azure, AWS, or any other host compatible with .NET.

## Benefits of Using Docker

Utilizing Docker, you can encapsulate IronWord within a portable, lightweight container. This consistent encapsulation facilitates uniform application behavior across different stages like development, testing, and production. This is particularly crucial when working with Word document generation or manipulation through code.

IronWord is compatible with .NET versions 5-9, .NET Standard versions 2.x and 3.x, and .NET Framework version 4.6.2 or newer. This comprehensive compatibility ensures flawless functionality within Docker on both Linux and Windows systems.

## Preferred Linux Distributions for Docker

For the most efficient operation of IronWord, we recommend these 64‑bit Linux distributions:

- Ubuntu 22.04 or newer (Jammy)
- Ubuntu 20.04 (Focal)
- Debian 11 or newer (Bullseye)
- CentOS7 or later

For easier configuration and management of dependencies, consider using Microsoft’s [official Docker images](https://hub.docker.com/r/microsoft/dotnet-runtime) which offer the .NET runtime and SDK.

## IronWord NuGet Package Installation

Adding IronWord to your .NET projects is straightforward with its NuGet package. Execute the command below in the NuGet Package Manager Console to install the library:

```shell
Install-Package IronWord
```

## Dockerfile Examples for Ubuntu

### Example for Ubuntu 22 and .NET 8

```dockerfile
# Base image

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/runtime:8.0-jammy AS base
WORKDIR /app

# Build phase

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS build
WORKDIR /src
COPY ["Example/Example.csproj", "Example/"]
RUN dotnet restore "Example/Example.csproj"

COPY . .
WORKDIR "/src/Example"
RUN dotnet build "Example.csproj" -c Release -o /app/build

# Publish phase

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM build AS publish
RUN dotnet publish "Example.csproj" -c Release -o /app/publish

# Setup final stage

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.dll"]
```

### Example for Ubuntu 20.04 and .NET 6 (LTS)

```dockerfile
# Establishing base environment

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/runtime:6.0-focal AS base
WORKDIR /app

# Commencing build

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Example/Example.csproj", "Example/"]
RUN dotnet restore "Example/Example.csproj"

COPY . .
WORKDIR "/src/Example"
RUN dotnet build "Example.csproj" -c Release -o /app/build

# Proceeding to publishing

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM build AS publish
RUN dotnet publish "Example.csproj" -c Release -o /app/publish

# Final Configuration

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.dll"]
```

## Dockerfile Example for Debian

### Setting Up for Debian 11 and .NET 7

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:7.0-bullseye-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim AS build
WORKDIR /src
COPY ["Example/Example.csproj", "Example/"]
RUN dotnet restore "Example/Example.csproj"

COPY . .
WORKDIR "/src/Example"
RUN dotnet build "Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.dll"]
```

## Compatibility with CentOS 7

For systems using CentOS 7, favor using a CentOS-compatible .NET runtime such as mcr.microsoft.com/dotnet/runtime:6.0-centos7 to ensure compatibility with IronWord.

```dockerfile
# Build stage setup

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY ./Example/Example.csproj ./Example/
RUN dotnet restore "./Example/Example.csproj"

COPY ./Example ./Example/
WORKDIR /app/Example
RUN dotnet publish -c Release -o /out

# Setup runtime environment - CentOS 7

***Based on <https://ironsoftware.com/get-started/docker/>***

FROM mcr.microsoft.com/dotnet/runtime:6.0-centos7 AS runtime
WORKDIR /app

RUN yum install -y liberation-fonts && yum clean all

COPY --from=build /out ./

ENTRYPOINT ["dotnet", "Example.dll"]
```

## Additional Information & Troubleshooting

- IronWord fully endorses .NET versions 5 through 9, .NET Standard (2.x, 3.x), and .NET Framework 4.6.2 and newer.
- On Linux containers, you might need to install certain fonts (such as fonts-liberation or ttf-mscorefonts-installer) to ensure proper document rendering.