FROM mcr.microsoft.com/dotnet/sdk:7.0 

WORKDIR /app

COPY . .

RUN dir 

RUN dotnet restore 

CMD ["dotnet", "build", "slsa-poc.csproj"]