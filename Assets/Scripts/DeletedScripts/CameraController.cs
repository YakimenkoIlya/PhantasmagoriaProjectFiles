using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ������ �� ������
    public Camera camera;

    // �������� ��������� ��������� � ��������
    public float speed = 1f;

    void Update()
    {
        // �������� �������� ����� ������� �������� �� ���� X, Y � Z
        float pitch = Input.gyro.rotationRate.x * speed;
        float yaw = Input.gyro.rotationRate.y * speed;
        float roll = Input.gyro.rotationRate.z * speed;
        // �������� ��������� � �������� ������
        camera.transform.Rotate(-pitch, yaw, -roll);
    }
}