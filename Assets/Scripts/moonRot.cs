using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonRot : MonoBehaviour
{
    public float rotSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
    }
}
