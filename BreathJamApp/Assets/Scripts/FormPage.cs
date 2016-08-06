using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// This component represents each form page
/// </summary>
public class FormPage : MonoBehaviour
{
    public Button nextButton;
    public bool lastPage;

    // Use this for initialization
    void Start()
    {
        if (lastPage)
        {
            nextButton.GetComponentInChildren<Text>().text = "Finish";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hide()
    {
        this.GetComponent<CanvasGroup>().alpha = 0.0f;
        this.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void show()
    {
        this.GetComponent<CanvasGroup>().alpha = 1.0f;
        this.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
