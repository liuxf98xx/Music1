using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicSetting : MonoBehaviour
{
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = false;
    }
}
