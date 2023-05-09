using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//Класс выстрелов в основной игровой сцене
public class ShotClick : MonoBehaviour
{
    public LayerMask EnemyLayerMask; //Слой противника
    public LayerMask HealCubeLayerMask; //Слой куба исцеления

    private Ray ray; //Луч, направленный от камеры в определенную сторону
    private RaycastHit hit; //Получатель информации об объекте, в который попал луч
    private Vector3 PlayerPosition; //Позиция игрока в игровой сцене

    //Присвоение лучу начальной точки и направления
    private void LateUpdate()
    {
        PlayerPosition = Camera.main.transform.position;

        ray = new Ray(PlayerPosition,
    Camera.main.transform.forward);
    }

    //При нажатии на экран, не занятого кликабельными элементами UI, выявляется
    //объект, в который в этот момент попал луч, если таковой имеется. Если это
    //противник, он уничтожается и игроку начисляются очки, соразмерные расстоянию
    //между камерой в игровой сцене и этим противником. Если это куб исцеления, он
    //также уничтожается, игроку начисляется фиксированное количество очков, а также
    //восстанавливается определенное количество здоровья так, чтобы его общий объем не
    //превышал максимальный
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
