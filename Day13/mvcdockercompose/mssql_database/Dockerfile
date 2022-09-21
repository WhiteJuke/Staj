FROM mcr.microsoft.com/mssql/server

COPY setup.sql setup.sql
COPY setup_database.sh setup_database.sh
COPY entrypoint.sh entrypoint.sh

ENV ACCEPT_EULA Y
ENV SA_PASSWORD 123456Aa@

RUN /opt/mssql/bin/sqlservr --accept-eula & ./setup_database.sh
