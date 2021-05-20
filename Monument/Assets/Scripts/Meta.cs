using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public Animator anim;
    public string nombrelevel;
    Estado_Juego estado_;

    void Start()
    {
        estado_ = GameObject.Find("Estado_juego").GetComponent<Estado_Juego>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            estado_.level1 = true;
            anim.SetBool("Ganar", true);
            estado_.Guardar();
            Invoke("cambiar_", 1.5f);

        }
    }

    void cambiar_()
    {
        
        SceneManager.LoadScene(nombrelevel);
    }

}
