using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public TMP_InputField BestName;
    public string newBestName;

    public void Start()
    {
        BestName.onEndEdit.AddListener(SaveNameAfterEnter);
    }

    public void SaveNameAfterEnter(string inputText)
    {
        newBestName = inputText;
        GameManager.Instance.playerName = newBestName;
        GameManager.Instance.SaveName();
    }
}
