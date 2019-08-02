using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDaBox : MonoBehaviour
{
    
    void Cubo()
    {
        Vector3 v = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        v *= 0.5f;
        transform.Translate(v);
    }

    void Update()
    {
       
    }
}
