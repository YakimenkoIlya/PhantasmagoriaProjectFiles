using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GyroCamera : MonoBehaviour
{
    private float initialYAngle = 0f;
    private float appliedGyroYAngle = 0f;
    private float calibrationYAngle = 0f;

    public bool EnableAr;

    Quaternion _cameraRotation;

    private void Start()
    {
        // ������ ��������� ������
        _cameraRotation = transform.rotation;
    }

    private void Update()
    {
        if (EnableAr /*&& SystemInfo.supportsGyroscope*/)
        {
            ApplyGyroRotation();
            ApplyCalibration();
        }
    }

    // ����� ��� ������� ������, �������� ��� ������� ������ (� ���� ����������
    // ����� ������ �� �����������)

    public void StartAr()
    {
        //if (!SystemInfo.supportsGyroscope)
            //return;

        if (!EnableAr)
        {
            Application.targetFrameRate = 60;
            initialYAngle = transform.eulerAngles.y;
            CalibrateYAngle();
            EnableAr = true;
        }
        else
        {
            EnableAr = false;
            transform.rotation = _cameraRotation;
        }
    }

    public void CalibrateYAngle()
    {
        calibrationYAngle = appliedGyroYAngle - initialYAngle; 
        //�������� ���� y, ���� �� �� ��� ����� 0 �� ����� ��������������
    }

    void ApplyGyroRotation()
    {
        transform.rotation = /*GyroToUnity*/(Input.gyro.attitude) /* * new Quaternion(-1f, -1f, -1f, -1f)*/; //IOS (* new Quaternion ������� ���)

        transform.Rotate(0f, 0f, 180f, Space.Self);
        transform.Rotate(90f, 180f, 0f, Space.World);
        appliedGyroYAngle = transform.eulerAngles.y;
    }

    void ApplyCalibration()
    {
        transform.Rotate(0f, -calibrationYAngle, 0f, Space.World);
    }

    //private Quaternion GyroToUnity(Quaternion q) //������� ���
    //{
     //   return new Quaternion(q.x, -q.y, q.z, -q.w);
    //}
}

