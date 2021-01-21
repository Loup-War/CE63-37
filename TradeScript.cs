using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

using System.IO;
using LitJson;

public class TradeScript : MonoBehaviour
{
    public Text txtamount1, txtamount2, txtamount3, txtamount4, txtamount5, txtamount6, txtamount7;
    public int amount1 = 250, amount2 = 170, amount3 = 100, amount4 = 60, amount5 = 35, amount6 = 10, amount7 = 5;
    public GameObject canvasObject;
    public GameObject player;
    public Inventory inv;
    public float price;
    public float eventwood, eventrice, eventgem, eventcloth, eventarmor, eventiron;

    private JsonData itemData;

    public void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();


        canvasObject.SetActive(false);
    }
    void Update()
    {
        eventwood = inv.eventwood;
        eventrice = inv.eventrice;
        eventgem = inv.eventgem;
        eventcloth = inv.eventcloth;
        eventarmor = inv.eventarmor;
        eventiron = inv.eventiron;
        

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            canvasObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        canvasObject.SetActive(false);
    }

    public void Buying(int id)
    {
        price = (int)itemData[id]["price"];
        if (id == 0 && amount2 >= 1)//ไม้
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventwood)))
            {
                amount2 -= 1;
                txtamount1.text = amount2.ToString()+"/170";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price-(price*eventwood));
            }
        }
        if (id == 1 && amount3 >= 1)//เหล็ก
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventiron)))
            {
                amount3 -= 1;
                txtamount2.text = amount3.ToString() + "/100";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventiron));
            }
        }
        if (id == 2 && amount6 >= 1)//เพรช
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventgem)))
            {
                amount6 -= 1;
                txtamount3.text = amount6.ToString() + "/10";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventgem));
            }
        }
        if (id == 3 && amount5 >= 1)//เกราะ
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventarmor)))
            {
                amount5 -= 1;
                txtamount4.text = amount5.ToString() + "/35";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventarmor));
            }
        }
        if (id == 4 && amount4 >= 1)//ผ้า
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventcloth)))
            {
                amount4 -= 1;
                txtamount5.text = amount4.ToString() + "/60";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventcloth));
            }
        }
        if (id == 5 && amount7 >= 1)//เครื่องเทศ
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)))
            {
                amount7 -= 1;
                txtamount6.text = amount7.ToString() + "/5";
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
            }
        }
        if (id == 6 && amount1 >= 1)//ข้าว
        {
            if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)))
            {
                amount1 -= 1;
                inv.AddItem(id);
                player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
            }
        }
    }
    public void Selling(int id)
    {
        inv.RemoveItem(id);
    }
}
