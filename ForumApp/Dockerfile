# Stage 1: Build and run app in development mode
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev-env
WORKDIR /app

# Copy project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the files
COPY . ./

# Expose port 80
EXPOSE 80

# Run the app
ENTRYPOINT ["dotnet", "watch", "run"]
