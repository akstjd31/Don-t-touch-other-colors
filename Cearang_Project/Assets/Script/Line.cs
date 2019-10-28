using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z + 0.8f);

    }
}
