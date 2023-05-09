using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//����� ������� � �������� ������� �����
public class CameraRaycast : MonoBehaviour
{
    public float Distance; //��������� ����� ������� � �����������
    public LayerMask EnemyLayerMask; //���� ����������
    public LayerMask HealCubeMask; //���� ���� ���������
    public Image verticalLine; //������������ ����� �������
    public Image horizontalLine; //�������������� ����� �������

    private RectTransform verticalLineTransform; //���������� ������ ������������ ����� �������
    private RectTransform horizontalLineTransform; //���������� ������ �������������� ����� �������

    //���������� ���������� ������ ����������� �������
    void Start()
    {
        verticalLineTransform = verticalLine.GetComponent<RectTransform>();
        horizontalLineTransform = horizontalLine.GetComponent<RectTransform>();
    }

    //���� ���� �� ���������� �� ����� � �� ��������, ��� ��������� �� ����� �������
    //������, ������ ������������� � ���������� �������. ���� ���� �� ����� ��� ��������,
    //�� ���������� ���������
    void LateUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if(!Player.gameOnPause && Player.HP > 0)
        {
            if (Physics.Raycast(ray, Distance, EnemyLayerMask) || Physics.Raycast(ray, Distance, HealCubeMask))
            {
                verticalLine.color = Color.red;
                horizontalLine.color = Color.red;
                verticalLineTransform.sizeDelta = new Vector2(10, 100);
                horizontalLineTransform.sizeDelta = new Vector2(100, 10);

            }
            else
            {
                verticalLine.color = Color.black;
                horizontalLine.color = Color.black;
                verticalLineTransform.sizeDelta = new Vector2(8, 80);
                horizontalLineTransform.sizeDelta = new Vector2(80, 8);
            }
        }
        else
        {
            verticalLine.color = Color.clear;
            horizontalLine.color = Color.clear;
        }
    }
}
