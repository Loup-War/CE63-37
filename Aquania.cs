using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System.IO;
using LitJson;

public class Aquania : MonoBehaviour
{
    PhotonView pv;
    public Text txtamount1, txtamount2, txtamount3, txtamount4, txtamount5, txtamount6, txtamount7;
    public int amountlaza1 = 250, amountlaza2 = 170, amountlaza3 = 100, amountlaza4 = 60, amountlaza5 = 35, amountlaza6 = 10, amountlaza7 = 5;
    public int amountshopp1 = 250, amountshopp2 = 170, amountshopp3 = 100, amountshopp4 = 60, amountshopp5 = 35, amountshopp6 = 10, amountshopp7 = 5;
    public int amountnef1 = 250, amountnef2 = 170, amountnef3 = 100, amountnef4 = 60, amountnef5 = 35, amountnef6 = 10, amountnef7 = 5;
    public int buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7;
    public GameObject cityui;
    public GameObject cityshop;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public Inventory inv;
    public float price;
    public float eventwood, eventrice, eventgem, eventcloth, eventarmor, eventiron;
    public bool aquaniaevent = false;
    public bool aquania = false;
    public bool lazadioshop = false, shoppigashop = false, nefixiashop = false;
    public bool laza, shoppi, nefi;

    private JsonData itemData;

    public void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        pv = PhotonView.Get(this);
        cityui.SetActive(false);

    }
    void Update()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");

    }
    void OnTriggerEnter(Collider col)
    {
        if (player1.GetComponent<PhotonView>().IsMine == true)
        {
            player = GameObject.FindGameObjectWithTag("Player1");
        }
        else if (player2.GetComponent<PhotonView>().IsMine == true)
        {
            player = GameObject.FindGameObjectWithTag("Player2");
        }
        else if (player3.GetComponent<PhotonView>().IsMine == true)
        {
            player = GameObject.FindGameObjectWithTag("Player3");
        }
        else if (player4.GetComponent<PhotonView>().IsMine == true)
        {
            player = GameObject.FindGameObjectWithTag("Player4");
        }
        if (col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(true);
            aquania = true;
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(true);
            aquania = true;
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(true);
            aquania = true;
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(true);
            aquania = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if ((col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true))
        {
            cityui.SetActive(false);
            aquania = false;
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            aquania = false;
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            aquania = false;
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            aquania = false;
        }
    }

    public void BuyingLazadios(int id)
    {
        price = (int)itemData[id]["price"];
        if (aquania == true && lazadioshop == true)
        {
            if (id == 0 && amountlaza2 >= 1)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventwood)) && inv.weightall + 2 <= 300)
                {
                    laza = true;
                    buyitem1 = 1; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountlaza2.ToString() + "/170";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventwood));
                }
            }
            if (id == 1 && amountlaza3 >= 1)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventiron)) && inv.weightall + 4 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 1; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountlaza3.ToString() + "/100";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventiron));
                }
            }
            if (id == 2 && amountlaza6 >= 1)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventgem)) && inv.weightall + 10 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 1; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountlaza6.ToString() + "/10";
                    inv.AddItem(id);

                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventgem));
                }
            }
            if (id == 3 && amountlaza5 >= 1)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventarmor)) && inv.weightall + 12 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 1; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountlaza5.ToString() + "/35";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventarmor));
                }
            }
            if (id == 4 && amountlaza4 >= 1)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventcloth)) && inv.weightall + 8 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 1; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountlaza4.ToString() + "/60";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventcloth));
                }
            }
            if (id == 5 && amountlaza7 >= 1)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 20 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 1; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountlaza7.ToString() + "/5";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }
            if (id == 6 && amountlaza1 >= 1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 1 <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 1;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountlaza1.ToString() + "/250";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }


        }
    }
    public void BuyingShoppiga(int id)
    {
        price = (int)itemData[id]["price"];
        if (aquania == true && shoppigashop == true)
        {
            if (id == 0 && amountshopp2 >= 1)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventwood)) && inv.weightall + 2 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 1; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountshopp2.ToString() + "/170";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventwood));
                }
            }
            if (id == 1 && amountshopp3 >= 1)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventiron)) && inv.weightall + 4 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 1; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountshopp3.ToString() + "/100";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventiron));
                }
            }
            if (id == 2 && amountshopp6 >= 1)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventgem)) && inv.weightall + 10 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 1; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountshopp6.ToString() + "/10";
                    inv.AddItem(id);

                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventgem));
                }
            }
            if (id == 3 && amountshopp5 >= 1)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventarmor)) && inv.weightall + 12 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 1; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountshopp5.ToString() + "/35";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventarmor));
                }
            }
            if (id == 4 && amountshopp4 >= 1)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventcloth)) && inv.weightall + 8 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 1; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountshopp4.ToString() + "/60";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventcloth));
                }
            }
            if (id == 5 && amountshopp7 >= 1)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 20 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 1; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountshopp7.ToString() + "/5";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }
            if (id == 6 && amountshopp1 >= 1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 1 <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 1;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountshopp1.ToString() + "/250";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }


        }
    }
    public void BuyingNefixia(int id)
    {
        price = (int)itemData[id]["price"];
        if (aquania == true && nefixiashop == true)
        {
            if (id == 0 && amountnef2 >= 1)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventwood)) && inv.weightall + 2 <= 300)
                {
                    nefi = true;
                    buyitem1 = 1; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountnef2.ToString() + "/170";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventwood));
                }
            }
            if (id == 1 && amountnef3 >= 1)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventiron)) && inv.weightall + 4 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 1; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountnef3.ToString() + "/100";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventiron));
                }
            }
            if (id == 2 && amountnef6 >= 1)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventgem)) && inv.weightall + 10 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 1; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountnef6.ToString() + "/10";
                    inv.AddItem(id);

                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventgem));
                }
            }
            if (id == 3 && amountnef5 >= 1)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventarmor)) && inv.weightall + 12 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 1; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountnef5.ToString() + "/35";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventarmor));
                }
            }
            if (id == 4 && amountnef4 >= 1)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventcloth)) && inv.weightall + 8 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 1; buyitem6 = 0; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountnef4.ToString() + "/60";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventcloth));
                }
            }
            if (id == 5 && amountnef7 >= 1)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 20 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 1; buyitem7 = 0;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountnef7.ToString() + "/5";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }
            if (id == 6 && amountnef1 >= 1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (price - (price * eventrice)) && inv.weightall + 1 <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 1;
                    aquaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountnef1.ToString() + "/250";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price - (price * eventrice));
                }
            }
        }
    }

    public void Selling(int id)
    {
        if (aquaniaevent == true && aquania == true) 
        { 
            inv.aquaniaEvent = true;
            inv.eventrice = eventrice;
            inv.eventiron = eventiron;
            inv.eventwood = eventwood;
            inv.eventcloth = eventcloth;
            inv.eventarmor = eventarmor;
            inv.RemoveItem(id);
        }
        else if(aquaniaevent == false && aquania == true) { 
            inv.RemoveItem(id); 
        }
    }
    public void openlazadiosshop()
    {
        if (aquania == true)
        {
            cityshop.SetActive(true);
            lazadioshop = true;
            txtamount1.text = amountlaza2.ToString() + "/170";
            txtamount2.text = amountlaza3.ToString() + "/100";
            txtamount3.text = amountlaza6.ToString() + "/10";
            txtamount4.text = amountlaza5.ToString() + "/35";
            txtamount5.text = amountlaza4.ToString() + "/60";
            txtamount6.text = amountlaza7.ToString() + "/5";
            txtamount7.text = amountlaza1.ToString() + "/250";
        }
    }
    public void openshoppigashop()
    {
        if (aquania == true)
        {
            cityshop.SetActive(true);
            shoppigashop = true;
            txtamount1.text = amountshopp2.ToString() + "/170";
            txtamount2.text = amountshopp3.ToString() + "/100";
            txtamount3.text = amountshopp6.ToString() + "/10";
            txtamount4.text = amountshopp5.ToString() + "/35";
            txtamount5.text = amountshopp4.ToString() + "/60";
            txtamount6.text = amountshopp7.ToString() + "/5";
            txtamount7.text = amountshopp1.ToString() + "/250";
        }
    }
    public void opennefixiashop()
    {
        if (aquania == true)
        {
            cityshop.SetActive(true);
            nefixiashop = true;
            txtamount1.text = amountnef2.ToString() + "/170";
            txtamount2.text = amountnef3.ToString() + "/100";
            txtamount3.text = amountnef6.ToString() + "/10";
            txtamount4.text = amountnef5.ToString() + "/35";
            txtamount5.text = amountnef4.ToString() + "/60";
            txtamount6.text = amountnef7.ToString() + "/5";
            txtamount7.text = amountnef1.ToString() + "/250";
        }
    }
    public void closeshop()
    {
        cityshop.SetActive(false);
        lazadioshop = false;
        shoppigashop = false;
        nefixiashop = false;
        buyitem1 = 0;
        buyitem2 = 0;
        buyitem3 = 0;
        buyitem4 = 0;
        buyitem5 = 0;
        buyitem6 = 0;
        buyitem7 = 0;
    }


    void aquaniacharing(bool lazadi, bool shoppic, bool nefixi)
    {
        if (lazadi == true)
        {
            pv.RPC("aquanialazadio", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
        else if (shoppic == true)
        {
            pv.RPC("aquaniashoppica", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
        else if (nefixi == true)
        {
            pv.RPC("aquanianefixia", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
    }

    [PunRPC]
    void aquanialazadio(int order1, int order2, int order3, int order4, int order5, int order6, int order7)
    {
        amountlaza2 = amountlaza2 - order1;
        amountlaza3 = amountlaza3 - order2;
        amountlaza6 = amountlaza6 - order3;
        amountlaza5 = amountlaza5 - order4;
        amountlaza4 = amountlaza4 - order5;
        amountlaza7 = amountlaza7 - order6;
        amountlaza1 = amountlaza1 - order7;

    }

    [PunRPC]
    void aquaniashoppica(int order1, int order2, int order3, int order4, int order5, int order6, int order7)
    {
        amountshopp2 -= order1;
        amountshopp3 -= order2;
        amountshopp6 -= order3;
        amountshopp5 -= order4;
        amountshopp4 -= order5;
        amountshopp7 -= order6;
        amountshopp1 -= order7;
    }

    [PunRPC]
    void aquanianefixia(int order1, int order2, int order3, int order4, int order5, int order6, int order7)
    {
        amountnef2 -= order1;
        amountnef3 -= order1;
        amountnef6 -= order3;
        amountnef5 -= order4;
        amountnef4 -= order5;
        amountnef7 -= order6;
        amountnef1 -= order7;
    }
}
