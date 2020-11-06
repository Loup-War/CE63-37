using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LitJson;

public class Inventory : MonoBehaviour
{
	public Button button;
	public GameObject player;
	public float price;
	public float guild;
	public float Event = 0;

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

		itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
		database = GetComponent<ItemDatabase>();
		slotAmount = 6;
		inventoryPanel = GameObject.Find("InventoryPanel");
		slotPanel = inventoryPanel.transform.Find("SlotPanel").gameObject;
		for (int i = 0; i < slotAmount; i++)
		{
			items.Add(new Item());
			slots.Add(Instantiate(inventorySlot));
			slots[i].GetComponent<Slot>().id = i;
			slots[i].transform.SetParent(slotPanel.transform);
		}
		AddItem(0);
		AddItem(1);
		AddItem(2);
		AddItem(3);
		AddItem(4);
		AddItem(5);


	}
    public void AddItem(int id)
	{
		Item itemToAdd = database.FetchItemById(id);
		if (itemToAdd.Stackable && CheckIfItemIsInInventory(itemToAdd))
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].Id == id)
				{
					ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
					data.amount++;
					data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
					break;
				}
			}
		}
		else
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].Id == -1)
				{
					items[i] = itemToAdd;
					GameObject itemObj = Instantiate(inventoryItem);
					itemObj.GetComponent<ItemData>().item = itemToAdd;
					itemObj.GetComponent<ItemData>().slotId = i;
					itemObj.transform.SetParent(slots[i].transform);
					itemObj.transform.position = Vector2.zero;
					itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
					itemObj.name = "Item: " + itemToAdd.Title;
					slots[i].name = "Slot: " + itemToAdd.Title;
					ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
					data.amount = 0;
					data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
					break;
				}
			}
		}
	}
	public void RemoveItem(int id)
	{
		price = (int)itemData[id]["price"];
		Item itemToRemove = database.FetchItemById(id);
		if (itemToRemove.Stackable && CheckIfItemIsInInventory(itemToRemove))
		{

			for (int j = 0; j < items.Count; j++)
			{

				if (items[j].Id == id)
				{
					ItemData data = slots[j].transform.GetChild(0).GetComponent<ItemData>();
					if (data.amount > 0)
					{
						player.GetComponent<PlayerMoney>().money += (price + (price * Event));
						data.amount--;
						data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
					}
					//if (data.amount == 0)
					//{
					//	Destroy(slots[j].transform.GetChild(0).gameObject);
					//	items[j] = new Item();
					//break;
					//}
					//if (data.amount == 1)
					//{
					//	slots[j].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
					//	break;
					//}
					break;
				}
			}
		}
		//else
		//	for (int i = 0; i < items.Count; i++)
		//		if (items[i].Id != -1 && items[i].Id == id)
		//		{
		//			player.GetComponent<PlayerMoney>().money += price;
		//			items[i] = new Item();
		//			break;
		//		}
	}
	bool CheckIfItemIsInInventory(Item item)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (items[i].Id == item.Id)
			{
				return true;
			}
		}

		return false;
	}
	public void UpdateEvent(float eventt)
	{
		Event = eventt;
	}
}
