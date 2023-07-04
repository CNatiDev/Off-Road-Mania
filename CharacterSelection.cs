using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CharacterSelection : MonoBehaviour
{
	#region
	public Image LockIcon;
	public GameObject[] characters;
	public int selectedCharacter = 0;
	int curent;
	public GameObject[] PanelUpgrade;
	public GameObject CarSelectionCanavas;
	public GameObject CameraUpgrade;
	public GameObject CameraRotation;
	public Button[] BuyButton;
	public Button SelectButton;
	public Coin SoldBase;
	public Text CoinValue;
	public Shop ShopDataBase;
	public Button UpgardeButton;
	public Button[] Upgrades;
	#endregion
	private void Start()
	{
		curent = PlayerPrefs.GetInt("selectedCharacter");
		selectedCharacter = curent;
		characters[selectedCharacter].SetActive(true);
		if (SoldBase.Sold1[selectedCharacter] == false)
		{ BuyButton[selectedCharacter].gameObject.SetActive(true); }
		CoinValue.text = ShopDataBase.CarsPrice[selectedCharacter].ToString();
		if (SoldBase.Sold1[selectedCharacter] == true || ShopDataBase.Sold[selectedCharacter] == true)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
		else
		{
			UpgardeButton.interactable = false;
			CoinValue.gameObject.SetActive(true);
		}
		if (ShopDataBase.CarsPrice[0] == 0)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			ShopDataBase.CarsButton[0].gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
	}
	public void NextCharacter()
	{
		
		BuyButton[selectedCharacter].gameObject.SetActive(false);
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		characters[selectedCharacter].SetActive(true);
		if (SoldBase.Sold1[selectedCharacter] == true || ShopDataBase.Sold[selectedCharacter] == true)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
		else
		{
			SelectButton.interactable = false;
			LockIcon.gameObject.SetActive(true);
			CoinValue.gameObject.SetActive(true);
			BuyButton[selectedCharacter].gameObject.SetActive(true);
			UpgardeButton.interactable = false;
		}

		CoinValue.text = ShopDataBase.CarsPrice[selectedCharacter].ToString();

		if (selectedCharacter == 0)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			ShopDataBase.CarsButton[0].gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
	}

	public void PreviousCharacter()
	{
		
		characters[selectedCharacter].SetActive(false);
		BuyButton[selectedCharacter].gameObject.SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		if (SoldBase.Sold1[selectedCharacter] == true || ShopDataBase.Sold[selectedCharacter] == true)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
		else
		{
			SelectButton.interactable = false;
			LockIcon.gameObject.SetActive(true);
			CoinValue.gameObject.SetActive(true);
			BuyButton[selectedCharacter].gameObject.SetActive(true);
			UpgardeButton.interactable = false;
		}
		characters[selectedCharacter].SetActive(true);
		CoinValue.text = ShopDataBase.CarsPrice[selectedCharacter].ToString();
		if (selectedCharacter == 0)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			ShopDataBase.CarsButton[0].gameObject.SetActive(false);
			UpgardeButton.interactable = true;
		}
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		//SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
	public void OpenPanelUpgrade()
	{
		PanelUpgrade[selectedCharacter].SetActive(true);
		CarSelectionCanavas.SetActive(false);
		CameraUpgrade.SetActive(true);
		CameraRotation.SetActive(false);
	}

	public void ExitPanelUpgrade()
	{
		PanelUpgrade[selectedCharacter].SetActive(false);
		CarSelectionCanavas.SetActive(true);
		CameraUpgrade.SetActive(false);
		CameraRotation.SetActive(true);


	}
	public void ChekVehicleStatus()
	{
		if (SoldBase.Sold1[selectedCharacter] == false && ShopDataBase.Sold[selectedCharacter] == false)
		{
			characters[selectedCharacter].SetActive(false);
			characters[curent].SetActive(true);
			BuyButton[selectedCharacter].gameObject.SetActive(false);
			selectedCharacter = curent;

		}

	}
	public void StartVehicleChekStatusShop()
	{
		if (SoldBase.Sold1[selectedCharacter] == true || ShopDataBase.Sold[selectedCharacter] == true)
		{
			SelectButton.interactable = true;
			LockIcon.gameObject.SetActive(false);
			CoinValue.gameObject.SetActive(false);
			ShopDataBase.CarsButton[0].gameObject.SetActive(false);
			UpgardeButton.interactable = true;
			
		}
	}
	public void CheckButtonUpgarde()
	{
		if (ShopDataBase.MoneyAmount < 7500)
		{
			Upgrades[selectedCharacter].interactable = false;
		}
	}
}
