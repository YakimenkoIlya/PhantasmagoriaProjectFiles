using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Класс отображения здоровья игрока в основной игровой сцене
public class HPIndicator : MonoBehaviour
{
    public TextMeshProUGUI HPIndicatorText; //Текстовое поле индикатора здоровья

    //Отображение здоровья на своем текстовом поле
    void Update()
    {
        HPIndicatorText.text = Player.HP.ToString();
    }
}
