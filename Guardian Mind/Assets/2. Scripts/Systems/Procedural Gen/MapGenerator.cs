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
        cornerGrid = new GridMap(levelSize, Vector3.one, Vector3.one * 5);
        wallGrid = new GridMap(levelSize, Vector3.one * 5, Vector3.one);

        foreach (Tile tile in roomGrid.tiles)
        {
            Room(tile.position);
        }

        foreach (Tile tile in cornerGrid.tiles)
        {
            Corner(tile.position);
        }

        foreach (Tile tile in wallGrid.tiles)
        {
            Wall(tile.position, true);
            Wall(tile.position, false);
        }
    }

    void Room(Vector3 location)
    {
        Tile targetTile = roomGrid.GetTile(location);

        if (targetTile.floor == null) {
            Debug.Log("Making a room");
            GameObject newItem = GameObject.Instantiate(rooms[(int)Mathf.Floor(Random.Range(0, rooms.Length))]);
            newItem.transform.position = location;
            targetTile.floor = newItem.transform;
        }
    }

    void Wall(Vector3 location, bool vertical)
    {
        Tile targetTile = wallGrid.GetTile(location);

        if (targetTile.floor == null) {
            Debug.Log("Making a wall");
            GameObject newItem = GameObject.Instantiate(walls[(int)Mathf.Floor(Random.Range(0, walls.Length))]);
            newItem.transform.position = location;
            if (vertical) { 
                newItem.transform.rotation = Quaternion.Euler(0, 90, 0);
                newItem.transform.position += new Vector3(0, 0, 7);
            }
            if (newItem.GetComponent<Tile>().interactible != null) {
                targetTile.interactible = newItem.GetComponent<Tile>().interactible;
            }
        }
    }
    void Corner(Vector3 location)
    {
        Debug.Log("Making a corner");
        GameObject newItem = GameObject.Instantiate(corners[(int)Mathf.Floor(Random.Range(0, corners.Length))]);
        newItem.transform.position = location;
    }

    public void Door()
    {

    }
}
