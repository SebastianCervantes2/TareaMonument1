using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarMap : MonoBehaviour
{

    public GameObject Level1;
    public GameObject Level2;
    private bool ByeLevel1;






    public Animator AnimLevel1;



    private void Start()
    {

        AnimLevel1 = GameObject.Find("Nivel1").GetComponent<Animator>();


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            StartCoroutine(SiguienteNivel());
        }

    }

     private IEnumerator SiguienteNivel()
    {

        AnimLevel1.SetBool("ActionNivel1", true);

        yield return new WaitForSeconds(3);

        Destroy(gameObject);
       
        Level2.SetActive(true);
        Level1.SetActive(false);

    }

}
