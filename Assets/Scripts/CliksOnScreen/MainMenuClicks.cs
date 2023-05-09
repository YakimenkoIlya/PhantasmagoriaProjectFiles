using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Класс обработчиков нажатий для кнопок стартового меню приложения
public class MainMenuClicks : MonoBehaviour
{
    public Transform tutorialPopup; //Всплывающее окно туториала

    //Переход на сцену перед основной игрой
    public void ToPrelevelClick()
    {
        SceneManager.LoadScene("PrelevelScene");
    }

    //Открытие окна туториала
    public void ToTutorialClick()
    {
        tutorialPopup.gameObject.SetActive(true);
        tutorialPopup.SetAsLastSibling();
    }

    //Закрытие окна туториала
    public void BackFromTutorial()
    {
        tutorialPopup.gameObject.SetActive(false);
    }
}
