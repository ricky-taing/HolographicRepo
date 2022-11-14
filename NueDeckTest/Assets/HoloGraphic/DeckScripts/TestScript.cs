using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private DeckSelectionWindow myDeckSelectionWindow;
    [SerializeField] private Image myScreenBlocker;

    private string userDeckSelection;

    // Start is called before the first frame update
    void Start()
    {
        OpenDeckSelectionWindow("Please select a deck");
        myScreenBlocker.enabled = true;
    }

    private void OpenDeckSelectionWindow(string message)
    {
        myDeckSelectionWindow.gameObject.SetActive(true);
        myDeckSelectionWindow.whitehatButton.onClick.AddListener(whitehatClicked);
        myDeckSelectionWindow.greyhatButton.onClick.AddListener(greyhatClicked);
        myDeckSelectionWindow.blackhatButton.onClick.AddListener(blackhatClicked);
        myDeckSelectionWindow.messageText.text = message;
    }

    private void whitehatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "whitehat";
        Debug.Log(userDeckSelection);
    }

    private void greyhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "greyhat";
        Debug.Log(userDeckSelection);
    }

    private void blackhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "blackhat";
        Debug.Log(userDeckSelection);
    }
}
