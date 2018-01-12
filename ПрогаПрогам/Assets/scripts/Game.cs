using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	public Text moneyText;
	private int money;
	public Image bgImg;
	public Image[] bttnImgs= new Image[2];

	private void Start () {
	
		PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
	
		PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
	}

	void PurchaseManager_OnPurchaseConsumable (PurchaseEventArgs args)
	{
		money += 1000;
		moneyText.text = "ВАЛЮТА: " + money + "$";
		Debug.Log ("You purchse:" + args.purchasedProduct.definition.id + "- Consumable");
	}

	void PurchaseManager_OnPurchaseNonConsumable (PurchaseEventArgs args)
	{
		bgImg.color = new Color (227 / 255.0f, 41 / 255.0f, 128 / 255.0f);
			foreach (Image i in bttnImgs) i.color = new Color (89 / 255.0f, 41 / 255.0f, 160 / 255.0f);

		Debug.Log ("You purchse:" + args.purchasedProduct.definition.id + "- Non Consumable");
	}
}
