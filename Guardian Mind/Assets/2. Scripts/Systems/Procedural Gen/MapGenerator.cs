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

        foreach (Vector3 tile in roomGrid.tiles)
        {
            Room(tile);
        }

        foreach (Vector3 tile in cornerGrid.tiles)
        {
            Corner(tile);
        }

        foreach (Vector3 tile in wallGrid.tiles)
        {
            Wall(tile, true);
            Wall(tile, false);
        }
    }

    void Room(Vector3 location)
    {
        Debug.Log("Making a room");
        GameObject newItem = GameObject.Instantiate(rooms[(int)Mathf.Floor(Random.Range(0, rooms.Length))]);
        newItem.transform.position = location;
    }

    void Wall(Vector3 location, bool vertical)
    {
        Debug.Log("Making a wall");
        if (vertical) {
            GameObject newItem = GameObject.Instantiate(walls[(int)Mathf.Floor(Random.Range(0, walls.Length))]);
            newItem.transform.position = location;
            newItem.transform.rotation = Quaternion.Euler(0, 90, 0);
            newItem.transform.position += new Vector3(0, 0, 7);
        } else {
            GameObject newItem = GameObject.Instantiate(walls[(int)Mathf.Floor(Random.Range(0, walls.Length))]);
            newItem.transform.position = location;
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
