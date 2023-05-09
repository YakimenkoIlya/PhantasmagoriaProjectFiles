using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ������ � �������� ��������� ����
public class Player : MonoBehaviour
{
    public Transform pausePopup; //����������� ���� �����
    public Transform gameOverPopup; //����������� ���� ��������� ����

    public static int HP = 100; //�������� ������
    public static int score = 0; //���� ������

    public static bool gameOnPause = false; //��������� �����

    //���� ���� �������� �� ����� ��� �������������, ��� �������� � ���
    //��������������� � ���������� ��������������� ����������� ����
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
