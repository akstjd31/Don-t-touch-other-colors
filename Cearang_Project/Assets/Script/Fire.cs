using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    private float TimeLeft = 2.0f;
    private float nextTime = 2.0f;

    void bulletfire()
    {       
    Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
        
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;

            bulletfire();
        }

        
    }
}
