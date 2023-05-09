using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Класс отображения набранных очков игрока в основной игровой сцене
public class ScoreIndicator : MonoBehaviour
{
    public TextMeshProUGUI ScoreIndicatorText; //Текстовое поле индикатора
    //набранных очков

    //Отображение набранных очков на своем текстовом поле
    void Update()
    {
        ScoreIndicatorText.text = "Счёт:\n" + Player.score;
    }
}
