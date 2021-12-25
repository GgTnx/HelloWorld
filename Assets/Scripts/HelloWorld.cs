using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int min;
    public int max;
    private int _guess;

    void Start()
    {
       
        

        Debug.Log($"Загадай число от {min} до {max}");
        CalculateGeuss();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = _guess;
            CalculateGeuss();

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = _guess;
            CalculateGeuss();

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Ура!!! Победа!!!");

        }

    }

    private void CalculateGeuss()
    {
        _guess = (min + max) / 2;
        Debug.Log($"Твое число {_guess}?Да?");
        
    }

    
    


}
