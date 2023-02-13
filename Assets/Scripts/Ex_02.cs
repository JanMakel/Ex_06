using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    //Variables
    private int i = 1;
    private string stuipdSensualFlanders = "Hola holita vecinito";
    void Start()
    {
        //While loop that displays 20 times the best cuote of Flanders
        while (i <= 20)
        {
            Debug.Log($"{stuipdSensualFlanders}");
            i++;
        }
    }

}
