using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        //if banana goes out of bounds
        if(transform.position.z > topBound)
        {
            //destroy banana
            Destroy(gameObject);
        }
        //if animals go out of bounds
        if(transform.position.z < bottomBound)
        {
            //get health system script and call take damage
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            //destroy animal
            Destroy(gameObject);
        }
    }
}
