using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLogic : MonoBehaviour
{
    public GameObject playerInventory;  //  Все кнопки инвентаря игрока здесь.
    private string[] playerCells = new string[8];  // Массив имен кнопок, чтобы можно было к ним обращаться.

    void Start()
    {
        int i = 0;
        foreach (Transform child in playerInventory.transform)
        {
            playerCells[i++] = child.name;
        }
        Array.Sort(playerCells);
    }

    // Следит за тем, чтобы в корзине предметы лежали вместе.
    void Update()
    {
        GameObject currentObject;
        Image currentImg;
        bool noPictures = false;
        for (int i = 0; i < 8; i++)  // Поиск пустых ячеек производится по картинкам.
        {
            currentObject = GameObject.Find(playerCells[i]);
            currentImg = currentObject.GetComponent<Image>();
            if (currentImg.sprite == null && !noPictures)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    GameObject otherObject = GameObject.Find(playerCells[j]);
                    Image otherImg = otherObject.GetComponent<Image>();
                    if (otherImg.sprite != null)  // Делаем смещение информации.
                    {
                        currentObject.GetComponent<ShopProduct>().price = otherObject.GetComponent<ShopProduct>().price;
                        currentObject.GetComponent<ShopProduct>().description = otherObject.GetComponent<ShopProduct>().description;
                        otherObject.GetComponent<ShopProduct>().price = 0;
                        otherObject.GetComponent<ShopProduct>().description = "";
                        currentImg.sprite = otherImg.sprite;
                        otherImg.sprite = null;
                        noPictures = false;
                        break;
                    }
                    noPictures = true;
                }
            }
        }
    }

    // Показывает информацию о товаре при наведении на него курсором.
    public void DescriptionOnMouseEnter(GameObject product)
    {
        Text description = GameObject.Find("Description").GetComponent<Text>();
        description.text = "Описание: " + product.GetComponent<ShopProduct>().description;
        Text price = GameObject.Find("Price").GetComponent<Text>();
        if (product.GetComponent<ShopProduct>().price != 0)
        {
            price.text = "Цена: " + product.GetComponent<ShopProduct>().price;
        }
    }

    // Убирает информацию о товаре при смещении с него курсора.
    public void DescriptionOnMouseExit(GameObject product)
    {
        Text description = GameObject.Find("Description").GetComponent<Text>();
        description.text = "Описание:";
        Text price = GameObject.Find("Price").GetComponent<Text>();
        price.text = "Цена:";
    }

    // Копирование иконки товара в корзину.
    public void ShopOnClick(GameObject source)
    {
        bool isEmpty = false;
        int i = 0;
        Image sourceImg = source.GetComponent<Image>();
        Image resultImg;
        do
        {
            resultImg = GameObject.Find(playerCells[i++]).GetComponent<Image>();  // Сначала ищем, где картинка отсутствует.
            if (resultImg.sprite == null)
            {
                isEmpty = true;
            }
        }
        while (!isEmpty && i < 8);
        if (isEmpty)
        {
            resultImg.sprite = sourceImg.sprite;  // Если картинки нет, то также берем объект и добавляем ему цену и описание в параметры.
            GameObject result = GameObject.Find(playerCells[i - 1]);
            result.GetComponent<ShopProduct>().price = source.GetComponent<ShopProduct>().price;
            result.GetComponent<ShopProduct>().description = source.GetComponent<ShopProduct>().description;
        }
    }

    public void DeleteOnClick(GameObject selfObject)
    {
        Image resultImg = selfObject.GetComponent<Image>();
        resultImg.sprite = null;
        selfObject.GetComponent<ShopProduct>().price = 0;
        selfObject.GetComponent<ShopProduct>().description = "";
    }

    public void DeleteAllOnClick()
    {
        GameObject inventory = GameObject.Find("PlayerInventory");
        for (int i = 0; i < inventory.transform.childCount; i++)
        {
            Transform child = inventory.transform.GetChild(i);
            child.GetComponent<Image>().sprite = null;
            child.GetComponent<ShopProduct>().price = 0;
            child.GetComponent<ShopProduct>().description = "";
        }
    }
}
