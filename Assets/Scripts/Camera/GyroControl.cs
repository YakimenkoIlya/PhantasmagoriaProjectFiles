using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс поворота камеры в игровой в сцене в соответствии с изменениями положения 
//телефона в пространстве
public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled; //Наличие включенного гироскопа
    private Gyroscope gyro; // Данные гироскопа
    private GameObject cameraContainer; // Контейнер для камеры в игровой сцене
    private Quaternion rot; // Поворот камеры в игровой сцене

    //Назначение контейнера камере
    void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();
    }

    //Проверка устройства на наличие включенного гироскопа
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    //Изменения положения камеры в сцене синхронно с изменениями положения телефона
    private void Update()
    {
        transform.localRotation = gyro.attitude * rot;
    }
}
