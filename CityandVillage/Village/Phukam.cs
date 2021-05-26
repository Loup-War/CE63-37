using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System.IO;
using LitJson;

public class Phukam : MonoBehaviour
{
    PhotonView pv;
    public Text txtamount1, txtamount2, txtamount3, txtamount4, txtamount5, txtamount6, txtamount7, txtamount8, txtamount9, txtamount10, txtamount11, txtamount12;
    public Text txtprice1, txtprice2, txtprice3, txtprice4, txtprice5, txtprice6, txtprice7, txtprice8, txtprice9, txtprice10, txtprice11, txtprice12;
    public float amount1 = 250, amount2 = 170, amount3 = 100, amount4 = 60, amount5 = 35, amount6 = 10, amount7 = 5, amount8 = 250, amount9 = 170, amount10 = 100, amount11 = 60, amount12 = 35;
    public float buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7, buyitem8, buyitem9, buyitem10, buyitem11, buyitem12;
    public GameObject bookciti, bookciti1;
    public GameObject player;
    public GameObject player1, player2, player3, player4;
    public Inventory inv;
    public float cetificatevalue;
    public GameObject shopInvillage;
    public float price;
    public int temp;
    public bool phukam = false;

    public Text valuemoney1, valuemoney2, valuemoney3, valuemoney4, valuemoney5, valuemoney6, valuemoney7, valuemoney8, valuemoney9, valuemoney10, valuemoney11, valuemoney12;
    public Text weit1, weit2, weit3, weit4, weit5, weit6, weit7, weit8, weit9, weit10, weit11, weit12;

    private JsonData itemData;

    public void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        pv = PhotonView.Get(this);

    }
    void Update()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        player3 = GameObject.FindGameObjectWithTag("Player3");
        player4 = GameObject.FindGameObjectWithTag("Player4");

        if (phukam == true)
        {
            valuemoney1.text = (inv.valuee * (20 - (20 * cetificatevalue))).ToString() + " G";
            valuemoney5.text = (inv.valuee * (115 - (115 * cetificatevalue))).ToString() + " G";
            valuemoney7.text = (inv.valuee * (7 - (7 * cetificatevalue))).ToString() + " G";

            weit1.text = (inv.valuee * 2).ToString() + " Kg";
            weit5.text = (inv.valuee * 8).ToString() + " Kg";
            weit7.text = (inv.valuee * 1).ToString() + " Kg";
        }
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
            shopInvillage.GetComponent<VisitVillage>().phukam = true;
            phukam = true;
            openphukam();
        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            shopInvillage.GetComponent<VisitVillage>().phukam = true;
            phukam = true;
            openphukam();
        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            shopInvillage.GetComponent<VisitVillage>().phukam = true;
            phukam = true;
            openphukam();
        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(true);
            shopInvillage.GetComponent<VisitVillage>().phukam = true;
            phukam = true;
            openphukam();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if ((col.gameObject.tag == "Player1" && player1.GetComponent<PhotonView>().IsMine == true))
        {
            shopInvillage.SetActive(false);
            phukam = false;
            shopInvillage.GetComponent<VisitVillage>().phukam = false;

        }
        else if (col.gameObject.tag == "Player2" && player2.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(false);
            phukam = false;
            shopInvillage.GetComponent<VisitVillage>().phukam = false;

        }
        else if (col.gameObject.tag == "Player3" && player3.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(false);
            phukam = false;
            shopInvillage.GetComponent<VisitVillage>().phukam = false;

        }
        else if (col.gameObject.tag == "Player4" && player4.GetComponent<PhotonView>().IsMine == true)
        {
            shopInvillage.SetActive(false);
            phukam = false;
            shopInvillage.GetComponent<VisitVillage>().phukam = false;

        }
    }

    public void Buying(int id)
    {
        if (phukam == true)
        {
            if (id == 0 && inv.valuee <= amount2)//ไม้
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (20 - (20 * cetificatevalue))) && inv.weightall + (inv.valuee * 2) <= 300)
                {
                    buyitem1 = inv.valuee; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount1.text = amount2.ToString() + "/170";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(20 - (20 * cetificatevalue));
                    }
                }
            }
            if (id == 1 && inv.valuee <= amount3)//เหล็ก
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (50 - (50 * cetificatevalue))) && inv.weightall + (inv.valuee * 4) <= 300)
                {
                    buyitem1 = 0; buyitem2 = inv.valuee; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount2.text = amount3.ToString() + "/100";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(50 - (50 * cetificatevalue));
                    }
                }
            }
            if (id == 2 && inv.valuee <= amount6)//เพรช
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (300 - (300 * cetificatevalue))) && inv.weightall + (inv.valuee * 10) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = inv.valuee; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount3.text = amount6.ToString() + "/10";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(300 - (300 * cetificatevalue));
                    }
                }
            }
            if (id == 3 && inv.valuee <= amount5)//เกราะ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (260 - (260 * cetificatevalue))) && inv.weightall + (inv.valuee * 12) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = inv.valuee; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount4.text = amount5.ToString() + "/35";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(260 - (260 * cetificatevalue));
                    }
                }
            }
            if (id == 4 && inv.valuee <= amount4)//ผ้า
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (115 - (115 * cetificatevalue))) && inv.weightall + (inv.valuee * 8) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = inv.valuee; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount5.text = amount4.ToString() + "/60";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(115 - (115 * cetificatevalue));
                    }
                }
            }
            if (id == 5 && inv.valuee <= amount7)//เครื่องเทศ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (500 - (500 * cetificatevalue))) && inv.weightall + (inv.valuee * 20) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = inv.valuee; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount6.text = amount7.ToString() + "/5";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(500 - (500 * cetificatevalue));
                    }
                }
            }
            if (id == 6 && inv.valuee <= amount1)//ข้าว
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (7 - (7 * cetificatevalue))) && inv.weightall + (inv.valuee * 1) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = inv.valuee; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount7.text = amount1.ToString() + "/250";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(7 - (7 * cetificatevalue));
                    }
                }
            }
            if (id == 7 && inv.valuee <= amount8)//ข้าวพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (7 - (7 * cetificatevalue))) && inv.weightall + (inv.valuee * 1) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = inv.valuee; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount8.text = amount8.ToString() + "/250";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(7 - (7 * cetificatevalue));
                    }
                }
            }
            if (id == 8 && inv.valuee <= amount9)//ไม้พิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (20 - (20 * cetificatevalue))) && inv.weightall + (inv.valuee * 2) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = inv.valuee; buyitem10 = 0; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount9.text = amount9.ToString() + "/170";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(20 - (20 * cetificatevalue));
                    }
                }
            }
            if (id == 9 && inv.valuee <= amount10)//เหล็กพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (50 - (50 * cetificatevalue))) && inv.weightall + (inv.valuee * 4) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = inv.valuee; buyitem11 = 0; buyitem12 = 0;
                    phukamSharing();
                    txtamount10.text = amount10.ToString() + "/100";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(50 - (50 * cetificatevalue));
                    }
                }
            }
            if (id == 10 && inv.valuee <= amount11)//ผ้าพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (115 - (115 * cetificatevalue))) && inv.weightall + (inv.valuee * 8) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = inv.valuee; buyitem12 = 0;
                    phukamSharing();
                    txtamount11.text = amount11.ToString() + "/60";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(115 - (115 * cetificatevalue));
                    }
                }
            }
            if (id == 11 && inv.valuee <= amount12)//อาวูธพิเศษ
            {
                if (player.GetComponent<PlayerMoney>().money >= (inv.valuee * (260 - (260 * cetificatevalue))) && inv.weightall + (inv.valuee * 12) <= 300)
                {
                    buyitem1 = 0; buyitem2 = 0; buyitem3 = 0; buyitem4 = 0; buyitem5 = 0; buyitem6 = 0; buyitem7 = 0; buyitem8 = 0; buyitem9 = 0; buyitem10 = 0; buyitem11 = 0; buyitem12 = inv.valuee;
                    phukamSharing();
                    txtamount12.text = amount12.ToString() + "/35";
                    inv.AddItem(id);
                    for (int i = 1; i <= inv.valuee; i++)
                    {
                        player.GetComponent<PlayerMoney>().ReducedGold(260 - (260 * cetificatevalue));
                    }
                }
            }
            inv.valuee = 1;
        }
    }
    void phukamSharing()
    {
        pv.RPC("phukamSharevalue", RpcTarget.AllBuffered, buyitem1, buyitem2, buyitem3, buyitem4, buyitem5, buyitem6, buyitem7, buyitem8, buyitem9, buyitem10, buyitem11, buyitem12);
    }

    [PunRPC]
    void phukamSharevalue(float order1, float order2, float order3, float order4, float order5, float order6, float order7, float order8, float order9, float order10, float order11, float order12)
    {
        amount2 -= order1;
        amount3 -= order2;
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
    public void openphukam()
    {
        if (phukam == true)
        {
            txtamount1.text = amount2.ToString() + "/170";
            txtprice1.text = (20f - (20f * cetificatevalue)).ToString();
            txtamount5.text = amount4.ToString() + "/60";
            txtprice5.text = (115f - (115f * cetificatevalue)).ToString();
            txtamount7.text = amount1.ToString() + "/250";
            txtprice7.text = (7f - (7f * cetificatevalue)).ToString();
        }
    }

    public void UseCetificate()
    {
        if (phukam == true)
        {
            if (player.GetComponent<PlayMoment>().certificate[0] == 5)
            {
                cetificatevalue = 0.1f;
                player.GetComponent<PlayMoment>().certificate[0] = 0;
                bookciti1.SetActive(true);
                for (int i = 0; i < player.GetComponent<PlayMoment>().certificate.Length - 1; i++)
                {
                    temp = player.GetComponent<PlayMoment>().certificate[i + 1];
                    player.GetComponent<PlayMoment>().certificate[i + 1] = player.GetComponent<PlayMoment>().certificate[i];
                    player.GetComponent<PlayMoment>().certificate[i] = temp;
                }


            }
            else if (player.GetComponent<PlayMoment>().certificate[1] == 5)
            {
                cetificatevalue = 0.1f;
                player.GetComponent<PlayMoment>().certificate[1] = 0;
                bookciti1.SetActive(true);
                for (int i = 1; i < player.GetComponent<PlayMoment>().certificate.Length - 1; i++)
                {
                    temp = player.GetComponent<PlayMoment>().certificate[i + 1];
                    player.GetComponent<PlayMoment>().certificate[i + 1] = player.GetComponent<PlayMoment>().certificate[i];
                    player.GetComponent<PlayMoment>().certificate[i] = temp;
                }

            }
            else if (player.GetComponent<PlayMoment>().certificate[2] == 5)
            {
                cetificatevalue = 0.1f;
                player.GetComponent<PlayMoment>().certificate[2] = 0;
                bookciti1.SetActive(true);
            }
            else
            {
                bookciti.SetActive(true);
            }
        }
    }

    public void Resetvaluevillage()
    {
        cetificatevalue = 0f;
    }


}
