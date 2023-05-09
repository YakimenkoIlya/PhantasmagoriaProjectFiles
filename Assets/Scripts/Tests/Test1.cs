using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test1 : MonoBehaviour/*, IPointerClickHandler*/
{
    public GameObject cube;
    private Renderer renderer;
	public LayerMask LayerMask;

	void Start()
    {
        renderer = cube.GetComponent<Renderer>();
    }

	public void OnMouseDown()
	{
        if (renderer.material.color == Color.green)
        {
            renderer.material.color = Color.yellow;
        }
        else { renderer.material.color = Color.green; }
    }
}
