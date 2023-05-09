using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс куба исцеления
public class HealCube : MonoBehaviour
{
    public float speed; //Скорость кубов исцеления
    public float speedRotation; //Скорость вращения кубов вокруг своей вертикальной оси

    public static int pointsForKill = 50; //Количество очков за попадание по кубу исцеления
    public static int heal = 5; //Количество очков здоровья, восстанавливаемое игроку
    //за попадание по кубу исцеления
    private float startX; //Значение начальной позиции в игровой сцене по оси X
    private float targetX; //Значение конечной позиции в игровой сцене по оси X
    private Vector3 targetPoint; //Конечная позиция куба исцеления в игровой сцене

    //Присвоение переменной startX значения начального положения куба исцеления по оси Х.
    //В качестве значения X для конечной точки выбирается противоположная сторона 
    //области появления
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

    //Проверяется, подлежит ли куб уничтожению. Если это условие не соблюдено,
    //он вращается вокруг своей вертикальной оси и движется к своей конечной точке
    void FixedUpdate()
    {
        CheckForDestroy();

        transform.Rotate(0, speedRotation * Time.deltaTime, 0);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), speed * Time.deltaTime);
        targetPoint = new Vector3(targetX, transform.position.y, transform.position.z);
    }

    //Если куб исцеления достиг своей конечной точки, он уничтожается
    public void CheckForDestroy()
    {
        if(transform.position == targetPoint)
        {
            Destroy(gameObject);
        }
    }
}
