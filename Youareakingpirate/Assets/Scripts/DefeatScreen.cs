using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DefeatScreen : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<TextMeshProUGUI>().text = GameManager.instance.defeatCause;
        GameManager.instance.ShowUI(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("SplashScreen");
        Destroy(GameManager.instance.gameObject);
    }
}
