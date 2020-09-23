using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeScript : MonoBehaviour
{

    public GameObject CanvasObject;
    void Start()
    {
        CanvasObject.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanvasObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanvasObject.SetActive(false);
        }
    }


}
