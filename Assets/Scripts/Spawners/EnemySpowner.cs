using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Класс появления противников в основной игровой сцене
public class EnemySpowner : MonoBehaviour
{
    public GameObject[] enemy; //Массив с игровыми объектами противников
    public float period; //Периодичность появления противников
    public float delay; //Задержка перед первым появлением
    public float YPosition = 16.5f; //Верхняя граница области появления, нижняя равна
    //противоположному числу
    public float XPosition = 14.5f; //Правая граница области появления, левая равна
    //противоположному числу
    public float ZPosition = -4.21f; //Положение области появления по оси Z в
    //игровой сцене

    private int rand; //Индекс случайно выбранного противника для появления

    //Начало действия повторяюшегося метода появления противников
    public void Start()
    {
        InvokeRepeating("SpawnEnemy", delay, period);
    }

    //Случайное определение противника для появления в сцене. Место появления также
    //выбирается случайно в пределах области появления
    private void SpawnEnemy()
    {
       rand = Random.Range(0, enemy.Length);
       Instantiate(enemy[rand], new Vector3(Random.Range(-XPosition, XPosition), Random.Range(-YPosition, YPosition), ZPosition),
            Quaternion.identity);
    }
}
