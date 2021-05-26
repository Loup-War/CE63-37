using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;
using Photon.Pun;

public class Inventory : MonoBehaviour
{
	PhotonView pv;
	public GameObject eventsys;
	public Button button;
	public Text showValueSell1, howValueSell2, howValueSell3, howValueSell4, howValueSell5, howValueSell6, howValueSell7, howValueSell8, howValueSell9, howValueSell10, howValueSell11, howValueSell12;
	public Text textvalue1, textvalue2, textvalue3, textvalue4, textvalue5, textvalue6, textvalue7, textvalue8, textvalue9, textvalue10, textvalue11, textvalue12;
	public Text showamountIV1, showamountIV2, showamountIV3, showamountIV4, showamountIV5, showamountIV6, showamountIV7, showamountIV8, showamountIV9, showamountIV10, showamountIV11, showamountIV12;

	public GameObject player;
	public GameObject player1, player2, player3, player4;
	public Text showamount1, showamount2, showamount3, showamount4, showamount5, showamount6, showamount7, showamount8, showamount9, showamount10, showamount11, showamount12, showvaluebuy1,
				showvaluebuy2, showvaluebuy3, showvaluebuy4, showvaluebuy5, showvaluebuy6, showvaluebuy7, showvaluebuy8, showvaluebuy9,showvaluebuy10, showvaluebuy11, showvaluebuy12, showweightall;
	public Text weightValuetext;
	public bool opentOne;

	public float pricesell;
	public float guildDesir;
	public float guildLoup;
	public float guildSerment;
	public float guildAsrial;
	public float guildOrion;
	public float valuee = 1;
	public float moneystack;
	public float valuebuycost1, valuebuycost2, valuebuycost3, valuebuycost4, valuebuycost5, valuebuycost6, valuebuycost7;
	public float valueWcost1, valueWcost2, valueWcost3, valueWcost4, valueWcost5, valueWcost6, valueWcost7;
	public bool aquaniaEvent, audreaEvent, ayothayaEvent, fricasiaEvent, lawaekEvent, macyrosEvent, parisiaEvent, remaniaEvent, songverderLoisEvent, talukongEvent, tanaowadeeEvent,tromanEvent;
	public float eventrice, eventgem, eventcloth, eventarmor, eventiron,eventwood,eventspice;
	public float weightall, propertyvalue;
	private float amountwood, amountiron, amountrice, amountgem, amountarmor, amountcloth, amountspices, amountricespecial, amountwoodspecial, amountironspecial, amountclothspecial, amountarmorspecial;


	GameObject inventoryPanel;
	GameObject slotPanel;
	ItemDatabase database;
	public GameObject inventorySlot;
	public GameObject inventoryItem;
	private int slotAmount;
	public List<Item> items = new List<Item>();
	public List<GameObject> slots = new List<GameObject>();

	private JsonData itemData;


	void Start()
	{
		pv = PhotonView.Get(this);
		//itemData = JsonMapper.ToObject(File.ReadAllText($"{Application.streamingAssetsPath}/items.json"));
		//database = GetComponent<ItemDatabase>();
		//slotAmount = 12;
		//inventoryPanel = GameObject.Find("InventoryPanel");
		//slotPanel = inventoryPanel.transform.Find("SlotPanel").gameObject;
		//for (int i = 0; i < slotAmount; i++)
		//{
		//	items.Add(new Item());
		//	slots.Add(Instantiate(inventorySlot));
		//	slots[i].GetComponent<Slot>().id = i;
		//	slots[i].transform.SetParent(slotPanel.transform);
		//}
		//AddItem(0);
		//AddItem(1);
		//AddItem(2);
		//AddItem(3);
		//AddItem(4);
		//AddItem(5);
	}
	public void after()
	{
		//if (opentOne == false)
		//{
		//	opentOne = true;
		//	inventoryPanel = GameObject.Find("InventoryPanel");
		//	slotPanel = inventoryPanel.transform.Find("SlotPanel").gameObject;
		//	for (int i = 0; i < slotAmount; i++)
		//	{
		//		items.Add(new Item());
		//		slots.Add(Instantiate(inventorySlot));
		//		slots[i].GetComponent<Slot>().id = i;
		//		slots[i].transform.SetParent(slotPanel.transform);
		//	}
		//	AddItem(0);
		//	AddItem(1);
		//	AddItem(2);
		//	AddItem(3);
		//	AddItem(4);
		//	AddItem(5);
		//	AddItem(6);
		//	AddItem(7);
		//	AddItem(8);
		//	AddItem(9);
		//	AddItem(10);
		//	AddItem(11);
		//}
	}

	public void AddItem(int id)
	{
		for (int i = 0; i < valuee; i++) 
		{
			if (id == 0) { amountwood++; }
			else if (id == 1) { amountiron++; }
			else if (id == 2) { amountgem++; }
			else if (id == 3) { amountarmor++; }
			else if (id == 4) { amountcloth++; }
			else if (id == 5) { amountspices++; }
			else if (id == 6) { amountrice++; }
			else if (id == 7) { amountricespecial++; }
			else if (id == 8) { amountwoodspecial++; }
			else if (id == 9) { amountironspecial++; }
			else if (id == 10) { amountclothspecial++; }
			else if (id == 11) { amountarmorspecial++; }
		}
	}
	public void RemoveItem(int id)
	{
		if (aquaniaEvent == true)
		{
			Debug.Log("aquaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (audreaEvent == true)
		{
			Debug.Log("audreaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (ayothayaEvent == true)
		{
			Debug.Log("ayothayaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (fricasiaEvent == true)
		{
			Debug.Log("fricasiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (lawaekEvent == true)
		{
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (macyrosEvent == true)
		{
			Debug.Log("macyrosEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (parisiaEvent == true)
		{
			Debug.Log("parisiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (remaniaEvent == true)
		{
			Debug.Log("remaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (songverderLoisEvent == true)
		{
			Debug.Log("songverderLoisEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (talukongEvent == true)
		{
			Debug.Log("talukongEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (tanaowadeeEvent == true)
		{
			Debug.Log("tanaowadeeEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (tromanEvent == true)
		{
			Debug.Log("tromanEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
		else if (eventarmor == 0f && eventcloth == 0f && eventiron == 0f && eventrice == 0f && eventwood == 0f && eventgem == 0f)
		{
			Debug.Log("notEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
					amountwood--;
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
					amountiron--;
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
					amountgem--;
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
					amountarmor--;
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
					amountcloth--;
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					player.GetComponent<PlayerMoney>().money += 1200;
					amountspices--;
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
					amountrice--;
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
					amountricespecial--;
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
					amountwoodspecial--;
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
					amountironspecial--;
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
					amountclothspecial--;
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
					amountarmorspecial--;
				}
			}
		}
	}
	void Update()
	{
		player1 = GameObject.FindGameObjectWithTag("Player1");
		player2 = GameObject.FindGameObjectWithTag("Player2");
		player3 = GameObject.FindGameObjectWithTag("Player3");
		player4 = GameObject.FindGameObjectWithTag("Player4");
		if(player == null)
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


		weightall = (amountwood * 2) + (amountiron * 4) + (amountgem * 10) +
					(amountarmor * 12) + (amountcloth * 8) + (amountspices * 20) +
					(amountrice * 1) + (amountricespecial * 1) + (amountwoodspecial * 2) +
					(amountironspecial * 4) + (amountclothspecial * 8) + (amountarmorspecial * 12);
		if (player != null)
		{
			propertyvalue = (amountwood * 25) + (amountiron * 60) + (amountgem * 500) +
						(amountarmor * 280) + (amountcloth * 130) + (amountspices * 1200) +
						(amountrice * 10) + (amountricespecial * 20) + (amountwoodspecial * 40) +
						(amountironspecial * 100) + (amountclothspecial * 230) + (amountarmorspecial * 520) + player.GetComponent<PlayerMoney>().money;
		}
		showamount1.text = amountwood.ToString();
		showamount2.text = amountiron.ToString();
		showamount3.text = amountgem.ToString();
		showamount4.text = amountarmor.ToString();
		showamount5.text = amountcloth.ToString();
		showamount6.text = amountspices.ToString();
		showamount7.text = amountrice.ToString();
		showamount8.text = amountricespecial.ToString();
		showamount9.text = amountwoodspecial.ToString();
		showamount10.text = amountironspecial.ToString();
		showamount11.text = amountclothspecial.ToString();
		showamount12.text = amountarmorspecial.ToString();
		showweightall.text = weightall.ToString()+" Kg";
		showvaluebuy1.text = valuee.ToString();
		showvaluebuy2.text = valuee.ToString();
		showvaluebuy3.text = valuee.ToString();
		showvaluebuy4.text = valuee.ToString();
		showvaluebuy5.text = valuee.ToString();
		showvaluebuy6.text = valuee.ToString();
		showvaluebuy7.text = valuee.ToString();
		showvaluebuy8.text = valuee.ToString();
		showvaluebuy9.text = valuee.ToString();
		showvaluebuy10.text = valuee.ToString();
		showvaluebuy11.text = valuee.ToString();
		showvaluebuy12.text = valuee.ToString();

		textvalue1.text = amountwood.ToString();
		textvalue2.text = amountiron.ToString();
		textvalue3.text = amountgem.ToString();
		textvalue4.text = amountarmor.ToString();
		textvalue5.text = amountcloth.ToString();
		textvalue6.text = amountspices.ToString();
		textvalue7.text = amountrice.ToString();
		textvalue8.text = amountricespecial.ToString();
		textvalue9.text = amountwoodspecial.ToString();
		textvalue10.text = amountironspecial.ToString();
		textvalue11.text = amountclothspecial.ToString();
		textvalue12.text = amountarmorspecial.ToString();

		weightValuetext.text = weightall.ToString() + "Kg / 300 Kg";
		showamountIV1.text = amountwood.ToString();
		showamountIV2.text = amountiron.ToString();
		showamountIV3.text = amountgem.ToString();
		showamountIV4.text = amountarmor.ToString();
		showamountIV5.text = amountcloth.ToString();
		showamountIV6.text = amountspices.ToString();
		showamountIV7.text = amountrice.ToString();
		showamountIV8.text = amountricespecial.ToString();
		showamountIV9.text = amountwoodspecial.ToString();
		showamountIV10.text = amountironspecial.ToString();
		showamountIV11.text = amountclothspecial.ToString();
		showamountIV12.text = amountarmorspecial.ToString();

		showValueSell1.text = (25 + (25 * (eventwood + guildLoup))).ToString();
		howValueSell2.text = (60 + (60 * (eventiron + guildSerment))).ToString();
		howValueSell3.text = (500 + (500 * eventgem)).ToString();
		howValueSell4.text = (280 + (280 * (eventarmor + guildOrion))).ToString();
		howValueSell5.text = (130 + (130 * (eventcloth + guildAsrial))).ToString();
		howValueSell6.text = 1200.ToString();
		howValueSell7.text = (10 + (10 * (eventrice + guildDesir))).ToString();
		howValueSell8.text = (20 + (20 * (eventrice + guildDesir))).ToString();
		howValueSell9.text = (40 + (40 * (eventwood + guildLoup))).ToString();
		howValueSell10.text = (100 + (100 * (eventiron + guildSerment))).ToString();
		howValueSell11.text = (230 + (230 * (eventcloth + guildAsrial))).ToString();
		howValueSell12.text = (520 + (520 * (eventarmor + guildOrion))).ToString();



	}
	public void closeresetEvent()
    {
		aquaniaEvent = false;
		audreaEvent = false;
		ayothayaEvent = false;
		fricasiaEvent = false;
		lawaekEvent = false;
		macyrosEvent = false;
		parisiaEvent = false;
		remaniaEvent = false;
		songverderLoisEvent = false;
		talukongEvent = false;
		tanaowadeeEvent = false;
		tromanEvent = false;
		eventrice = 0f;
		eventgem = 0f;
		eventcloth = 0f;
		eventarmor = 0f;
		eventiron = 0f;
		eventwood = 0f;
		eventspice = 0f;

	}

	public void RemoveItemall(int id)
	{
		if (aquaniaEvent == true)
		{
			Debug.Log("aquaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (audreaEvent == true)
		{
			Debug.Log("audreaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (ayothayaEvent == true)
		{
			Debug.Log("ayothayaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (fricasiaEvent == true)
		{
			Debug.Log("fricasiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (lawaekEvent == true)
		{
			Debug.Log("lawaekEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (macyrosEvent == true)
		{
			Debug.Log("macyrosEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (parisiaEvent == true)
		{
			Debug.Log("parisiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (remaniaEvent == true)
		{
			Debug.Log("remaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (songverderLoisEvent == true)
		{
			Debug.Log("songverderLoisEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (talukongEvent == true)
		{
			Debug.Log("talukongEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (tanaowadeeEvent == true)
		{
			Debug.Log("tanaowadeeEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (tromanEvent == true)
		{
			Debug.Log("tromanEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (eventarmor == 0f && eventcloth == 0f && eventiron == 0f && eventrice == 0f && eventwood == 0f && eventgem == 0f)
		{
			Debug.Log("notEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
	}
	public void pulsvaluee()
    {
		valuee += 1;
		
    }
	public void minusvaluee()
    {
		if (valuee > 1)
		{
			valuee -= 1;
		}
    }
	public void pulstenvaluee()
    {
		valuee += 10;
    }
	public void minustenvaluee()
    {
		if(valuee >= 11)
        {
			valuee -= 10;
        }
    }

	public void Consignmentcell (int id)
    {
		if (aquaniaEvent == true)
		{
			Debug.Log("aquaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (audreaEvent == true)
		{
			Debug.Log("audreaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (ayothayaEvent == true)
		{
			Debug.Log("ayothayaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (fricasiaEvent == true)
		{
			Debug.Log("fricasiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (lawaekEvent == true)
		{
			Debug.Log("lawaekEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (macyrosEvent == true)
		{
			Debug.Log("macyrosEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (parisiaEvent == true)
		{
			Debug.Log("parisiaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (remaniaEvent == true)
		{
			Debug.Log("remaniaEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (songverderLoisEvent == true)
		{
			Debug.Log("songverderLoisEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (talukongEvent == true)
		{
			Debug.Log("talukongEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (tanaowadeeEvent == true)
		{
			Debug.Log("tanaowadeeEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (tromanEvent == true)
		{
			Debug.Log("tromanEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
		else if (eventarmor == 0f && eventcloth == 0f && eventiron == 0f && eventrice == 0f && eventwood == 0f && eventgem == 0f)
		{
			Debug.Log("notEvent");
			if (id == 0)
			{
				if (amountwood > 0)
				{
					valuee = amountwood;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (25 + (25 * (eventwood + guildLoup)));
						amountwood--;
					}
				}
			}
			if (id == 1)
			{
				if (amountiron > 0)
				{
					valuee = amountiron;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (60 + (60 * (eventiron + guildSerment)));
						amountiron--;
					}
				}
			}
			if (id == 2)
			{
				if (amountgem > 0)
				{
					valuee = amountgem;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (500 + (500 * eventgem));
						amountgem--;
					}
				}
			}
			if (id == 3)
			{
				if (amountarmor > 0)
				{
					valuee = amountarmor;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (280 + (280 * (eventarmor + guildOrion)));
						amountarmor--;
					}
				}
			}
			if (id == 4)
			{
				if (amountcloth > 0)
				{
					valuee = amountcloth;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (130 + (130 * (eventcloth + guildAsrial)));
						amountcloth--;
					}
				}
			}
			if (id == 5)
			{
				if (amountspices > 0)
				{
					valuee = amountspices;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += 1200;
						amountspices--;
					}
				}
			}
			if (id == 6)
			{
				if (amountrice > 0)
				{
					valuee = amountrice;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (10 + (10 * (eventrice + guildDesir)));
						amountrice--;
					}
				}
			}
			if (id == 7)
			{
				if (amountricespecial > 0)
				{
					valuee = amountricespecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (20 + (20 * (eventrice + guildDesir)));
						amountricespecial--;
					}
				}
			}
			if (id == 8)
			{
				if (amountwoodspecial > 0)
				{
					valuee = amountwoodspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (40 + (40 * (eventwood + guildLoup)));
						amountwoodspecial--;
					}
				}
			}
			if (id == 9)
			{
				if (amountironspecial > 0)
				{
					valuee = amountironspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (100 + (100 * (eventiron + guildSerment)));
						amountironspecial--;
					}
				}
			}
			if (id == 10)
			{
				if (amountclothspecial > 0)
				{
					valuee = amountclothspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (230 + (230 * (eventwood + guildAsrial)));
						amountclothspecial--;
					}
				}
			}
			if (id == 11)
			{
				if (amountarmorspecial > 0)
				{
					valuee = amountarmorspecial;
					for (int i = 1; i <= valuee; i++)
					{
						player.GetComponent<PlayerMoney>().money += (520 + (520 * (eventwood + guildOrion)));
						amountarmorspecial--;
					}
				}
			}
		}
	}
}
