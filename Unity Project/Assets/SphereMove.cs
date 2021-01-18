using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector3 przesuniecie = new Vector3(0, 0, Time.fixedDeltaTime);
        transform.position -= przesuniecie * speed;
        if (transform.position.z <= -10)
            Destroy(this.gameObject);
    }
}
