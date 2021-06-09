using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    //public Text CamList;
    public Dropdown SelectCamera;

    void Start()
    {
        SelectCamera.options.Clear();
        // detects and displays all camera in debug and Drop Down menu
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
        {
            //CamList.text += i +" - "+devices[i].name+"\n";
            Debug.Log(devices[i].name);
            SelectCamera.options.Add(new Dropdown.OptionData() { text = devices[i].name });
        }
        SelectCamera.RefreshShownValue();
    }

    public void OnExit()
    {
        Application.Quit();
        Debug.Log("closing application..");
    }
}
