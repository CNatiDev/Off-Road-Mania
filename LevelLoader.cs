using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
     int  LastScene = 1;
 
    public void LastSceneLoad()
    {
        SceneManager.LoadScene(LastScene);
    }
    public void LoadScenaName(string scenename)
    {
        
        SceneManager.LoadScene(scenename);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
