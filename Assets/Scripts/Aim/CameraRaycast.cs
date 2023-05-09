using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Класс прицела в основной игровой сцене
public class CameraRaycast : MonoBehaviour
{
    public float Distance; //Дистанция между камерой и противником
    public LayerMask EnemyLayerMask; //Слой противника
    public LayerMask HealCubeMask; //Слой куба исцеления
    public Image verticalLine; //Вертикальная линия прицела
    public Image horizontalLine; //Горизонтальная линия прицела

    private RectTransform verticalLineTransform; //Физические данные вертикальной линии прицела
    private RectTransform horizontalLineTransform; //Физические данные горизонтальной линии прицела

    //Присвоение физических данных компонентам прицела
    void Start()
    {
        verticalLineTransform = verticalLine.GetComponent<RectTransform>();
        horizontalLineTransform = horizontalLine.GetComponent<RectTransform>();
    }

    //Если игра не поставлена на паузу и не окончена, при наведении на любой игровой
    //объект, прицел увеличивается и становится красным. Если игра на паузе или окончена,
    //он становится невидимым
    void LateUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if(!Player.gameOnPause && Player.HP > 0)
        {
            if (Physics.Raycast(ray, Distance, EnemyLayerMask) || Physics.Raycast(ray, Distance, HealCubeMask))
            {
                verticalLine.color = Color.red;
                horizontalLine.color = Color.red;
                verticalLineTransform.sizeDelta = new Vector2(10, 100);
                horizontalLineTransform.sizeDelta = new Vector2(100, 10);

            }
            else
            {
                verticalLine.color = Color.black;
                horizontalLine.color = Color.black;
                verticalLineTransform.sizeDelta = new Vector2(8, 80);
                horizontalLineTransform.sizeDelta = new Vector2(80, 8);
            }
        }
        else
        {
            verticalLine.color = Color.clear;
            horizontalLine.color = Color.clear;
        }
    }
}
