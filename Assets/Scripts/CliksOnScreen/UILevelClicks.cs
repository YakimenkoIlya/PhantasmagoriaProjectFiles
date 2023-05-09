using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Класс обработчиков нажатия кнопок основной игровой сцены
public class UILevelClicks : MonoBehaviour
{
    public Transform pausePopup; //Всплывающее окно паузы
    public Transform gameOverPopup; //Всплывающее окно окончания игры

    //Перезапуск игровой сцены
    public void ReloadClick()
    {
        Time.timeScale = 1f;

        pausePopup.gameObject.SetActive(false);
        gameOverPopup.gameObject.SetActive(false);

        SceneManager.LoadScene("LevelScene");
        Player.gameOnPause = false;
        Player.HP = 100;
        Player.score = 0;
        EnemyScript.speed = EnemyScript.defaultSpeed;
    }

    //Продолжение текущей игровой сессии
    public void ResumeClick()
    {
        Time.timeScale = 1f;
        Player.gameOnPause = false;

        pausePopup.gameObject.SetActive(false);
    }

    //Переход в главное меню
    public void BackToMenuClick()
    {
        Time.timeScale = 1f;

        Player.gameOnPause = false;
        pausePopup.gameObject.SetActive(false);
        gameOverPopup.gameObject.SetActive(false);

        SceneManager.LoadScene("StartScene");

        Player.HP = 100;
        Player.score = 0;
        EnemyScript.speed = EnemyScript.defaultSpeed;
    }

    //Нажатие на паузу
    public void pauseClick()
    {
        Player.gameOnPause = true;
    }
}
