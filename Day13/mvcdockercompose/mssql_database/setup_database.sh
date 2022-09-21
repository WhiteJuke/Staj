#!/usr/bin/env bash
# Wait for database to startup 
sleep 60
./opt/mssql-tools/bin/sqlcmd -S 127.0.0.1 -U SA -P "123456Aa@" -i setup.sql
