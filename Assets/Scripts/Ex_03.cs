using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    public int countDown;

    void Start()
    {
      for (int i = countDown; i > 0; i--)
        {
            Debug.Log(i);
        }
    }

    
}
