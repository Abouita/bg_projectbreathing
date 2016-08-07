using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// This compontent controls the flow of the wizard
/// </summary>
public class DialogWizard : MonoBehaviour
{
    public List<FormPage> pages;
    int currentPage = 0;

    // Use this for initialization
    void Start()
    {
        pages = new List<FormPage>(this.GetComponentsInChildren<FormPage>());

        for(int i = 0; i < pages.Count; i++ )
        {
            if (i != pages.Count - 1)
            {
                pages[i].nextButton.onClick.AddListener(() => { nextPage(); });
            } else
            {
                pages[i].nextButton.onClick.AddListener(() => { finishWizard(); });
                pages[pages.Count - 1].nextButton.GetComponentInChildren<Text>().text = "Finish";
            }
            pages[i].hide();
            pages[i].transform.localPosition = new Vector3(0, 0, 0);
        }

        //Show the first page
        pages[0].show();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void nextPage()
    {
        Debug.Log("Next page clicked");
        pages[currentPage++].hide();
        pages[currentPage].show();
    }

    void finishWizard ()
    {
        Debug.Log("Finish Wizard clicked");
        SceneManager.LoadScene("LungScene", LoadSceneMode.Single);
    }
}
