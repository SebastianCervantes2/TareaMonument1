using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Reback : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;


    private void Update()
    {
      
            navMeshSurface.Bake();
       
    }


    
}
