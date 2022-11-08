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
"$aseprite" -b IsometricTiles/colored_tiles_map.aseprite --sheet IsometricTiles/colored_tiles_map.png
"$aseprite" -b IsometricTiles/red_tiles_death.aseprite --sheet IsometricTiles/red_tiles_death.png
### END ISOMETRIC TILES ###

### EFFECTS ###
"$aseprite" -b Effects/spikes_block.aseprite --sheet Effects/spikes_block.png
### END EFFECTS ###

### DECORATIONS ###
"$aseprite" -b Decorations/column_basement.aseprite --sheet Decorations/column_basement.png
"$aseprite" -b Decorations/torch.aseprite --sheet Decorations/torch.png
"$aseprite" -b Decorations/pixel_flame.aseprite --sheet Decorations/pixel_flame.png
### END DECORATIONS ###

### PLAYER ###
"$aseprite" -b Player/idle_player.aseprite --sheet Player/idle_player.png
"$aseprite" -b Player/run_player.aseprite --sheet Player/run_player.png
### REDAMON ###
"$aseprite" -b Player/Redamon/idle_N_player.aseprite --sheet Player/Redamon/idle_N_player.png
"$aseprite" -b Player/Redamon/idle_NW_player.aseprite --sheet Player/Redamon/idle_NW_player.png
"$aseprite" -b Player/Redamon/idle_NE_player.aseprite --sheet Player/Redamon/idle_NE_player.png
"$aseprite" -b Player/Redamon/idle_W_player.aseprite --sheet Player/Redamon/idle_W_player.png
"$aseprite" -b Player/Redamon/idle_E_player.aseprite --sheet Player/Redamon/idle_E_player.png
"$aseprite" -b Player/Redamon/idle_SW_player.aseprite --sheet Player/Redamon/idle_SW_player.png
"$aseprite" -b Player/Redamon/idle_SE_player.aseprite --sheet Player/Redamon/idle_SE_player.png
"$aseprite" -b Player/Redamon/idle_S_player.aseprite --sheet Player/Redamon/idle_S_player.png
"$aseprite" -b Player/Redamon/run_N_player.aseprite --sheet Player/Redamon/run_N_player.png
"$aseprite" -b Player/Redamon/run_NW_player.aseprite --sheet Player/Redamon/run_NW_player.png
"$aseprite" -b Player/Redamon/run_NE_player.aseprite --sheet Player/Redamon/run_NE_player.png
"$aseprite" -b Player/Redamon/run_W_player.aseprite --sheet Player/Redamon/run_W_player.png
"$aseprite" -b Player/Redamon/run_E_player.aseprite --sheet Player/Redamon/run_E_player.png
"$aseprite" -b Player/Redamon/run_SW_player.aseprite --sheet Player/Redamon/run_SW_player.png
"$aseprite" -b Player/Redamon/run_SE_player.aseprite --sheet Player/Redamon/run_SE_player.png
"$aseprite" -b Player/Redamon/run_S_player.aseprite --sheet Player/Redamon/run_S_player.png
"$aseprite" -b Player/Redamon/death_player.aseprite --sheet Player/Redamon/death_player.png
### END PLAYER ###
