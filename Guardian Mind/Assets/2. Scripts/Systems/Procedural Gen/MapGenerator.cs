using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] rooms;
    [SerializeField] GameObject[] walls;
    [SerializeField] GameObject[] corners;
    [SerializeField] Vector3 levelSize;

    Player player;

    GridMap roomGrid;
    GridMap wallGrid;
    GridMap cornerGrid;

    void Start()
    {
        player = FindAnyObjectByType<Player>();

        roomGrid = new GridMap(levelSize, Vector3.one * 5, Vector3.one);
        cornerGrid = new GridMap(levelSize + new Vector3(1, 0, 1), Vector3.one, Vector3.one * 5);
        wallGrid = new GridMap(levelSize + new Vector3(1, 0, 1), Vector3.one * 5, Vector3.one);


        foreach (Tile tile in roomGrid.tiles) {
            Room(tile);
        }

        foreach (Tile tile in cornerGrid.tiles) {
            Corner(tile);
        }

        foreach (Tile tile in wallGrid.tiles) {
            //if (tile.position.x < wallGrid.tiles.GetLength(0) && tile.position.y < wallGrid.tiles.GetLength(2)) {}
            Wall(tile, true);
            Wall(tile, false);
        }
    }

    void Room(Tile targetTile)
    {
        if (targetTile.floor == null) {
            Vector3 location = targetTile.position;

            Debug.Log("Making a room");
            GameObject newItem = GameObject.Instantiate(rooms[(int)Mathf.Floor(Random.Range(0, rooms.Length))]);
            newItem.transform.position = location;
            targetTile.floor = newItem.transform;
        }
    }

    void Wall(Tile targetTile, bool vertical)
    {
        if (targetTile.floor == null) {
            Vector3 location = targetTile.position;

            Debug.Log("Making a wall");
            GameObject newItem = GameObject.Instantiate(walls[(int)Mathf.Floor(Random.Range(0, walls.Length))]);
            newItem.transform.position = location;
            if (vertical) { 
                newItem.transform.rotation = Quaternion.Euler(0, 90, 0);
                newItem.transform.position += new Vector3(0, 0, 7);
            }
        }
    }
    void Corner(Tile targetTile)
    {
        Vector3 location = targetTile.position;

        Debug.Log("Making a corner");
        GameObject newItem = GameObject.Instantiate(corners[(int)Mathf.Floor(Random.Range(0, corners.Length))]);
        newItem.transform.position = location;
    }

    public void Door()
    {

    }
}
