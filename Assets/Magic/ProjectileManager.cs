using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
   
    public Func<Vector3> forwardGetter;
    public List<GameObject> ignores { get; private set; } = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyItself()
    {
        Destroy(gameObject);
    }

    public void DestroyItself(float f)
    {
        Destroy(gameObject, f);
    }
}
