docker stop game_client
docker kill game_client
docker run --rm  -p 5020:80 --name game_client doll_client:latest
