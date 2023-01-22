using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    Rigidbody rb_;
    Transform tr_;

    [SerializeField]
    float cenOfMassX = 0;
    [SerializeField]
    float cenOfMassY = 0;
    [SerializeField]
    float cenOfMassZ = 1.7f;

    void Start()
    {
        rb_ = GetComponent<Rigidbody>();
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb_.centerOfMass= new(cenOfMassX, cenOfMassY,cenOfMassZ);
    }

    private void OnDrawGizmos()
    {
        if (rb_ == null)
            rb_ = GetComponent<Rigidbody>();
        if (tr_ == null)
            tr_ = GetComponent<Transform>();


        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(tr_.TransformPoint(rb_.centerOfMass), 1f);
    }
}
