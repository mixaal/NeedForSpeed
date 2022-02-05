using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour

{
    double dt = 0;
    Vector3 last_position ;
    bool collision;

     // Start is called before the first frame update
    void Start()
    {
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(collision) {
            transform.position = last_position;
        }
        last_position = transform.position;
        Debug.Log(transform.position.y);
        Debug.Log(collision);
    }

     private void OnTriggerEnter(Collider other)
    {
        collision = true;
    }
}
