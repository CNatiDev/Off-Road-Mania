using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class Qualiti : MonoBehaviour
{   public RenderPipelineAsset[] QulaityLevel;
    public TMP_Dropdown drobdown;
    public GameObject @object;
    void Start()
    {
        drobdown.value = QualitySettings.GetQualityLevel();
    }

    public void ChangeLevel(int value)
    {
        QualitySettings.SetQualityLevel(value);
        QualitySettings.renderPipeline = QulaityLevel[value];
    }
   
}
