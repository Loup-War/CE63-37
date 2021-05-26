using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class BarEvent : MonoBehaviour
{
    public GameObject MainEvent;
    public GameObject cavasEvent;
    public GameObject cavasEventsoldier;
    public GameObject player;
    public GameObject p1, p2, p3, p4;
    public GameObject shringMoney;

    public GameObject successAddcard;
    public GameObject cardAttack;  
    public GameObject selectcard;
    public GameObject fullcard;

    public GameObject gotzip;
    public Text eventnext;
    public Text wherenext;

    public Text valueBet;
    public GameObject notBet;
    public GameObject youwindice;
    public GameObject youLosedice;
    public Text number1,number2;

    public GameObject deceive;

    public int[] EventBar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public int RandomNum;
    public float bet;
    public int temp;

    private void Awake()
    {
        shuffledeck(EventBar);
        foreach (int value in EventBar)
        {
        }
    }
    public void ClickBarEvent()
    {
        if (EventBar[0] == 1)
        {
            gotzip.SetActive(true);
            if (MainEvent.GetComponent<MainEventSys>().array[0] == 1)
            {
                eventnext.text = "ราชโองการ";
                if(MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 1)
                {
                    wherenext.text = "จักวรรดิอีมอล";
                }
                else if(MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 2)
                {
                    wherenext.text = "อาณาจักรองมะ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 3)
                {
                    wherenext.text = "อาณาจักรวัดสง่า";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 4)
                {
                    wherenext.text = "หมู่เกาะวิงคิ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 5)
                {
                    wherenext.text = "อาณาจักรต้าลู่ ";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 2)
            {
                eventnext.text = "ภัยแล้ง";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 2)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 4)
                {
                    wherenext.text = "กรุงอโยธยา ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 5)
                {
                    wherenext.text = "เมืองละแวก ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 6)
                {
                    wherenext.text = "เมืองออเดรีย ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 7)
                {
                    wherenext.text = "เมืองฟริกาเซีย ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 8)
                {
                    wherenext.text = "เมืองต้าลู่กง ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 9)
                {
                    wherenext.text = "เมืองไอยคุปต์ ราคาขายกับราคาซื้อของสินค้า ข้าวจะเพิ่ม 50%";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 3)
            {
                eventnext.text = "สงคราม";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 1)
                {
                    wherenext.text = "เมืองมาซีรอสและเมืองละแวก ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 2)
                {
                    wherenext.text = "เมืองมาซีรอสและเมืองปารีเซีย ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 3)
                {
                    wherenext.text = "เมืองรีมาเนียและเมืองไอยคุปต์ ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 4)
                {
                    wherenext.text = "เมืองทรอมันและเมืองฟริกาเซีย ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 5)
                {
                    wherenext.text = "อควาเนียและเมืองต้าลู่กง ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 6)
                {
                    wherenext.text = "กรุงอโยธยาและเมืองซองเวอร์เดอร์ลัว ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์และเมืองปารีเซีย ราคาขายกับราคาซื้อของสินค้า เกราะจะเพิ่ม 50%";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 4)
            {
                eventnext.text = "ขยายเมือง";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 2)
                {
                    wherenext.text = "เมืองรีมาเนีย ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 4)
                {
                    wherenext.text = "เมืองละแวก ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 5)
                {
                    wherenext.text = "เมืองฟริกาเซีย ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 6)
                {
                    wherenext.text = "เมืองต้าลู่กง ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์ ราคาขายกับราคาซื้อของสินค้า ไม้จะเพิ่ม 50%";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 5)
            {
                eventnext.text = "สงครามทางเศรษฐกิจ";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 2)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 4)
                {
                    wherenext.text = "กรุงอโยธยา ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 5)
                {
                    wherenext.text = "เมืองออเดรีย ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 6)
                {
                    wherenext.text = "เมืองต้าลู่กง ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์ ราคาขายกับราคาซื้อของสินค้า เพรชจะเพิ่ม 50%";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 6)
            {
                eventnext.text = "ฤดูหนาวมาเยือน";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 2)
                {
                    wherenext.text = "เมืองรีมาเนีย ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 3)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 4)
                {
                    wherenext.text = "เมืองละแวก ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 5)
                {
                    wherenext.text = "เมืองฟริกาเซีย ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 6)
                {
                    wherenext.text = "เมืองออเดรีย ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 7)
                {
                    wherenext.text = "เมืองต้าลู่กง ราคาขายกับราคาซื้อของสินค้า ผ้าจะเพิ่ม 50%";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
        }
        else if (EventBar[0] == 2)
        {
            Debug.Log("ทหารรับจ้าง");
            cavasEventsoldier.SetActive(true);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 3)
        {
            Debug.Log("เสี่ยงโชค");
            cavasEvent.SetActive(true);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 4)
        {
            Debug.Log("ล่อลวง");
            Debug.Log("โดยล่อลวงจนเมาเสียเงิน 20%");
            deceive.SetActive(true);
            player.GetComponent<PlayerMoney>().money -= (player.GetComponent<PlayerMoney>().money * 0.2f);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 5)
        {
            cardAttack.SetActive(true);
            Debug.Log("การ์ดโจมตี");
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }

        }
        else if (EventBar[0] == 6)
        {
            gotzip.SetActive(true);
            if (MainEvent.GetComponent<MainEventSys>().array[0] == 1)
            {
                eventnext.text = "ราชโองการ";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 1)
                {
                    wherenext.text = "จักวรรดิอีมอล";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 2)
                {
                    wherenext.text = "อาณาจักรองมะ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 3)
                {
                    wherenext.text = "อาณาจักรวัดสง่า";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 4)
                {
                    wherenext.text = "หมู่เกาะวิงคิ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent6[0] == 5)
                {
                    wherenext.text = "อาณาจักรต้าลู่ ";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 2)
            {
                eventnext.text = "ภัยแล้ง";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 2)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 4)
                {
                    wherenext.text = "กรุงอโยธยา";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 5)
                {
                    wherenext.text = "เมืองละแวก ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 6)
                {
                    wherenext.text = "เมืองออเดรีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 7)
                {
                    wherenext.text = "เมืองฟริกาเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 8)
                {
                    wherenext.text = "เมืองต้าลู่กง";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent1[0] == 9)
                {
                    wherenext.text = "เมืองไอยคุปต์ ";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 3)
            {
                eventnext.text = "สงคราม";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 1)
                {
                    wherenext.text = "เมืองมาซีรอสและเมืองละแวก";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 2)
                {
                    wherenext.text = "เมืองมาซีรอสและเมืองปารีเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 3)
                {
                    wherenext.text = "เมืองรีมาเนียและเมืองไอยคุปต์";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 4)
                {
                    wherenext.text = "เมืองทรอมันและเมืองฟริกาเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 5)
                {
                    wherenext.text = "อควาเนียและเมืองต้าลู่กง ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 6)
                {
                    wherenext.text = "กรุงอโยธยาและเมืองซองเวอร์เดอร์ลัว";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent2[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์และเมืองปารีเซีย";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 4)
            {
                eventnext.text = "ขยายเมือง";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 2)
                {
                    wherenext.text = "เมืองรีมาเนีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 4)
                {
                    wherenext.text = "เมืองละแวก";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 5)
                {
                    wherenext.text = "เมืองฟริกาเซีย ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 6)
                {
                    wherenext.text = "เมืองต้าลู่กง";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent3[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 5)
            {
                eventnext.text = "สงครามทางเศรษฐกิจ";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 2)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 3)
                {
                    wherenext.text = "เมืองปารีเซีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 4)
                {
                    wherenext.text = "กรุงอโยธยา";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 5)
                {
                    wherenext.text = "เมืองออเดรีย ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 6)
                {
                    wherenext.text = "เมืองต้าลู่กง";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent4[0] == 7)
                {
                    wherenext.text = "เมืองไอยคุปต์";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }
            else if (MainEvent.GetComponent<MainEventSys>().array[0] == 6)
            {
                eventnext.text = "ฤดูหนาวมาเยือน";
                if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 1)
                {
                    wherenext.text = "เมืองทรอมัน";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 2)
                {
                    wherenext.text = "เมืองรีมาเนีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 3)
                {
                    wherenext.text = "เมืองซองเวอร์เดอร์ลัว";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 4)
                {
                    wherenext.text = "เมืองละแวก";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 5)
                {
                    wherenext.text = "เมืองฟริกาเซีย ";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 6)
                {
                    wherenext.text = "เมืองออเดรีย";
                }
                else if (MainEvent.GetComponent<MainEventSys>().arrayevent5[0] == 7)
                {
                    wherenext.text = "เมืองต้าลู่กง";
                }
                for (int i = 0; i < EventBar.Length - 1; i++)
                {
                    temp = EventBar[i + 1];
                    EventBar[i + 1] = EventBar[i];
                    EventBar[i] = temp;
                }
            }

        }
        else if (EventBar[0] == 7)
        {
            Debug.Log("ทหารรับจ้าง");
            cavasEventsoldier.SetActive(true);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 8)
        {
            Debug.Log("เสี่ยงโชค");
            cavasEvent.SetActive(true);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 9)
        {
            Debug.Log("ล่อลวง");
            Debug.Log("โดยล่อลวงจนเมาเสียเงิน 20%");
            deceive.SetActive(true);
            player.GetComponent<PlayerMoney>().money -= (player.GetComponent<PlayerMoney>().money * 0.2f);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }
        }
        else if (EventBar[0] == 10)
        {
            Debug.Log("การ์ดโจมตี");
            cardAttack.SetActive(true);
            for (int i = 0; i < EventBar.Length - 1; i++)
            {
                temp = EventBar[i + 1];
                EventBar[i + 1] = EventBar[i];
                EventBar[i] = temp;
            }

        }

    }

    public void shuffledeck(int[] array)
    {
        int p = array.Length;
        for (int n = p - 1; n > 0; n--)
        {
            int r = Random.Range(0, n);
            int t = array[r];
            array[r] = array[n];
            array[n] = t;
        }
    }
    private void Update()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        p2 = GameObject.FindGameObjectWithTag("Player2");
        p3 = GameObject.FindGameObjectWithTag("Player3");
        p4 = GameObject.FindGameObjectWithTag("Player4");
        if (player == null)
        {
            if (p1.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player1");
            }
            else if (p2.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player2");
            }
            else if (p3.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player3");
            }
            else if (p4.GetComponent<PhotonView>().IsMine == true)
            {
                player = GameObject.FindGameObjectWithTag("Player4");
            }
        }
    }
    public void Rollthedice()
    {
        if (bet != 0)
        {
            RandomNum = Random.Range(1, 7);
            if (RandomNum >= 5)
            {
                Debug.Log("You Win");
                number1.text = RandomNum.ToString();
                youwindice.SetActive(true);
                player.GetComponent<PlayerMoney>().money += (bet*0.5f);
                bet = 0;
                valueBet.text = "";
            }
            else
            {
                Debug.Log("You Lose");
                number2.text = RandomNum.ToString();
                youLosedice.SetActive(true);
                player.GetComponent<PlayerMoney>().money -= bet;
                bet = 0;
                valueBet.text = "";
            }
        }
        else if(bet == 0)
        {

        }
    }
    public void reject()
    {
        Debug.Log("ไม่ต้องการจ้างทหาร");
        cavasEventsoldier.SetActive(false);
    }

    public void PaySolider()
    {
        Debug.Log("จ้างทหาร");
        player.GetComponent<PlayerMoney>().money -= 800;
        player.GetComponent<PlayMoment>().soldierGuard = 5;
        MainEvent.GetComponent<MainEventSys>().BarTurn = 1;
        cavasEventsoldier.SetActive(false);
    }

    public void Bet100()
    {
        bet = 100f;
        valueBet.text = "100 G";
    }
    public void Bet500()
    {
        bet = 500f;
        valueBet.text = "500 G";
    }
    public void Bet1000()
    {
        bet = 1000f;
        valueBet.text = "1000 G";
    }

    public void PaycardSpecial()
    {
        if(player.GetComponent<PlayerMoney>().money > 1500)
        {
            selectcard.SetActive(true);
        }
    }
    public void SelectinBug(int id)
    {
        if (id == 1 && player.GetComponent<PlayMoment>().cardAttack[0] == 0)
        {
            player.GetComponent<PlayMoment>().cardAttack[0] = 1;
            player.GetComponent<PlayerMoney>().money -= 1500;
            selectcard.SetActive(false);
            successAddcard.SetActive(true);
        }
        else if (id == 2 && player.GetComponent<PlayMoment>().cardAttack[1] == 0)
        {
            player.GetComponent<PlayMoment>().cardAttack[1] = 1;
            player.GetComponent<PlayerMoney>().money -= 1500;
            selectcard.SetActive(false);
            successAddcard.SetActive(true);
        }
        else
        {
            fullcard.SetActive(true);
        }
    }
}
