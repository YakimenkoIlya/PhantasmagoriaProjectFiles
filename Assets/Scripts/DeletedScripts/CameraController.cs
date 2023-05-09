using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ссылка на камеру
    public Camera camera;

    // скорость изменения положения и вращения
    public float speed = 1f;

    void Update()
    {
        // получаем значения углов наклона телефона по осям X, Y и Z
        float pitch = Input.gyro.rotationRate.x * speed;
        float yaw = Input.gyro.rotationRate.y * speed;
        float roll = Input.gyro.rotationRate.z * speed;
        // изменяем положение и вращение камеры
        camera.transform.Rotate(-pitch, yaw, -roll);
    }
}