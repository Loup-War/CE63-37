using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System.IO;
using LitJson;

public class Ordia : MonoBehaviour
{
    public PhotonView pv;
    public Text txtamount1, txtamount2, txtamount3, txtamount4, txtamount5, txtamount6, txtamount7, txtamount8, txtamount9, txtamount10, txtamount11, txtamount12;
    public int amount1 = 250, amount2 = 170, amount3 = 100, amount4 = 60, amount5 = 35, amount6 = 10, amount7 = 5, amount8 = 250, amount9 = 170, amount10 = 100, amount11 = 60, amount12 = 35;
    public int buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7, buyitem8, buyitem9, buyitem10, buyitem11, buyitem12;
    public GameObject canvasObject;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public Inventory inv;
    public GameObject shopInvillage;
    public float price;
    public bool ordia = false;

    private JsonData itemData;

    public void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        pv = PhotonView.Get(this);

        canvasObject.SetActive(false);
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
            shopInvillage.SetActive(true);
            ordia = true;
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            ordia = true;
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            ordia = true;
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            ordia = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        shopInvillage.SetActive(false);
        ordia = false;
    }

    public void Buying(int id)
    {
        price = (int)itemData[id]["price"];
        if (ordia == true)
        {
            if (id == 0 && amount2 >= 1)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 2 <= 300)
                {
                    buyitem1 = 1; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount1.text = amount1.ToString() + "/170";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 1 && amount3 >= 1)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 4 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 1; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount2.text = amount3.ToString() + "/100";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 2 && amount6 >= 1)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 10 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 1; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount3.text = amount6.ToString() + "/10";
                    inv.AddItem(id);

                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 3 && amount5 >= 1)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 12 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 1; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount4.text = amount5.ToString() + "/35";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 4 && amount4 >= 1)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 8 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 1; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount5.text = amount4.ToString() + "/60";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 5 && amount7 >= 1)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 20 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 1; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount6.text = amount7.ToString() + "/5";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 6 && amount1 >= 1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 1 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 1; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount7.text = amount1.ToString() + "/250";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 7 && amount1 >= 1)//ข้าวพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 1 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 1; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount7.text = amount8.ToString() + "/250";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 8 && amount1 >= 1)//ไม้พิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 2 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 1; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount8.text = amount9.ToString() + "/170";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 9 && amount1 >= 1)//เหล็กพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 4 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 1; buyitem11 = 0; buyitem12 = 0;
                    ordiaSharing();
                    txtamount9.text = amount10.ToString() + "/100";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 10 && amount1 >= 1)//ผ้าพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 8 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 1; buyitem12 = 0;
                    ordiaSharing();
                    txtamount10.text = amount11.ToString() + "/60";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }
            if (id == 11 && amount1 >= 1)//อาวูธพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= price && inv.weightall + 12 <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 1;
                    ordiaSharing();
                    txtamount11.text = amount12.ToString() + "/35";
                    inv.AddItem(id);
                    player.GetComponent<PlayerMoney>().ReducedGold(price);
                }
            }

        }
    }
    void ordiaSharing()
    {
        pv.RPC("aquanialazadio", RpcTarget.All, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7, buyitem8, buyitem9, buyitem10, buyitem11, buyitem12);
    }

    [PunRPC]
    void ordiaSharevalue(int order1, int order2, int order3, int order4, int order5, int order6, int order7, int order8, int order9, int order10, int order11, int order12)
    {
        amount2 -= order1;
        amount3 -= order1;
        amount6 -= order3;
        amount5 -= order4;
        amount4 -= order5;
        amount7 -= order6;
        amount1 -= order7;
        amount8 -= order8;
        amount9 -= order9;
        amount10 -= order10;
        amount11 -= order11;
        amount12 -= order12;
    }
}
