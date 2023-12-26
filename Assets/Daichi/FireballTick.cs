using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballTick : MonoBehaviour
{

    protected Vector3 forward;
    protected Rigidbody rb;
    private ProjectileManager projectileManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        projectileManager = GetComponent<ProjectileManager>();
        Destroy(this.gameObject,5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = forward * 10;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != projectileManager.holder) {
            Destroy(this.gameObject);
            HP hp = other.gameObject.GetComponent<HP>();
            if(hp) {
                hp.removeHP(5);
            }
        }
    }

    public void setForward(Vector3 forward) {
        this.forward = forward;
    }
}
