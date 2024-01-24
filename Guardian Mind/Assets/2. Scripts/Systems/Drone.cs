using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    Player player;
    GridMap map;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindAnyObjectByType<Player>();
        map = player.map;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
