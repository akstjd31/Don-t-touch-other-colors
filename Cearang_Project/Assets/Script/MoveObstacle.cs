using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float delta = 0.1f;
    void Update()
    {
        float newZPosition = gameObject.transform.localPosition.z + delta;
        transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, newZPosition);

        if(gameObject.transform.localPosition.z > 12)
        {
            delta = -0.1f;
        } else if(gameObject.transform.localPosition.z < 5.5) {
            delta = 0.1f;
        }
    }
}
