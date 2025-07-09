# ----------- Build Stage -------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY APIDemoProject.csproj .
RUN dotnet restore

# Copy the remaining source files and build
COPY . .
RUN dotnet publish -c Release -o out

# ----------- Runtime Stage -------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /app/out .

# Expose default HTTP port
EXPOSE 80

# Run the application
ENTRYPOINT ["dotnet", "APIDemoProject.dll"]
