using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//����� ������������ ������� ������ �������� ������� �����
public class UILevelClicks : MonoBehaviour
{
    public Transform pausePopup; //����������� ���� �����
    public Transform gameOverPopup; //����������� ���� ��������� ����

    //���������� ������� �����
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

    //����������� ������� ������� ������
    public void ResumeClick()
    {
        Time.timeScale = 1f;
        Player.gameOnPause = false;

        pausePopup.gameObject.SetActive(false);
    }

    //������� � ������� ����
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

    //������� �� �����
    public void pauseClick()
    {
        Player.gameOnPause = true;
    }
}
