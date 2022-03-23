using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public static int ScreenWidth = Screen.width;
    public static int ScreenHeight = Screen.height;



    // Start is called before the first frame update
    private void Start()
    {

            // Only change dimension if on Desktop
            if (SystemInfo.deviceType == DeviceType.Desktop)
            {
                if (ScreenWidth == Screen.width || ScreenHeight == Screen.height)
                {
                    ScreenHeight = Screen.width - (640 * 2);
                    ScreenWidth = Screen.height - (360 * 2);
                    Screen.SetResolution(ScreenWidth, ScreenHeight, true);
                }
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}

