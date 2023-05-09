using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//����� ��������� � �������� ������� �����
public class ShotClick : MonoBehaviour
{
    public LayerMask EnemyLayerMask; //���� ����������
    public LayerMask HealCubeLayerMask; //���� ���� ���������

    private Ray ray; //���, ������������ �� ������ � ������������ �������
    private RaycastHit hit; //���������� ���������� �� �������, � ������� ����� ���
    private Vector3 PlayerPosition; //������� ������ � ������� �����

    //���������� ���� ��������� ����� � �����������
    private void LateUpdate()
    {
        PlayerPosition = Camera.main.transform.position;

        ray = new Ray(PlayerPosition,
    Camera.main.transform.forward);
    }

    //��� ������� �� �����, �� �������� ������������� ���������� UI, ����������
    //������, � ������� � ���� ������ ����� ���, ���� ������� �������. ���� ���
    //���������, �� ������������ � ������ ����������� ����, ����������� ����������
    //����� ������� � ������� ����� � ���� �����������. ���� ��� ��� ���������, ��
    //����� ������������, ������ ����������� ������������� ���������� �����, � �����
    //����������������� ������������ ���������� �������� ���, ����� ��� ����� ����� ��
    //�������� ������������
    public void OnMouseDown()
    {
        if(!Player.gameOnPause && Player.HP > 0)
        {
            if (Physics.Raycast(ray, out hit, 1000, EnemyLayerMask))
            {
                Player.score += (int)Vector3.Distance(hit.collider.gameObject.transform.position, 
                    PlayerPosition);
                Destroy(hit.collider.gameObject);
            }

            if (Physics.Raycast(ray, out hit, 1000, HealCubeLayerMask))
            {
                Player.score += HealCube.pointsForKill;
                Destroy(hit.collider.gameObject);

                for (int i = 0; i < HealCube.heal && Player.HP < 100; ++i)
                {
                    ++Player.HP;
                }
            }
        }
    }
}
