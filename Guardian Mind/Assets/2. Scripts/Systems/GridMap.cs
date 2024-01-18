using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap {
    Vector3 cellSize;
    Vector3 spacing;

    public Vector3[,,] tiles;

    public GridMap(Vector3 size, Vector3 cellSize, Vector3 spacing) {
        tiles = new Vector3[(int)size.x, (int)size.y, (int)size.z];

        for (int a = 0; a < tiles.GetLength(0); a++) {
            for (int b = 0; b < tiles.GetLength(1); b++) {
                for (int c = 0; c < tiles.GetLength(2); c++) {
                    tiles[a, b, c] = new Vector3(a, b, c);
                    tiles[a, b, c].Scale(cellSize + spacing);
                    Debug.Log("New tile at: " + a + ", " + b + ", " + c);
                }
            }
        }
    }
}
