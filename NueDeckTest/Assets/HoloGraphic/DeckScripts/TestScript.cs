using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private DeckSelectionWindow myDeckSelectionWindow;
    [SerializeField] private Image myScreenBlocker;

    [SerializeField] public GameplayData gameplayData;

    private string userDeckSelection;
    private bool gameStart;
    private int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        if (count == 1) {
            gameStart = true;
            if (gameStart == true)
                {
                    OpenDeckSelectionWindow("Please select a deck");
                    myScreenBlocker.enabled = true;
                }
            else
                {
                    myScreenBlocker.enabled = false;
                }
        }
        
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
        gameStart = false;
        count -= 1;
    }

    private void greyhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "greyhat";
        Debug.Log(userDeckSelection);
        gameStart = false;
        count -= 1;
    }

    private void blackhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "blackhat";
        Debug.Log(userDeckSelection);
        gameStart = false;
        count -= 1;
    }
}
