docker stop game_client
docker kill game_client
docker run --rm  -p 3020:3020 --name game_client dollClient:latest
