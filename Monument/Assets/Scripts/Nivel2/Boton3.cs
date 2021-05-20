using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton3 : MonoBehaviour
{

    private Animator Anim_Suelo;
    private Animator Anim_Base;
    private Animator Anim_Boton;
    public string PlataformaSuelo;
    public string PlataformaBase;
    public string PlataformaBoton;

    private void Start()
    {
        Anim_Suelo = GameObject.Find(PlataformaSuelo).GetComponent<Animator>();
        Anim_Base = GameObject.Find(PlataformaBase).GetComponent<Animator>();
        Anim_Boton = GameObject.Find(PlataformaBoton).GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Anim_Suelo.SetBool("Action", true);
        Anim_Base.SetBool("Action", true);
        Anim_Boton.SetBool("Action", true);

    }


}
