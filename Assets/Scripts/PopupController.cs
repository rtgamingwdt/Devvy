using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[SerializeField]
public class PopupController : MonoBehaviour
{
    public GameObject popup; // The Panel object that contains the popup message
    public float popupDuration = 1.0f;

    // Start is called before the first frame update
    void Start() {
        popup.SetActive(false);
    }

    public void ShowPopup(string message)
    {
        TextMeshProUGUI popupText = popup.GetComponentInChildren<TextMeshProUGUI>();
        popupText.text = message;
        popup.SetActive(true); // Show the popup

        Invoke("HidePopup", popupDuration); // Hide the popup after the specified duration
    }

    private void HidePopup()
    {
        popup.SetActive(false); // Hide the popup
    }

    public void CopyClipboard(string text) {
        GUIUtility.systemCopyBuffer = text;
    }

    public void CopyData() {
        Debug.Log(Game.data.ToString());
    }
}
