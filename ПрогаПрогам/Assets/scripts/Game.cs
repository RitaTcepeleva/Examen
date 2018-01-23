using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	public Text moneyText;
	public static float money;

	private void Start () {

		PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
	}

	void PurchaseManager_OnPurchaseConsumable (PurchaseEventArgs args)
	{
		money += 1000;
		moneyText.text = "ВАЛЮТА: " + money + "$";
		Debug.Log ("You purchse:" + args.purchasedProduct.definition.id + "- Consumable");
	}
}
