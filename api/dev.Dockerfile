FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY ./app/*.csproj ./
RUN dotnet restore

# copy everything else and build app
COPY ./app/. ./
# WORKDIR /app
RUN dotnet build


# FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
# WORKDIR /app
# COPY --from=build /app/out ./
# ENTRYPOINT ["dotnet", "api.dll"]
ENTRYPOINT dotnet watch run --urls=http://+:5000