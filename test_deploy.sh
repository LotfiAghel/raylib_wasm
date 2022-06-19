git push
ssh root@amarokgame.com << EOF
 cd /root/dolls/raylib_wasm
 git pull
 sh build.sh 
 sh run.sh 
 echo \$PWD   
 
 echo \$PWD   
 echo \$PWD   
EOF

