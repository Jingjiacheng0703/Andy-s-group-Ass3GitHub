using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollider : MonoBehaviour
{
    [HideInInspector]
    private void Update()
    {
        transform.Rotate(Vector3.up, 30 * Time.deltaTime);
    }
}
