using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    public Transform destino;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = destino.position;
            other.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
        }
    }

}
