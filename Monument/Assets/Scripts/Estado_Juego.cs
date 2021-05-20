using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado_Juego : MonoBehaviour
{
    public bool level1;
    public bool item1;

    void Awake()
    {
        Cargar();
    }

    public void Guardar()
    {
        PlayerPrefs.SetString("slot", JsonUtility.ToJson(this));

    }

    public void Cargar()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("slot"), this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.DeleteAll(); 
        }
    }


}


