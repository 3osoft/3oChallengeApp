FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["3oChallengeApp/3oChallengeApp.csproj", "3oChallengeApp/"]
RUN dotnet restore "3oChallengeApp/3oChallengeApp.csproj"
COPY . .
WORKDIR "/src/3oChallengeApp"
RUN dotnet build "3oChallengeApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "3oChallengeApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "3oChallengeApp.dll"]