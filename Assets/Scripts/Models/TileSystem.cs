using Assets.Scripts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSystem<TTileObject>
{
    private int width;
    private int height;
    private float tileWidth;
    private TTileObject[,] tileObjects;

    public TileSystem(int width, int height, float tileWidth, Func<TileSystem<TTileObject>, Tile, TTileObject> createTileObject)
    {
        this.width = width;
        this.height = height;
        this.tileWidth = tileWidth;

        tileObjects = new TTileObject[width, height];
        for(int x = 0; x < width; x++)
        {
            for(int z = 0; z < height; z++)
            {
                Tile tile = new(x, z);
                tileObjects[x, z] = createTileObject(this, tile);
            }
        }
    }
}
