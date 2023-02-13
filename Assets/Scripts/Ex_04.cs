using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Variables
    public int start;
    public int end;
    public int i;


    void Start()
    {
        //Making the i value the same as Start
        i = start;
        //Loop that displays all multiplies of 5 from a number (Start) to an (End)
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
