#!/usr/bin/env bash
set -m
/opt/mssql/bin/sqlservr --accept-eula & ./setup_database.sh
fg


CMD /bin/bash ./entrypoint.sh
