using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text myText;
    public Text counter;
    private int summa = 0;
    private int turn = 0;
    void Start()
    {
        myText.text = "Нажмите цифру от 1 до 9";
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)||Input.GetKeyDown(KeyCode.Keypad1))
        {
          summa += 1;
           Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)||Input.GetKeyDown(KeyCode.Keypad2))
        {
       
            summa += 2;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)||Input.GetKeyDown(KeyCode.Keypad3))
        {
            summa += 3;
           Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)||Input.GetKeyDown(KeyCode.Keypad4))
        {
            summa += 4;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)||Input.GetKeyDown(KeyCode.Keypad5))
        {
            summa += 5;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)||Input.GetKeyDown(KeyCode.Keypad6))
        {
            summa += 6;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7)||Input.GetKeyDown(KeyCode.Keypad7))
        {
            summa += 7;
           Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8)||Input.GetKeyDown(KeyCode.Keypad8))
        {
            summa += 8;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9)||Input.GetKeyDown(KeyCode.Keypad9))
        {
            summa += 9;
            Turn();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myText.text = "Нажмите цифру от 1 до 9";
            summa = 0;
            counter.text = $"Сумма {summa}";
        }

        if (summa >= 50)
        {
            myText.text = $"Поздравляю, ты победил за {turn} ходов";
        }
        
        
        
        
        
    }

    private void Turn()
    {
        counter.text = $"Сумма {summa}";
        turn++;
    }
}
