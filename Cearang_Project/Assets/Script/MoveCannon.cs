using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float delta = -0.1f;
    // Update is called once per frame
    void Update()
    {
        float newZPosition = gameObject.transform.localPosition.z + delta;
        transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, newZPosition);

        if (gameObject.transform.localPosition.z > 4.3)
        {
            delta = -0.1f;
        }
        else if (gameObject.transform.localPosition.z < -2.5)
        {
            delta = 0.1f;
        }
    }
}
