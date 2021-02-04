
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.IO;
using LitJson;


public class PriceSellText : MonoBehaviour
{
    public float price;
    public float guildDesir;
    public float guildLoup;
    public float guildSerment;
    public float guildAsrial;
    public float guildOrion;
    public float totalprice;
    public Inventory inv;
    public int id;
    public GameObject shafferbonut;
    //public Inventory inv;
    private JsonData itemData;
    Text priceText;
    void Start()
    {
        //inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        priceText = GetComponent<Text>();
        priceID(id);
        guildDesir = inv.guildDesir;
        guildLoup = inv.guildLoup;
        guildSerment = inv.guildSerment;
        guildAsrial = inv.guildAsrial;
        guildOrion = inv.guildOrion;
        totalprice = price;

        //myString = totalprice.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
        totalprice = price + (price * (shafferbonut.GetComponent<Chafferfuntion>().bonutsell));
        priceText.text = " " + totalprice+"G";
    }
    public void priceID(int ID)
    {
        price = (int)itemData[ID]["pricesell"];
    }
}