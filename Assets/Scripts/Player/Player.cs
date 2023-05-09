using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс игрока и текущего состояния игры
public class Player : MonoBehaviour
{
    public Transform pausePopup; //Всплывающее окно паузы
    public Transform gameOverPopup; //Всплывающее окно окончания игры

    public static int HP = 100; //Здоровье игрока
    public static int score = 0; //Счет игрока

    public static bool gameOnPause = false; //Состояние паузы

    //Если игра ставится на паузу или заканчивается, все процессы в ней
    //останавливаются и появляется соответствующее всплывающее окно
    void Update()
    {
        if (gameOnPause)
        {
            Time.timeScale = 0f;
            pausePopup.gameObject.SetActive(true);
            pausePopup.SetAsFirstSibling();
        }

        if (HP <= 0)
        {
            Time.timeScale = 0f;
            gameOverPopup.gameObject.SetActive(true);
            gameOverPopup.SetAsFirstSibling();
        }
    }
}
