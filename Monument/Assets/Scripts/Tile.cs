using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Point")]
    public Transform pos_point;
    public float tamaño;
#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        if (pos_point != null)
        {
            Gizmos.DrawSphere(pos_point.position, tamaño);
        }
    }

#endif
}
