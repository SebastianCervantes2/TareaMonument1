using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton2 : MonoBehaviour
{

    private Animator Anim_Suelo;
    private Animator Anim_Pilar;
    public string PlataformaSuelo;
    public string PlataformaPilar;

    private void Start()
    {
        Anim_Suelo = GameObject.Find(PlataformaSuelo).GetComponent<Animator>();
        Anim_Pilar = GameObject.Find(PlataformaPilar).GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Anim_Suelo.SetBool("Action", true);
        Anim_Pilar.SetBool("Action", true);

    }


}
