using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance { get; private set; }

    [SerializeField] private Transform gridTile;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private int tileWidth;

    private TileSystem<TileObject> tileSystem;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There's more than one GridManager! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        tileSystem = new TileSystem<TileObject>(width, height, tileWidth, (TileSystem<TileObject> tSystem, Tile tile) => new TileObject(tSystem, tile));
    }
}
