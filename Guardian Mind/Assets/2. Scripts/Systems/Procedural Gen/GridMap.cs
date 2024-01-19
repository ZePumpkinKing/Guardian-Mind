using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap {
    Vector3 cellSize;
    Vector3 spacing;

    public Tile[,,] tiles;

    public GridMap(Vector3 size, Vector3 cellSize, Vector3 spacing) {
        tiles = new Tile[(int)size.x, (int)size.y, (int)size.z];

        for (int a = 0; a < tiles.GetLength(0); a++) {
            for (int b = 0; b < tiles.GetLength(1); b++) {
                for (int c = 0; c < tiles.GetLength(2); c++) {
                    tiles[a, b, c] = new Tile(new Vector3(a, b, c), this);
                    tiles[a, b, c].position.Scale(cellSize + spacing);
                    Debug.Log("New tile at: " + a + ", " + b + ", " + c);
                }
            }
        }
    }

    public void FindNeighbors(Tile origin)
    {
        Tile[] neighbors = new Tile[8];

        neighbors[0] = FindRelative(origin, new Vector3(0, 0, 1));
        neighbors[1] = FindRelative(origin, new Vector3(1, 0, 1));
        neighbors[2] = FindRelative(origin, new Vector3(1, 0, 0));
        neighbors[3] = FindRelative(origin, new Vector3(1, 0, -1));
        neighbors[4] = FindRelative(origin, new Vector3(0, 0, -1));
        neighbors[5] = FindRelative(origin, new Vector3(-1, 0, -1));
        neighbors[6] = FindRelative(origin, new Vector3(-1, 0, 0));
        neighbors[7] = FindRelative(origin, new Vector3(-1, 0, 1));

        origin.neighbors = neighbors;
    }

    public Tile FindRelative(Tile origin, Vector3 deltaPosition) {
        return tiles[(int)origin.position.x + (int)deltaPosition.x, (int)origin.position.y + (int)deltaPosition.y, (int)origin.position.z + (int)deltaPosition.z];
    }

    public Tile GetTile(Vector3 target) {
        return tiles[(int)target.x, (int)target.y, (int)target.z];
    }
}