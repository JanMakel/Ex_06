using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    
    void Start()
    {
        //Loop that displays in the console every single even number from 1 to 100
        for (int i = 100; i > 1; i -= 2)
        {
            Debug.Log(i);
        }
    }

   
}
