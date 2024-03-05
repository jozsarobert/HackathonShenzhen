#!/bin/bash

# Copyright Open Logistics Foundation
#
# Licensed under the Open Logistics Foundation License 1.3.
# For details on the licensing terms, see the LICENSE file.
# SPDX-License-Identifier: OLFL-1.3

NEONE_REPO_HTTP_STATUS=$(curl -o /dev/null -s -w '%{http_code}' -i http://graph-db:7200/rest/repositories/"$NEONE_REPO_ID")

if [ "$NEONE_REPO_HTTP_STATUS" -eq "404" ]; then
    echo "Creating neone repository $NEONE_REPO_ID"
    curl -X POST --header 'Content-Type:multipart/form-data' -F 'config=@/opt/neone/graphdb/neone-repository.ttl' 'http://graph-db:7200/rest/repositories'
    # TODO: maybe upload ontology for reasoning/inference
    #echo "Importing data model"
    #curl -X POST --header 'Content-Type: application/json' -d '{
    #  "fileNames": [
    #    "IATA-1R-DM-Ontology.ttl"
    #  ]
    #}' http://graph-db:7200/rest/repositories/"$NEONE_REPO_ID"/import/server
elif [ "$NEONE_REPO_HTTP_STATUS" -eq "200" ]; then
  echo "Repository already exixts"
else
  echo "Error creating repository - Server returned $NEONE_REPO_HTTP_STATUS for repo $NEONE_REPO_ID"
  exit 1
fi
