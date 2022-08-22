using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioner : MonoBehaviour
{
    public CharacterController target;
    public float offset = -0.5f;

    void Update()
    {
        transform.position = target.height * Vector3.up + target.transform.position + offset * Vector3.up;
    }
}
