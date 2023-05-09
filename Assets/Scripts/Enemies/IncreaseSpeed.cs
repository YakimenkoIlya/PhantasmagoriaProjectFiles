using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ласс посто€нного повышени€ скорости противников
public class IncreaseSpeed : MonoBehaviour
{
    public float period; //ѕериодичность повышени€ скорости
    public float increase; //«начение повышени€ скорости

    //Ќачало действи€ повтор€юшегос€ метода повышени€ скорости противников
    void Start()
    {
        InvokeRepeating("SpeedUp", period, period);
    }

    //ѕовышение скорости противников
    public void SpeedUp()
    {
        EnemyScript.speed += increase;
    }
}
