using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System.IO;
using LitJson;

public class Remania : MonoBehaviour
{
    PhotonView pv;
    public GameObject debugNotSell;
    public Text txtamount1, txtamount2, txtamount3, txtamount4, txtamount5, txtamount6, txtamount7;
    public float amountlaza1 = 250, amountlaza2 = 170, amountlaza3 = 100, amountlaza4 = 60, amountlaza5 = 35, amountlaza6 = 10, amountlaza7 = 5;
    public float amountshopp1 = 250, amountshopp2 = 170, amountshopp3 = 100, amountshopp4 = 60, amountshopp5 = 35, amountshopp6 = 10, amountshopp7 = 5;
    public float amountnef1 = 250, amountnef2 = 170, amountnef3 = 100, amountnef4 = 60, amountnef5 = 35, amountnef6 = 10, amountnef7 = 5;
    public float buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7;
    public Text price1, price2, price3, price4, price5, price6, price7;
    public GameObject cityui;
    public GameObject cityshop, debugcity;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public GameObject kingEvent;
    public GameObject mainEventsys;

    public Text valuemoney1, valuemoney2, valuemoney3, valuemoney4, valuemoney5, valuemoney6, valuemoney7, valuemoney8, valuemoney9, valuemoney10, valuemoney11, valuemoney12;
    public Text weit1, weit2, weit3, weit4, weit5, weit6, weit7, weit8, weit9, weit10, weit11, weit12;


    public bool remaniakingEvent;

    public Inventory inv;
    public float price;
    public float eventwood, eventrice, eventgem, eventcloth, eventarmor, eventiron;
    public bool remaniaevent = false;
    public bool remania = false;
    public bool remaniainv = false;
    public bool lazadioshop = false, shoppigashop = false, nefixiashop = false;
    public bool laza, shoppi, nefi;

    private JsonData itemData;

    public void Start()
    {
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
        if (player == null)
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
        }
        Cooldownitem();
        if (remania == true)
        {
            valuemoney1.text = (inv.valuee * (20 + (20 * eventwood))).ToString() + " G";
            valuemoney2.text = (inv.valuee * (50 + (50 * eventiron))).ToString() + " G";
            valuemoney3.text = (inv.valuee * (300 + (300 * eventgem))).ToString() + " G";
            valuemoney4.text = (inv.valuee * (260 + (260 * eventarmor))).ToString() + " G";
            valuemoney5.text = (inv.valuee * (115 + (115 * eventcloth))).ToString() + " G";
            valuemoney6.text = (inv.valuee * 500).ToString() + " G";
            valuemoney7.text = (inv.valuee * (7 + (7 * eventrice))).ToString() + " G";

            weit1.text = (inv.valuee * 2).ToString() + " Kg";
            weit2.text = (inv.valuee * 4).ToString() + " Kg";
            weit3.text = (inv.valuee * 10).ToString() + " Kg";
            weit4.text = (inv.valuee * 12).ToString() + " Kg";
            weit5.text = (inv.valuee * 8).ToString() + " Kg";
            weit6.text = (inv.valuee * 20).ToString() + " Kg";
            weit7.text = (inv.valuee * 1).ToString() + " Kg";
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true)
        {
            if (player1.GetComponent<PlayMoment>().remaniapass == false)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayerMoney>().money -= 300;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
                debugcity.SetActive(true);
            }
            else if (player1.GetComponent<PlayMoment>().remaniapass == true)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
            }
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            if (player2.GetComponent<PlayMoment>().remaniapass == false)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayerMoney>().money -= 300;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
                debugcity.SetActive(true);
            }
            else if (player2.GetComponent<PlayMoment>().remaniapass == true)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
            }
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            if (player3.GetComponent<PlayMoment>().remaniapass == false)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayerMoney>().money -= 300;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
                debugcity.SetActive(true);
            }
            else if (player3.GetComponent<PlayMoment>().remaniapass == true)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
            }
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            if (player4.GetComponent<PlayMoment>().remaniapass == false)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayerMoney>().money -= 300;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
                debugcity.SetActive(true);
            }
            else if (player4.GetComponent<PlayMoment>().remaniapass == true)
            {
                cityui.SetActive(true);
                remania = true;
                player.GetComponent<PlayMoment>().visitbefore = "remania";
            }
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            remania = false;
            kingEvent.SetActive(false);
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            remania = false;
            kingEvent.SetActive(false);
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            remania = false;
            kingEvent.SetActive(false);
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            cityui.SetActive(false);
            remania = false;
            kingEvent.SetActive(false);
        }
    }

    public void BuyingLazadios(int id)
    {
        if (remania == true && lazadioshop == true)
        {
            if (id == 0 && inv.valuee <= amountlaza2)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (20 - (20 * eventwood))) && inv.weightall + (inv.valuee * 2) <= 300)
                {
                    laza = true;
                    buyitem1 = inv.valuee; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountlaza2.ToString() + "/170";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(20 + (20 * eventwood));
                    }
                }
            }
            if (id == 1 && inv.valuee <= amountlaza3)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (50 - (50 * eventiron))) && inv.weightall + (inv.valuee * 4) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = inv.valuee; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountlaza3.ToString() + "/100";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(50 + (50 * eventiron));
                    }
                }
            }
            if (id == 2 && inv.valuee <= amountlaza6)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (300 - (300 * eventgem))) && inv.weightall + (inv.valuee * 10) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = inv.valuee; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountlaza6.ToString() + "/10";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(300 + (300 * eventgem));
                    }
                }
            }
            if (id == 3 && inv.valuee <= amountlaza5)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (260 - (260 * eventarmor))) && inv.weightall + (inv.valuee * 12) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = inv.valuee; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountlaza5.ToString() + "/35";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(260 + (260 * eventarmor));
                    }
                }
            }
            if (id == 4 && inv.valuee <= amountlaza4)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (115 - (115 * eventcloth))) && inv.weightall + (inv.valuee * 8) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = inv.valuee; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountlaza4.ToString() + "/60";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(115 + (115 * eventcloth));
                    }
                }
            }
            if (id == 5 && inv.valuee <= amountlaza7)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * 500) && inv.weightall + (inv.valuee * 20) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = inv.valuee; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountlaza7.ToString() + "/5";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(500);
                    }
                }
            }
            if (id == 6 && inv.valuee <= amountlaza1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (7 - (7 * eventrice))) && inv.weightall + (inv.valuee * 1) <= 300)
                {
                    laza = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = inv.valuee;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountlaza1.ToString() + "/250";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(7 + (7 * eventrice));
                    }
                }
            }
            inv.valuee = 1;
            laza = false;
            player.GetComponent<PlayMoment>().visitBuybefore = "remania";
        }
    }
    public void BuyingShoppiga(int id)
    {
        if (remania == true && shoppigashop == true)
        {
            if (id == 0 && inv.valuee <= amountshopp2)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (20 - (20 * eventwood))) && inv.weightall + (inv.valuee * 2) <= 300)
                {
                    shoppi = true;
                    buyitem1 = inv.valuee; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountshopp2.ToString() + "/170";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(20 + (20 * eventwood));
                    }
                }
            }
            if (id == 1 && inv.valuee <= amountshopp3)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (50 - (50 * eventiron))) && inv.weightall + (inv.valuee * 4) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = inv.valuee; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountshopp3.ToString() + "/100";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(50 + (50 * eventiron));
                    }
                }
            }
            if (id == 2 && inv.valuee <= amountshopp6)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (300 - (300 * eventgem))) && inv.weightall + (inv.valuee * 10) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = inv.valuee; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountshopp6.ToString() + "/10";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(300 + (300 * eventgem));
                    }
                }
            }
            if (id == 3 && inv.valuee <= amountshopp5)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (260 - (260 * eventarmor))) && inv.weightall + (inv.valuee * 12) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = inv.valuee; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountshopp5.ToString() + "/35";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(260 + (260 * eventarmor));
                    }
                }
            }
            if (id == 4 && inv.valuee <= amountshopp4)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (115 - (115 * eventcloth))) && inv.weightall + (inv.valuee * 8) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = inv.valuee; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountshopp4.ToString() + "/60";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(115 + (115 * eventcloth));
                    }
                }
            }
            if (id == 5 && inv.valuee <= amountshopp7)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * 500) && inv.weightall + (inv.valuee * 20) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = inv.valuee; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountshopp7.ToString() + "/5";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(500);
                    }
                }
            }
            if (id == 6 && inv.valuee <= amountshopp1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (7 - (7 * eventrice))) && inv.weightall + (inv.valuee * 1) <= 300)
                {
                    shoppi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = inv.valuee;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountshopp1.ToString() + "/250";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(7 + (7 * eventrice));
                    }
                }
            }
            inv.valuee = 1;
            shoppi = false;
            player.GetComponent<PlayMoment>().visitBuybefore = "remania";
        }
    }
    public void BuyingNefixia(int id)
    {
        if (remania == true && nefixiashop == true)
        {
            if (id == 0 && inv.valuee <= amountnef2)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (20 - (20 * eventwood))) && inv.weightall + (inv.valuee * 2) <= 300)
                {
                    nefi = true;
                    buyitem1 = inv.valuee; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount1.text = amountnef2.ToString() + "/170";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(20 + (20 * eventwood));
                    }
                }
            }
            if (id == 1 && inv.valuee <= amountnef3)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (50 - (50 * eventiron))) && inv.weightall + (inv.valuee * 4) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = inv.valuee; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount2.text = amountnef3.ToString() + "/100";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(50 + (50 * eventiron));
                    }
                }
            }
            if (id == 2 && inv.valuee <= amountnef6)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (300 - (300 * eventgem))) && inv.weightall + (inv.valuee * 10) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = inv.valuee; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount3.text = amountnef6.ToString() + "/10";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(300 + (300 * eventgem));
                    }
                }
            }
            if (id == 3 && inv.valuee <= amountnef5)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (260 - (260 * eventarmor))) && inv.weightall + (inv.valuee * 12) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = inv.valuee; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount4.text = amountnef5.ToString() + "/35";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(260 + (260 * eventarmor));
                    }
                }
            }
            if (id == 4 && inv.valuee <= amountnef4)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (115 - (115 * eventcloth))) && inv.weightall + (inv.valuee * 8) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = inv.valuee; buyitem6 = 0; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount5.text = amountnef4.ToString() + "/60";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(115 + (115 * eventcloth));
                    }
                }
            }
            if (id == 5 && inv.valuee <= amountnef7)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * 500) && inv.weightall + (inv.valuee * 20) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = inv.valuee; buyitem7 = 0;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount6.text = amountnef7.ToString() + "/5";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(500);
                    }
                }
            }
            if (id == 6 && inv.valuee <= amountnef1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (7 - (7 * eventrice))) && inv.weightall + (inv.valuee * 1) <= 300)
                {
                    nefi = true;
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = inv.valuee;
                    remaniacharing(laza, shoppi, nefi);
                    txtamount7.text = amountnef1.ToString() + "/250";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(7 - (7 * eventrice));
                    }
                }
            }
            inv.valuee = 1;
            nefi = false;
            player.GetComponent<PlayMoment>().visitBuybefore = "remania";
        }
    }

    public void Selling(int id)
    {
        if (remaniaevent == true && remania == true && player.GetComponent<PlayMoment>().visitBuybefore != "remania")
        {
            inv.remaniaEvent = true;
            inv.eventrice = eventrice;
            inv.eventiron = eventiron;
            inv.eventwood = eventwood;
            inv.eventcloth = eventcloth;
            inv.eventarmor = eventarmor;
            inv.RemoveItem(id);
        }
        else if (remaniaevent == false && remania == true && player.GetComponent<PlayMoment>().visitBuybefore != "remania")
        {
            inv.RemoveItem(id);
        }
        else if (player.GetComponent<PlayMoment>().visitBuybefore == "remania")
        {
            debugNotSell.SetActive(true);
        }
    }

    public void Sellingall(int id)
    {
        if (remaniaevent == true && remania == true && player.GetComponent<PlayMoment>().visitBuybefore != "remania")
        {
            inv.remaniaEvent = true;
            inv.eventrice = eventrice;
            inv.eventiron = eventiron;
            inv.eventwood = eventwood;
            inv.eventcloth = eventcloth;
            inv.eventarmor = eventarmor;
            inv.RemoveItemall(id);
        }
        else if (remaniaevent == false && remania == true && player.GetComponent<PlayMoment>().visitBuybefore != "remania")
        {
            inv.RemoveItemall(id);
        }
        else if (player.GetComponent<PlayMoment>().visitBuybefore == "remania")
        {
            debugNotSell.SetActive(true);
        }
    }

    public void openlazadiosshop()
    {
        if (remania == true)
        {
            cityshop.SetActive(true);
            lazadioshop = true;
            price1.text = (20 + (20 * eventwood)).ToString();
            price2.text = (50 + (50 * eventiron)).ToString();
            price3.text = (300 + (300 * eventgem)).ToString();
            price4.text = (260 + (260 * eventarmor)).ToString();
            price5.text = (115 + (115 * eventcloth)).ToString();
            price6.text = 500.ToString();
            price7.text = (7 + (7 * eventrice)).ToString();
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
        if (remania == true)
        {
            cityshop.SetActive(true);
            shoppigashop = true;
            price1.text = (20 + (20 * eventwood)).ToString();
            price2.text = (50 + (50 * eventiron)).ToString();
            price3.text = (300 + (300 * eventgem)).ToString();
            price4.text = (260 + (260 * eventarmor)).ToString();
            price5.text = (115 + (115 * eventcloth)).ToString();
            price6.text = 500.ToString();
            price7.text = (7 + (7 * eventrice)).ToString();
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
        if (remania == true)
        {
            cityshop.SetActive(true);
            nefixiashop = true;
            price1.text = (20 + (20 * eventwood)).ToString();
            price2.text = (50 + (50 * eventiron)).ToString();
            price3.text = (300 + (300 * eventgem)).ToString();
            price4.text = (260 + (260 * eventarmor)).ToString();
            price5.text = (115 + (115 * eventcloth)).ToString();
            price6.text = 500.ToString();
            price7.text = (7 + (7 * eventrice)).ToString();
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
        inv.valuee = 1;
        buyitem1 = 0;
        buyitem2 = 0;
        buyitem3 = 0;
        buyitem4 = 0;
        buyitem5 = 0;
        buyitem6 = 0;
        buyitem7 = 0;
    }


    void remaniacharing(bool lazadi, bool shoppic, bool nefixi)
    {
        if (lazadi == true)
        {
            pv.RPC("remanialazadio", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
        else if (shoppic == true)
        {
            pv.RPC("remaniashoppica", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
        else if (nefixi == true)
        {
            pv.RPC("remanianefixia", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7);
        }
    }

    [PunRPC]
    void remanialazadio(float order1, float order2, float order3, float order4, float order5, float order6, float order7)
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
    void remaniashoppica(float order1, float order2, float order3, float order4, float order5, float order6, float order7)
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
    void remanianefixia(float order1, float order2, float order3, float order4, float order5, float order6, float order7)
    {
        amountnef2 -= order1;
        amountnef3 -= order1;
        amountnef6 -= order3;
        amountnef5 -= order4;
        amountnef4 -= order5;
        amountnef7 -= order6;
        amountnef1 -= order7;
    }

    public void remaniaConsignment(int id)
    {
        if (remaniaevent == true && remaniainv == true)
        {
            inv.remaniaEvent = true;
            inv.eventrice = eventrice;
            inv.eventiron = eventiron;
            inv.eventwood = eventwood;
            inv.eventcloth = eventcloth;
            inv.eventarmor = eventarmor;
            inv.Consignmentcell(id);
        }
        else if (remaniaevent == false && remaniainv == true)
        {
            inv.Consignmentcell(id);
        }
    }

    public void Opencityremania()
    {
        if (remania == true && remaniakingEvent == true)
        {
            kingEvent.SetActive(true);
        }
    }

    public void Cooldownitem()
    {
        if (amountlaza1 < 250 || amountlaza2 < 170 || amountlaza3 < 100 || amountlaza4 < 60 || amountlaza5 < 35 || amountlaza6 < 10 || amountlaza7 < 5 ||
            amountshopp1 < 250 || amountshopp2 < 170 || amountshopp3 < 100 || amountshopp4 < 60 || amountshopp5 < 35 || amountshopp6 < 10 || amountshopp7 < 5 ||
            amountnef1 < 250 || amountnef2 < 170 || amountnef3 < 100 || amountnef4 < 60 || amountnef5 < 35 || amountnef6 < 10 || amountnef7 < 5 &&
            mainEventsys.GetComponent<MainEventSys>().CooldownremaniaEV == 0)
        {
            mainEventsys.GetComponent<MainEventSys>().notfullremaniaEV = true;
        }
    }
}
