#!/bin/sh

aseprite="aseprite"

if [[ "$OSTYPE" == "darwin"* ]]; then
    aseprite="/Applications/Aseprite.app/Contents/MacOS/aseprite"
elif [[ "$OSTYPE" == "msys" ]]; then
    aseprite="C:\Program Files\Aseprite\Aseprite.exe"
fi

### ISOMETRIC TILES ###
# GROUND #
"$aseprite" -b IsometricTiles/tiles_map.aseprite --sheet IsometricTiles/tiles_map.png
"$aseprite" -b IsometricTilesTest/tiles_test.aseprite --sheet IsometricTilesTest/tiles_test.png

### END ISOMETRIC TILES ###

### PLAYER ###
"$aseprite" -b Player/idle_player.aseprite --sheet Player/idle_player.png
"$aseprite" -b Player/run_player.aseprite --sheet Player/run_player.png
### END PLAYER ###

