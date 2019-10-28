using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("FreeCar");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x - 8, Player.transform.position.y + 3, Player.transform.position.z);
    }
}
