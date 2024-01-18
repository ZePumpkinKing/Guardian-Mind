using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Tweakables
    [SerializeField] float scrollSpeed;
    [SerializeField] float verticalSmoothing;
    [SerializeField] float rotationSpeed;
    public Vector3 levelSize;
    [SerializeField] float camHeight;

    // External Parts
    Input input;
    //GridMap map;
    Camera cam;
    Transform camAnchor;

    // Tile Selection Cursor
    GameObject cursor;
    Transform[] cursorModel;

    // Grid
    int[,,] grid;

    // Input System Enable
    private void OnEnable() { input.Enable(); }
    private void OnDisable() { input.Disable(); }

    /* ---------------------------------------------- The Usual Suspects -------------------------------------------------- */

    // *Yawns*
    private void Awake()
    {
        // Initializations
        input = new Input();
        cursor = GameObject.FindWithTag("Cursor");
        cursorModel = cursor.transform.GetComponentsInChildren<Transform>();
        grid = new int[(int)levelSize.x, (int)levelSize.y, (int)levelSize.z];
    }

    // PREPARE TO ENGAGE THE INFINITE LOOP THAT CRASHES YOUR COMPUTER
    void Start()
    {
        // Initializations
        //map = FindAnyObjectByType<GridMap>();
        cam = Camera.main;
        camAnchor = cam.transform.parent;
    }

    // "Muh FPS bruh"
    void Update()
    {
        // Cursor Placement "RaycastHit my beloved"
        RaycastHit hit;
        if (Physics.Raycast(cam.ScreenPointToRay(input.tactical.cursor.ReadValue<Vector2>()), out hit, Mathf.Infinity, LayerMask.GetMask("Ground"))) {
            Vector3 gridPosition = FindGrid(hit.point);
            cursor.transform.position = new Vector3(gridPosition.x, gridPosition.z, gridPosition.y);
            BulkActive(cursorModel, true);
        } else {
            BulkActive(cursorModel, false);
        }

        // Camera Movement (hopefully I can ignore all this math I did now)
        float zoom = input.tactical.zoom.ReadValue<Vector2>().y / -120;
        Vector2 move = input.tactical.move.ReadValue<Vector2>();
        camAnchor.transform.Translate(new Vector3(move.x, 0, move.y) * scrollSpeed, camAnchor.transform);
        if (zoom + cam.transform.position.y >= camHeight && cam.transform.position.y + zoom <= levelSize.y + camHeight) {
            cam.transform.Translate(0, zoom, 0, gameObject.transform);
        }
        camAnchor.transform.Rotate(0, input.tactical.rotate.ReadValue<float>() * rotationSpeed, 0, Space.World);
    }

    /* ---------------------------------------------- Custom Functions -------------------------------------------------- */

    // Takes a list of Transforms and toggles Active true or false for each
    void BulkActive(Transform[] objects, bool isVisible) {
        for (int i = 1; i < objects.Length; i++) {
            objects[i].gameObject.SetActive(isVisible);
        }
    }

    // Aligns a Vector3 to the current tile's origin
    Vector3 FindGrid(Vector3 offPoint) {
        return new Vector3((int)Mathf.Floor(Mathf.Clamp(offPoint.x, 0, levelSize.x)), (int)Mathf.Floor(Mathf.Clamp(offPoint.z, 0, levelSize.z)), (int)Mathf.Floor(Mathf.Clamp(offPoint.y, 0, levelSize.y)));
    }

    // Grid Interaction
    

    /*
    void ToGrid(function doToX, function doToY, function doToZ)
    {
        for (int a = 0; a < listList[0].Length; a++) {
            doToX(a);
        }
        for (in b = 0; b < listList[1].Length; b++) {
            doToY(b);
        }
        for (in c = 0; c < listList[1].Length; c++) {
            doToZ(c);
        }
    }

    void Update()
    {
        ToGrid(DoThis(), DoThat(), DoTheOtherThing());
    }
    */

}
