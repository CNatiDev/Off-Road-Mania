using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManagerChalenge : MonoBehaviour
{
    public int levelIsUnlocked = 0;


    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        levelIsUnlocked = PlayerPrefs.GetInt("levelIsUnlockedChalenge", 1);
        if (levelIsUnlocked > 12)
         levelIsUnlocked = levelIsUnlocked - 12;
     else
         levelIsUnlocked = 1;
        
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelIsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }

    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
