using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDirector : MonoBehaviour
{
    GameObject Size;
    // Start is called before the first frame update
    void Start()
    {
        this.Size = GameObject.Find("Size");
    }

    // Update is called once per frame
    void Update()
    {
        this.Size.GetComponent<Text>().text = "Score : " + (Variables.playerSize * 10 - 3).ToString("F0");
    }
}
