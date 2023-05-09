using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ласс противника
public class EnemyScript : MonoBehaviour
{
    public float stoppingDistance; //ћинимальна€ дистанци€ между противником и
    //игроком
    public int oneTimeDamage; //≈диноразовый урон
    public float period; //ѕериод между нанесени€ми урона

    private bool isTakingDamage; //Ќанесение урона противником в данный момент
    private static Vector3 PlayerPosition; //ѕозици€ камеры в игровой сцене
    public static float speed = 8; //Ќачальна€ скорость противников
    public static float defaultSpeed = speed; //—корость противников по умолчанию

    //»зменение положени€ противников, чтобы они при по€влении поворачивались к
    //игроку правильной стороной
    void Start()
    {
        transform.Rotate(Vector3.up * 180);
    }

    //≈сли рассто€ние между камерой и противником меньше минимальной дистанции,
    //последний движетс€ в сторону первого. ≈сли нет, враг начинает наносить урон
    void Update()
    {
        PlayerPosition = Camera.main.transform.position;

        if (Vector3.Distance(transform.position, PlayerPosition) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards
                (transform.position, PlayerPosition, speed * Time.deltaTime);

            isTakingDamage = false;
        }
        else
        {
            transform.position = this.transform.position;
            
            if(Player.HP > 0)
            {
                if (!isTakingDamage)
                {
                    InvokeRepeating("MakeDamage", 0, period);
                    isTakingDamage = true;
                }
            }
            else
            {
                CancelInvoke("MakeDamage");
            }
        }
    }

    //Ќанесение урона
    private void MakeDamage()
    {
        Player.HP -= oneTimeDamage;
    }
}
