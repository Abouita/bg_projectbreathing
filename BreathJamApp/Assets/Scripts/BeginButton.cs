using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BeginButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

        this.GetComponent<Button>().onClick.AddListener(() => { SceneManager.LoadScene("PreformScene", LoadSceneMode.Single); });
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
