using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ����������� ��������� �������� �����������
public class IncreaseSpeed : MonoBehaviour
{
    public float period; //������������� ��������� ��������
    public float increase; //�������� ��������� ��������

    //������ �������� �������������� ������ ��������� �������� �����������
    void Start()
    {
        InvokeRepeating("SpeedUp", period, period);
    }

    //��������� �������� �����������
    public void SpeedUp()
    {
        EnemyScript.speed += increase;
    }
}
