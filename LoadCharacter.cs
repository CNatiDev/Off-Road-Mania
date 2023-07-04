using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
	public GameObject[] characterPrefabs;
	public Transform spawnPoint;
	public TMP_Text label;
	public GameObject clona;
	public GameObject RespawnSenzor;
	void Start()
	{
		int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
		GameObject prefab = characterPrefabs[selectedCharacter];
		GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
		clona = clone;
		label.text = prefab.name;
		clona.transform.rotation = spawnPoint.rotation;
	}
    private void Update()
    {
		RespawnSenzor.transform.position = new Vector3(clona.transform.position.x, clona.transform.position.y, clona.transform.position.z);
	}
}
