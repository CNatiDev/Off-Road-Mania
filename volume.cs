using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class volume : MonoBehaviour
{
    public AudioSource AudioSrc;
    private float AudioVolume = 1f;
    public Slider slider;
    private float sld;
    public AudioMixer Mixer;
    Resolution[] resolutions;
    public Dropdown ResolutionDropdown;
    public AudioMixer audio;
    public AudioMixer audio2;
    float SaveVolum;
    float SaveVolum2;
    float SaveVolu12;
    public Slider[] Vol1;
    int stopMusic;
    int stopSound;
    int stopMusicLoad;
    int stopSoundLoad;
    public Dropdown dropdownQuality;
    public GameObject[] StopPlay;
 
    void Start()
    {
        dropdownQuality.value = PlayerPrefs.GetInt("LastQuality1");

        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("LastQuality1"));
        resolutions = Screen.resolutions;
        ResolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int CurrentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
        
        if (resolutions[i].width == Screen.currentResolution.width &&
            resolutions[i].height == Screen.currentResolution.height)
        {
            CurrentResolutionIndex = i;
        }
        }
        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = CurrentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
        SaveVolum2 = PlayerPrefs.GetFloat("volum1");
        SaveVolu12 = PlayerPrefs.GetFloat("volum2");
        audio2.SetFloat("volume", SaveVolum2);
        stopSoundLoad = PlayerPrefs.GetInt("stop2");
        stopMusicLoad = PlayerPrefs.GetInt("stop1");
        Vol1[1].value = SaveVolum2;
        Vol1[0].value = SaveVolu12;
        if (stopMusicLoad == 0)
        {
            StopPlay[0].SetActive(true);
        
        }
        else
        {
            StopPlay[1].SetActive(true);
            StopMusic1(-90f);

        }
        if (stopSoundLoad == 0)
        {
            StopPlay[2].SetActive(true);
          
        }
        else
        {
            StopPlay[3].SetActive(true);
            StopMusic2(-90f);

        }
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }    
  

  
    public void SetQuality(int qualitiIndex)
    {
        QualitySettings.SetQualityLevel(qualitiIndex);
        PlayerPrefs.SetInt("LastQuality1", qualitiIndex);
       
    }
    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void SetVolume2(float volume2)
    {
        // AudioVolume = vol;
        audio.SetFloat("volume2", volume2);
        PlayerPrefs.SetFloat("volum2", volume2);
    }
    public void StopMusic2(float vol)
    {
        audio.SetFloat("volume2", vol);
        stopMusic = 1;
        PlayerPrefs.SetInt("stop2",stopMusic);
        Vol1[0].interactable = false;
       
    }
    public void PlayMusic2()
    {
        SaveVolum = PlayerPrefs.GetFloat("volum2");
        audio.SetFloat("volume2",SaveVolum);
        stopMusic = 0;
        PlayerPrefs.SetInt("stop2", stopMusic);
        Vol1[0].interactable = true;
    }
    public void SetVolume1(float volume2)
    {
        // AudioVolume = vol;
        audio2.SetFloat("volume", volume2);
        PlayerPrefs.SetFloat("volum1", volume2);
    }
    public void StopMusic1(float vol)
    {
        audio2.SetFloat("volume", vol);
        stopSound = 1;
        PlayerPrefs.SetInt("stop1", stopSound);
        Vol1[1].interactable = false;

    }
    public void PlayMusic1()
    {
        SaveVolum = PlayerPrefs.GetFloat("volum1");
        audio2.SetFloat("volume", SaveVolum);
        stopSound = 0;
        PlayerPrefs.SetInt("stop1", stopSound);
        Vol1[1].interactable = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
}