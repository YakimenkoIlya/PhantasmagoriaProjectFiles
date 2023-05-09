using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ����������
public class EnemyScript : MonoBehaviour
{
    public float stoppingDistance; //����������� ��������� ����� ����������� �
    //�������
    public int oneTimeDamage; //������������ ����
    public float period; //������ ����� ����������� �����

    private bool isTakingDamage; //��������� ����� ����������� � ������ ������
    private static Vector3 PlayerPosition; //������� ������ � ������� �����
    public static float speed = 8; //��������� �������� �����������
    public static float defaultSpeed = speed; //�������� ����������� �� ���������

    //��������� ��������� �����������, ����� ��� ��� ��������� �������������� �
    //������ ���������� ��������
    void Start()
    {
        transform.Rotate(Vector3.up * 180);
    }

    //���� ���������� ����� ������� � ����������� ������ ����������� ���������,
    //��������� �������� � ������� �������. ���� ���, ���� �������� �������� ����
    void Update()
    {
        PlayerPosition = Camera.main.transform.position;

        if (Vector3.Distance(transform.position, PlayerPosition) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards
                (transform.position, PlayerPosition, speed * Time.deltaTime);

            isTakingDamage = false;
        }
        else
        {
            transform.position = this.transform.position;
            
            if(Player.HP > 0)
            {
                if (!isTakingDamage)
                {
                    InvokeRepeating("MakeDamage", 0, period);
                    isTakingDamage = true;
                }
            }
            else
            {
                CancelInvoke("MakeDamage");
            }
        }
    }

    //��������� �����
    private void MakeDamage()
    {
        Player.HP -= oneTimeDamage;
    }
}
