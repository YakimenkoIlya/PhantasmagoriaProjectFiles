using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//����� ����������� �������� ������ � �������� ������� �����
public class HPIndicator : MonoBehaviour
{
    public TextMeshProUGUI HPIndicatorText; //��������� ���� ���������� ��������

    //����������� �������� �� ����� ��������� ����
    void Update()
    {
        HPIndicatorText.text = Player.HP.ToString();
    }
}
