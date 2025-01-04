# Stage 1: Build and run app in development mode
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev-env
WORKDIR /app

# Copy all files and restore dependencies
COPY . ./
RUN dotnet restore

# Expose port 80
EXPOSE 80

# Run the app with live updates
ENTRYPOINT ["dotnet", "watch", "run"]
