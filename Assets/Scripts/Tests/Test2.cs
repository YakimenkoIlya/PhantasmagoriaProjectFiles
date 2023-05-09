using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test2 : MonoBehaviour
{
	public GameObject cube;
	private Renderer renderer;
	public LayerMask LayerMask;

	void Start()
	{
		renderer = cube.GetComponent<Renderer>();
	}

	public void OnPointer(PointerEventData pointerEventData)
	{

				renderer.material.color = Color.green;
	}
}
