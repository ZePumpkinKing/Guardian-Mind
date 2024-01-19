using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    readonly GridMap map;
    public Tile[] neighbors;

    public Transform floor;
    public Transform air;
    public Transform character;
    public Transform interactible;
    public Vector3 position;

    public Tile(Vector3 position, GridMap map)
    {
        this.neighbors = new Tile[8];
        this.map = map;
        this.floor = null;
        this.air = null;
        this.character = null;
        this.interactible = null;
        this.position = position;
    }

    public Tile(Transform floor, Transform air, Transform character, Transform interactible, Vector3 position, GridMap map)
    {
        this.map = map;
        this.floor = floor;
        this.air = air;
        this.character = character;
        this.interactible = interactible;
        this.position = position;
    }

    void SetFloor(Transform newItem)
    {
        this.floor = newItem;
    }

    void SetAir(Transform newItem)
    {
        this.air = newItem;
    }

    void SetCharacter(Transform newItem)
    {
        this.character = newItem;
    }

    void SetInteractible(Transform newItem)
    {
        this.interactible = newItem;
    }

    void SetPosition(Vector3 newItem)
    {
        this.position = newItem;
    }
}
