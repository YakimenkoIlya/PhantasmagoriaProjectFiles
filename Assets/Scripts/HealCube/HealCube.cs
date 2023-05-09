using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ���� ���������
public class HealCube : MonoBehaviour
{
    public float speed; //�������� ����� ���������
    public float speedRotation; //�������� �������� ����� ������ ����� ������������ ���

    public static int pointsForKill = 50; //���������� ����� �� ��������� �� ���� ���������
    public static int heal = 5; //���������� ����� ��������, ����������������� ������
    //�� ��������� �� ���� ���������
    private float startX; //�������� ��������� ������� � ������� ����� �� ��� X
    private float targetX; //�������� �������� ������� � ������� ����� �� ��� X
    private Vector3 targetPoint; //�������� ������� ���� ��������� � ������� �����

    //���������� ���������� startX �������� ���������� ��������� ���� ��������� �� ��� �.
    //� �������� �������� X ��� �������� ����� ���������� ��������������� ������� 
    //������� ���������
    void Start()
    {
        startX = transform.position.x;

        if (startX == HealCubeSpawner.maxRightPosition)
        {
            targetX = -HealCubeSpawner.maxRightPosition;
        }
        else
        {
            targetX = HealCubeSpawner.maxRightPosition;
        }
    }

    //�����������, �������� �� ��� �����������. ���� ��� ������� �� ���������,
    //�� ��������� ������ ����� ������������ ��� � �������� � ����� �������� �����
    void FixedUpdate()
    {
        CheckForDestroy();

        transform.Rotate(0, speedRotation * Time.deltaTime, 0);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), speed * Time.deltaTime);
        targetPoint = new Vector3(targetX, transform.position.y, transform.position.z);
    }

    //���� ��� ��������� ������ ����� �������� �����, �� ������������
    public void CheckForDestroy()
    {
        if(transform.position == targetPoint)
        {
            Destroy(gameObject);
        }
    }
}
