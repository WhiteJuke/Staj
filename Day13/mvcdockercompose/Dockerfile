FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy everything
COPY . ./
# Restore as distinct layers
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef --version 6.0.8
RUN dotnet restore
RUN dotnet publish -c Release -o out
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
EXPOSE 80/tcp
# Build runtime image
RUN ["dotnet", "build"]

COPY entrypoint.sh entrypoint.sh
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

COPY entrypoint.sh entrypoint.sh
RUN chmod +x ./entrypoint.sh 
CMD /bin/bash ./entrypoint.sh
