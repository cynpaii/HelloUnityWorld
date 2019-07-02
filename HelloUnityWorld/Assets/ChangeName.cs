using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space"))
        {
            
            textmeshPro.SetText("Hello World from Cynthia Chu"); 
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
