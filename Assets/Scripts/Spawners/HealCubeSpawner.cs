using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс появления кубов исцеления в основной игровой сцене
public class HealCubeSpawner : MonoBehaviour
{
    public GameObject[] healCube; //Массив с игровыми объектами кубов исцеления
    public float period; //Периодичность появления кубов исцеления
    public float delay; //Задержка перед первым появлением
    public float YPosition = 16.5f; //Верхняя граница области появления, нижняя
    //равна противоположному числу
    public float ZPosition = -4.21f; //Положение области появления по оси Z в
    //игровой сцене

    public static float maxRightPosition = 14.5f; //Правая граница области появления,
    //левая равна противоположному числу
    private int rand; //Индекс случайно выбранного куба исцеления для появления
    private float startPositionX; //Значение по оси X начальной позиции куба исцеления
    private int positionVariant; //Вариант значения по оси X начальной позиции куба исцеления

    //Начало действия повторяюшегося метода появления кубов исцеления
    void Start()
    {
        InvokeRepeating("SpawnHealCube", delay, period);
    }

    //Случайным образом определяется вариант для значения по оси X начальной
    //позиции куба исцеления. В одном из двух случаев это значение равно правой
    //границе области появления, в другом - левой. После определения варианта куб
    //исцеления появляется на позиции, где Х опредлен самим вариантом, Y выбран
    //случайно в пределах верней и нижней границ области появления, а Z равен данному
    //значению области исцеления
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
