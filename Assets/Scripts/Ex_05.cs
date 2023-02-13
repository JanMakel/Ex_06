using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Variables
    private int total;
    public int[] numbers;

    private void Start()
    {
        //Loop that sums all the numbers in the array
        foreach(int numbers in numbers)
        {
            total = total + numbers;
        }
        //Message displayed on the console, displays the sum maked in the loop
        Debug.Log($"{numbers[0]} + {numbers[1]} + {numbers[2]} + {numbers[3]} + {numbers[4]} = {total}");
    }
}
