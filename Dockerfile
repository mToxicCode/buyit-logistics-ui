FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ToxiCode.BuyIt.Logistics.Ui/ToxiCode.BuyIt.Logistics.Ui.csproj", "ToxiCode.BuyIt.Logistics.Ui/"]
RUN dotnet restore "ToxiCode.BuyIt.Logistics.Ui/ToxiCode.BuyIt.Logistics.Ui.csproj"
COPY . .
WORKDIR "/src/ToxiCode.BuyIt.Logistics.Ui"
RUN dotnet build "ToxiCode.BuyIt.Logistics.Ui.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToxiCode.BuyIt.Logistics.Ui.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToxiCode.BuyIt.Logistics.Ui.dll"]
