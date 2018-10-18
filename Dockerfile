FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51812
EXPOSE 44308

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY . ./

RUN dotnet restore "StarterKit.Web/StarterKit.Web.csproj"
COPY . .
WORKDIR "/src"

RUN dotnet build "StarterKit.Web/StarterKit.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StarterKit.Web/StarterKit.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StarterKit.Web.dll"]