using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickHandlerScript : MonoBehaviour
{
    public Image HorizontalLine;
    public Image VerticalLine;

    private Animator HLAnimator;
    private Animator VLAnimator;

    private RectTransform horizontalLineTransform;
    void Start()
    {
        horizontalLineTransform = HorizontalLine.GetComponent<RectTransform>();
        HLAnimator = HorizontalLine.GetComponent<Animator>();
        //OnMouseDown();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            horizontalLineTransform.sizeDelta = new Vector2(200, 200);
        }
    }

    private void OnMouseDown()
    {
        //HLAnimator.SetTrigger("HorizontalLineAimTrigger");
        print("1");
        horizontalLineTransform.sizeDelta = new Vector2(200,200);
    }
}
