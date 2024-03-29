using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public float offbound = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > offbound )
            Destroy(gameObject);
        if (transform.position.z < -6 )
            Destroy(gameObject);
        
    }
}
