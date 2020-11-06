
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.IO;
using LitJson;


public class PriceText : MonoBehaviour
{
    public float price;
    public float guild;
    public float totalprice;
    public Inventory inv;
    public int id;
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
        guild = inv.guild;
        totalprice = price - (price * guild);
        //myString = totalprice.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        priceText.text = " " + totalprice;
    }
    public void priceID(int ID)
    {
        price = (int)itemData[ID]["price"];
    }
}