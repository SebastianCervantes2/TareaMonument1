using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{

    public Animator Anim_;
    public string name;

    private void Start()
    {
        Anim_ = GameObject.Find(name).GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Anim_.SetBool("Action", true);
        }
    }

}
