using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileObject : MonoBehaviour
{
    private Tile tile;
    private TileSystem<TileObject> tileSystem;
    
    public TileObject(TileSystem<TileObject> tileSystem, Tile tile)
    {
        this.tileSystem = tileSystem;
        this.tile = tile;
    }
}
