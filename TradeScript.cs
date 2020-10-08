using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TradeScript : MonoBehaviour
{
    public Button button;
    public GameObject CanvasObject;
    public GameObject player;


    public int price;

    public void Start()
    {
        CanvasObject.SetActive(false);
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    public void TaskOnClick()
    {
        Sell();
    }
    public void Sell()
    {
        if (player.GetComponent<PlayerMoney>().money >= price)
        {
            player.GetComponent<PlayerMoney>().money -= price;
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanvasObject.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanvasObject.SetActive(false);
        }
    }
}
