using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ��������� ����������� � �������� ������� �����
public class EnemySpowner : MonoBehaviour
{
    public GameObject[] enemy; //������ � �������� ��������� �����������
    public float period; //������������� ��������� �����������
    public float delay; //�������� ����� ������ ����������
    public float YPosition = 16.5f; //������� ������� ������� ���������, ������ �����
    //���������������� �����
    public float XPosition = 14.5f; //������ ������� ������� ���������, ����� �����
    //���������������� �����
    public float ZPosition = -4.21f; //��������� ������� ��������� �� ��� Z �
    //������� �����

    private int rand; //������ �������� ���������� ���������� ��� ���������

    //������ �������� �������������� ������ ��������� �����������
    public void Start()
    {
        InvokeRepeating("SpawnEnemy", delay, period);
    }

    //��������� ����������� ���������� ��� ��������� � �����. ����� ��������� �����
    //���������� �������� � �������� ������� ���������
    private void SpawnEnemy()
    {
       rand = Random.Range(0, enemy.Length);
       Instantiate(enemy[rand], new Vector3(Random.Range(-XPosition, XPosition), Random.Range(-YPosition, YPosition), ZPosition),
            Quaternion.identity);
    }
}
