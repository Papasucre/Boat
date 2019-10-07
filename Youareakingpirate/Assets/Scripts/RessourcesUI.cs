using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RessourcesUI : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] Text foodStock;
    [SerializeField] Text foodMaxStock;
    [SerializeField] Text woodStock;
    [SerializeField] Text woodMaxStock;
    [SerializeField] Text goldStock;
    [SerializeField] Text goldMaxStock;
    [SerializeField] Text sailorsStock;
    [SerializeField] Text sailorsMaxStock;
#pragma warning restore 0649

    private void Update()
    {
        if (GameManager.instance.foodStock.ToString() != foodStock.text)
            foodStock.text = GameManager.instance.foodStock.ToString();
        if (GameManager.instance.foodMaxStock.ToString() != foodMaxStock.text)
            foodMaxStock.text = GameManager.instance.foodMaxStock.ToString();
        if (GameManager.instance.woodStock.ToString() != woodStock.text)
            woodStock.text = GameManager.instance.woodStock.ToString();
        if (GameManager.instance.woodMaxStock.ToString() != woodMaxStock.text)
            woodMaxStock.text = GameManager.instance.woodMaxStock.ToString();
        if (GameManager.instance.goldStock.ToString() != goldStock.text)
            goldStock.text = GameManager.instance.goldStock.ToString();
        if (GameManager.instance.goldMaxStock.ToString() != goldMaxStock.text)
            goldMaxStock.text = GameManager.instance.goldMaxStock.ToString();
        if (GameManager.instance.sailorsStock.ToString() != sailorsStock.text)
            sailorsStock.text = GameManager.instance.sailorsStock.ToString();
        if (GameManager.instance.sailorsMaxStock.ToString() != sailorsMaxStock.text)
            sailorsMaxStock.text = GameManager.instance.sailorsMaxStock.ToString();
    }

    public void ShowRessources(bool show)
    {
        foreach (Transform item in transform)
        {
            item.gameObject.SetActive(show);
        }
    }

}
