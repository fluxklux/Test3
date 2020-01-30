using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0), 10f * Time.deltaTime);
    }
}
