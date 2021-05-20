using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heredador : MonoBehaviour
{
    public Transform Padre;
    public Transform[] Hijos;
    public int i = 0;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            while (i < 4)
            {
                Hijos[i].SetParent(Padre);
                i++;
            }

            Debug.Log("Choco");
        }
    }

}
