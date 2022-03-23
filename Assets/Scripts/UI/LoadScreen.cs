using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour
{
    public string sceneToLoad = string.Empty;
    public Button Button; 
    // Start is called before the first frame update
    void Start()
    {
        if (Button)
            Button.onClick.AddListener(ButtonPressed);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
