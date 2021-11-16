using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlay() {
        SceneManager.LoadScene("Main");
    }
    public void OnCredit() {
        SceneManager.LoadScene("Credit");
    }
    public void OnHelp() {
        SceneManager.LoadScene("Help");
    }
    public void OnMenu() {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
