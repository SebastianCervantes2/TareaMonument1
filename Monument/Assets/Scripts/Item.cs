using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    bool press;
    Material mate_;
    Estado_Juego estado_;
    
    void Start()
    {
        estado_ = GameObject.Find("Estado_juego").GetComponent<Estado_Juego>();
        
        if (estado_.item1)
        {
            Destroy(gameObject);
        }

        mate_ = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (press)
        {
            mate_.color = Color.Lerp(mate_.color, Color.clear, 2 * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        estado_.item1 = true;
        press = true;
    }
}
