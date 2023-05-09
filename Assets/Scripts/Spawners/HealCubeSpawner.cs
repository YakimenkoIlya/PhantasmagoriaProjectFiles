using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ��������� ����� ��������� � �������� ������� �����
public class HealCubeSpawner : MonoBehaviour
{
    public GameObject[] healCube; //������ � �������� ��������� ����� ���������
    public float period; //������������� ��������� ����� ���������
    public float delay; //�������� ����� ������ ����������
    public float YPosition = 16.5f; //������� ������� ������� ���������, ������
    //����� ���������������� �����
    public float ZPosition = -4.21f; //��������� ������� ��������� �� ��� Z �
    //������� �����

    public static float maxRightPosition = 14.5f; //������ ������� ������� ���������,
    //����� ����� ���������������� �����
    private int rand; //������ �������� ���������� ���� ��������� ��� ���������
    private float startPositionX; //�������� �� ��� X ��������� ������� ���� ���������
    private int positionVariant; //������� �������� �� ��� X ��������� ������� ���� ���������

    //������ �������� �������������� ������ ��������� ����� ���������
    void Start()
    {
        InvokeRepeating("SpawnHealCube", delay, period);
    }

    //��������� ������� ������������ ������� ��� �������� �� ��� X ���������
    //������� ���� ���������. � ����� �� ���� ������� ��� �������� ����� ������
    //������� ������� ���������, � ������ - �����. ����� ����������� �������� ���
    //��������� ���������� �� �������, ��� � �������� ����� ���������, Y ������
    //�������� � �������� ������ � ������ ������ ������� ���������, � Z ����� �������
    //�������� ������� ���������
    private void SpawnHealCube()
    {
        positionVariant = Random.Range(0, 2);

        if (positionVariant == 0)
        {
            startPositionX = -maxRightPosition;
        }
        else
        {
            startPositionX = maxRightPosition;
        }

        rand = Random.Range(0, healCube.Length);
        Instantiate(healCube[rand], new Vector3(startPositionX, Random.Range(-YPosition, YPosition), ZPosition),
            Quaternion.identity);
    }
}
