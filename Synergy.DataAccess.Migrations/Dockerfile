FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /src

COPY Synergy.ruleset .
COPY NuGet.config .
COPY Synergy.DataAccess.Enum Synergy.DataAccess.Enum
COPY Synergy.DataAccess.Entities Synergy.DataAccess.Entities
COPY Synergy.DataAccess.Context Synergy.DataAccess.Context
COPY Synergy.DataAccess.Migrations Synergy.DataAccess.Migrations

CMD dotnet ef database update -v --project Synergy.DataAccess.Context/ --startup-project Synergy.DataAccess.Migrations/