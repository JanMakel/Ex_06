using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    public int start;
    public int end;
    public int i;
    void Start()
    {
        i = start;
        while ( i < end)
        {
            
            if( i % 5 == 0)
            {
                Debug.Log(i);
            }
            
            i++;
        }

        
    }


    
}
