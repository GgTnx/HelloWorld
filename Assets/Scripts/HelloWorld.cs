using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public int min;
    public int max;
    private int _guess;
    private int _couter;
    public Text _text;

    void Start()
    {

        _couter = 0;

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
            _text.text = $"Ура!!! Победа!!! Понадобилось {_couter} ходов!";
            min = 0;
            max = 0;
            _guess = 0;
            _couter = 0;

        }
      

    }

    private void CalculateGeuss()
    {
        _guess = (min + max) / 2;
        _text.text = $"Твое число {_guess}?Да?";
        _couter++;
    }

    
    


}
