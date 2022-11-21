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
"$aseprite" -b IsometricTiles/tiles_map_wall_collider.aseprite --sheet IsometricTiles/tiles_map_wall_collider.png
"$aseprite" -b IsometricTiles/tiles_map_wall_collider_v2.aseprite --sheet IsometricTiles/tiles_map_wall_collider_v2.png
"$aseprite" -b IsometricTilesTest/tiles_test.aseprite --sheet IsometricTilesTest/tiles_test.png
"$aseprite" -b IsometricTiles/colored_tiles_map.aseprite --sheet IsometricTiles/colored_tiles_map.png
"$aseprite" -b IsometricTiles/red_tiles_death.aseprite --sheet IsometricTiles/red_tiles_death.png
"$aseprite" -b IsometricTiles/colored_rune_tiles_map.aseprite --sheet IsometricTiles/colored_rune_tiles_map.png
"$aseprite" -b IsometricTiles/earth_tiles_map.aseprite --sheet IsometricTiles/earth_tiles_map.png

### END ISOMETRIC TILES ###

### EFFECTS ###
"$aseprite" -b Effects/spikes_block.aseprite --sheet Effects/spikes_block.png
"$aseprite" -b Effects/explosion_effect.aseprite --sheet Effects/explosion_effect.png
### END EFFECTS ###

### DECORATIONS ###
"$aseprite" -b Decorations/column_basement.aseprite --sheet Decorations/column_basement.png
"$aseprite" -b Decorations/torch.aseprite --sheet Decorations/torch.png
"$aseprite" -b Decorations/pixel_flame.aseprite --sheet Decorations/pixel_flame.png
"$aseprite" -b Decorations/spikes_wall.aseprite --sheet Decorations/spikes_wall.png
### END DECORATIONS ###

### PLAYER ###
"$aseprite" -b Player/idle_player.aseprite --sheet Player/idle_player.png
"$aseprite" -b Player/run_player.aseprite --sheet Player/run_player.png
### REDAMON CHIEF ###
"$aseprite" -b Player/RedamonChief/chief_idle.aseprite --sheet Player/RedamonChief/chief_idle.png
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

### OBJECT ###
"$aseprite" -b Objects/dungeon_key.aseprite --sheet Objects/dungeon_key.png
"$aseprite" -b Objects/portal.aseprite --sheet Objects/portal.png
"$aseprite" -b Objects/portal_interruptor.aseprite --sheet Objects/portal_interruptor.png
"$aseprite" -b Objects/rules_board.aseprite --sheet Objects/rules_board.png
### END OBJECT ###

### TRANSITIONS ###
"$aseprite" -b Transitions/circle_grow_up.aseprite --sheet Transitions/circle_grow_up.png
"$aseprite" -b Transitions/circle_close.aseprite --sheet Transitions/circle_close.png
### END TRANSITIONS ###

### PARTICLES ###
"$aseprite" -b Particles/simple_white_particle.aseprite --sheet Particles/simple_white_particle.png
### END PARTICLES ###

### UI ###
"$aseprite" -b UI/x_button.aseprite --sheet UI/x_button.png
"$aseprite" -b UI/rules_board.aseprite --sheet UI/rules_board.png
### END UI ###

### WEAPON ###
"$aseprite" -b Weapons/sword.aseprite --sheet Weapons/sword.png
"$aseprite" -b Weapons/knife.aseprite --sheet Weapons/knife.png
### END WEAPON ###

### ENEMIES ###
"$aseprite" -b Enemies/bat.aseprite --sheet Enemies/bat.png
### END ENEMIES ###