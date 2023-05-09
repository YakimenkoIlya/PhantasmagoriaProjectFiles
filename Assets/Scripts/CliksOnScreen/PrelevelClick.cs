using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Класс обработчика нажатия для кнопки перехода со сцены перед основной игрой к
//игровой сцене
public class PrelevelClick : MonoBehaviour
{
    //Переход на основную игровую сцену
    public void ToLevelClick()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
