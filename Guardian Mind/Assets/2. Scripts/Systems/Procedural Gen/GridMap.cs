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
                    //Debug.Log("New tile at: " + a + ", " + b + ", " + c);
                }
            }
        }

        for (int a = 0; a < tiles.GetLength(0); a++) {
            for (int b = 0; b < tiles.GetLength(1); b++) {
                for (int c = 0; c < tiles.GetLength(2); c++) {
                    FindNeighbors(tiles[a, b, c]);
                }
            }
        }
    }

    /* This function sets a given Tile's neighbors array to this pattern by index:

                        7   0   1

                        6   @   2

                        5   4   3                                               */
    public void FindNeighbors(Tile origin) {
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
        return this.GetTile(origin.position + deltaPosition);
    }

    public Tile GetTile(Vector3 target) {
        int x = (int)target.x;
        int y = (int)target.y;
        int z = (int)target.z;
        if (x < 0 || x > tiles.GetLength(0) -1) { return null; }
        if (y < 0 || y > tiles.GetLength(1) -1) { return null; }
        if (z < 0 || z > tiles.GetLength(2) -1) { return null; }
        return tiles[x, y, z];
    }
}