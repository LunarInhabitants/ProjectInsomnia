﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A collection of tiles
/// </summary>
[CreateAssetMenu(fileName = "PLB_TileSet", menuName = "Procedural Level Builder/Tileset", order = 1101)]
public class PLBTileSet : ScriptableObject
{
    [Serializable]
    public class PLBTileSetEntry
    {
        /// <summary>The tile prefab attached to this entry</summary>
        public PLBTile tile = null;
        /// <summary>A bias to the spawn rate. Lower = Rarer</summary>
        public float biasToSpawn = 1.0f;
    }

    /// <summary>
    /// A list of tiles that can be used for the initial tile.
    /// If this is empty, a random tile will be chosen from the main tile list instead.
    /// </summary>
    public List<PLBTile> initialTiles = new List<PLBTile>();

    /// <summary>The tile entries in this tileset</summary>
    public List<PLBTileSetEntry> tiles = new List<PLBTileSetEntry>();
}
