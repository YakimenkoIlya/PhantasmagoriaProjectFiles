using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//����� ����������� ��������� ����� ������ � �������� ������� �����
public class ScoreIndicator : MonoBehaviour
{
    public TextMeshProUGUI ScoreIndicatorText; //��������� ���� ����������
    //��������� �����

    //����������� ��������� ����� �� ����� ��������� ����
    void Update()
    {
        ScoreIndicatorText.text = "����:\n" + Player.score;
    }
}
