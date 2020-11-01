FROM mcr.microsoft.com/dotnet/core/sdk AS publish
WORKDIR /src

COPY . .
RUN ls -a
RUN dotnet publish "src/dotnet-poc-stock.csproj" -c Release -o /app/publish
FROM mcr.microsoft.com/dotnet/core/aspnet

WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 5006
ENTRYPOINT ["dotnet", "dotnet-poc-stock.dll"]
