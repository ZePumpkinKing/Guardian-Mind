using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] float variance;

    Transform[] parts;
    float initialY;

    // Start is called before the first frame update
    void Start()
    {
        parts = gameObject.GetComponentsInChildren<Transform>();
        initialY = parts[1].position.y;
    }

    // Update is called once per frame
    void Update() {
        for (int i = 1; i < parts.Length; i++) {
            parts[i].position = new Vector3(parts[i].position.x, Mathf.Clamp(Random.Range(parts[i].position.y - variance, parts[i].position.y + variance), initialY - variance, initialY + variance), parts[i].position.z);
        }
    }
}
