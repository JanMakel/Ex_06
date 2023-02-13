using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Variable
    public int countDown;

    void Start()
    {
        //Loop that displays a Count down from the variable countDown to 0
      for (int i = countDown; i > 0; i--)
        {
            Debug.Log(i);
        }
    }

    
}
