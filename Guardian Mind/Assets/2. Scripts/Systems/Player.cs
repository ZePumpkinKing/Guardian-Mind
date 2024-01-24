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
    [SerializeField] Material[] cursorStates;

    // External Parts
    Input input;
    public GridMap map;

    Camera cam;
    Transform camAnchor;

    Drone[] drones;

    // Tile Selection Cursor
    GameObject cursor;
    Transform[] cursorModel;
    GameObject selectedDrone;

    // Input System Enable
    private void OnEnable() { input.Enable(); }
    private void OnDisable() { input.Disable(); }

    /* ---------------------------------------------- The Usual Suspects -------------------------------------------------- */

    // *Yawns*
    private void Awake()
    {
        //input.tactical.select.performed += context => Select();
        //input.tactical.interact.performed += context => Interact();

        // Initializations
        input = new Input();
        cursor = GameObject.FindWithTag("Cursor");
        cursorModel = cursor.transform.GetComponentsInChildren<Transform>();
        map = new GridMap(levelSize,Vector3.one,Vector3.zero);
    }

    // PREPARE TO ENGAGE THE INFINITE LOOP THAT CRASHES YOUR COMPUTER
    void Start()
    {
        // Initializations
        //map = FindAnyObjectByType<GridMap>();
        cam = Camera.main;
        camAnchor = cam.transform.parent;
        camAnchor.position = new Vector3(levelSize.x / 2, 0, levelSize.y / 2);

        drones = new Drone[5];
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

        Tile selectedTile = map.GetTile(cursor.transform.position);
        if (selectedTile != null) {
            bool selectionBlocked = false;
            if (selectionBlocked) {
                CursorColor(2);
            } else if (selectedTile.interactible != null && !selectionBlocked) {
                CursorColor(1);
            } else {
                CursorColor(0);
            }
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

    void CursorColor(int setting) {
        for (int i = 1; i < cursorModel.Length; i++) {
            cursorModel[i].GetComponent<MeshRenderer>().material = cursorStates[setting];
        }
    }

    void Select() {
        //selectedDrone = map.GetTile(cursor.transform.position).character.gameObject;
    }

    void Interact() {

    }
}
