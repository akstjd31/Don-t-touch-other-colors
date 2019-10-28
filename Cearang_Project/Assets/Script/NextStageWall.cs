using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStageWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject Cubes;
        Cubes = GameObject.Find("Cubes");

        if (other.gameObject.name == "FreeCar")
        {
            GameObject.Find("GameManager").SendMessage("NextStage");
            Destroy(gameObject);
            Destroy(Cubes);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
