using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    private int i = 1;
    private string stuipdSensualFlanders = "Hola holita vecinito";
    void Start()
    {
        while (i <= 20)
        {
            Debug.Log($"{stuipdSensualFlanders}");
            i++;
        }
    }

}
