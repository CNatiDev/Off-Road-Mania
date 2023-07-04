using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HSVPicker;
public class saveColorUp : MonoBehaviour
{
    public Material Material;
    public ColorPicker ColorPicker;
    private void Update()
    {
        Material.color = ColorPicker.CurrentColor;
    }
}
