using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpeedArrows : MonoBehaviour
{
    public float speedFactor = 5.5f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
