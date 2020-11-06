using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Slot : MonoBehaviour
{
	public int id;
	private Inventory inv;

	void Start()
	{
		inv = GameObject.Find("Inventory").GetComponent<Inventory>();
	}

}