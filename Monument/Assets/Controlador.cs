using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    public GameObject PlataformaL;
    public GameObject PlataformaV;
    public Boton Detener;


// Start is called before the first frame update
    void Start()
    {

        Detener = GameObject.Find("Boton").GetComponent<Boton>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlataformaV")
        {
            Debug.Log("Choco");
        }


    }

}
