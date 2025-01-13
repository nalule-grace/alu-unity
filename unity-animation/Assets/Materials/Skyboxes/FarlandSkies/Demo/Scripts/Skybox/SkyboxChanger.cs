using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//using UI;

public class SkyboxChanger : MonoBehaviour
{
    public Material[] Skyboxes;
    private Dropdown _dropdown;

    public void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
        //var options = Skyboxes.Select(skybox => skybox.name).ToList();
        //_dropdown.AddOptions(options);
    }

    public void ChangeSkybox()
    {
        RenderSettings.skybox = Skyboxes[_dropdown.value];
        RenderSettings.skybox.SetFloat("_Rotation", 0);
    }
}