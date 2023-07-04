using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveColorUpgrade : MonoBehaviour
{
    public Material[] Material;
    public Renderer[] Cars;
    private int R;
    private int G;
    private int B;
    private Color Color_1;
    private Color Color_2;
    public string R11;
    public string G11;
    public string B11;
    public string R12;
    public string G12;
    public string B12;
    private void Start()
    { 
        Get_Color();
        Material[0].color = Cars[0].material.color;
        Material[1].color = Cars[1].material.color;
    }

    /*public void Save_Color()
    {
        Material[0].SetColor("set1", Material[0].color);
        Material[1].SetColor("set2", Material[1].color);
        PlayerPrefs.SetFloat("R", Material[0].color.r);
        PlayerPrefs.SetFloat("G", Material[0].color.g);
        PlayerPrefs.SetFloat("B", Material[0].color.b);
        PlayerPrefs.SetFloat("R1", Material[1].color.r);
        PlayerPrefs.SetFloat("G1", Material[1].color.g);
        PlayerPrefs.SetFloat("B1", Material[1].color.b);

    }*/
    public void Save_Color()
    {
        PlayerPrefs.SetFloat(R11, Material[0].color.r);
        PlayerPrefs.SetFloat(G11, Material[0].color.g);
        PlayerPrefs.SetFloat(B11, Material[0].color.b);
        PlayerPrefs.SetFloat(R12, Material[1].color.r);
        PlayerPrefs.SetFloat(G12, Material[1].color.g);
        PlayerPrefs.SetFloat(B12, Material[1].color.b);
    }
 
    public void Get_Color()
    {
        Color_1 = new Color(
            PlayerPrefs.GetFloat(R11),
            PlayerPrefs.GetFloat(B11),
            PlayerPrefs.GetFloat(G11)
            ) ;
        Color_2 = new Color(
           PlayerPrefs.GetFloat(R12),
           PlayerPrefs.GetFloat(G12),
           PlayerPrefs.GetFloat(B12)
           );
        Cars[0].material.color = Color_1;
        Cars[1].material.color = Color_2;
        

    }


}
