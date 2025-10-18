#!/usr/bin/env bash

rm -r ./YandexContestClient/Client
kiota generate -l CSharp -c ContestClient -n YandexContestClient.Client -d "https://api.contest.yandex.net/api/public/v2/api-docs?group=v2" -o ./YandexContestClient/Client --exclude-backward-compatible
