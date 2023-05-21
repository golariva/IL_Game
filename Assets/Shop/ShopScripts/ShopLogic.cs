using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLogic : MonoBehaviour
{
    public GameObject playerInventory;  //  ��� ������ ��������� ������ �����.
    private string[] playerCells = new string[8];  // ������ ���� ������, ����� ����� ���� � ��� ����������.
    int summ;

    void Start()
    {
        int i = 0;
        foreach (Transform child in playerInventory.transform)
        {
            playerCells[i++] = child.name;
        }
        Array.Sort(playerCells);
    }

    // ������ �� ���, ����� � ������� �������� ������ ������.
    void Update()
    {
        GameObject currentObject;
        Image currentImg;
        bool noPictures = false;
        summ = 0;  // ������� ����� ���� ���� �������
        for (int i = 0; i < 8; i++)  // ����� ������ ����� ������������ �� ���������.
        {
            currentObject = GameObject.Find(playerCells[i]);
            currentImg = currentObject.GetComponent<Image>();
            if (currentImg.sprite == null && !noPictures)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    GameObject otherObject = GameObject.Find(playerCells[j]);
                    Image otherImg = otherObject.GetComponent<Image>();
                    if (otherImg.sprite != null)  // ������ �������� ����������.
                    {
                        currentObject.GetComponent<ShopProduct>().price = otherObject.GetComponent<ShopProduct>().price;
                        currentObject.GetComponent<ShopProduct>().description = otherObject.GetComponent<ShopProduct>().description;
                        currentObject.GetComponent<ShopProduct>().title = otherObject.GetComponent<ShopProduct>().title;
                        otherObject.GetComponent<ShopProduct>().title = "";
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
            summ += currentObject.GetComponent<ShopProduct>().price;
        }
        Text sumPrice = GameObject.Find("SumPrice").GetComponent<Text>();
        sumPrice.text = "�����: " + summ.ToString();
    }

    // ���������� ���������� � ������ ��� ��������� �� ���� ��������.
    public void DescriptionOnMouseEnter(GameObject product)
    {
        Text description = GameObject.Find("Description").GetComponent<Text>();
        description.text = "��������: " + product.GetComponent<ShopProduct>().description;
        Text price = GameObject.Find("Price").GetComponent<Text>();
        if (product.GetComponent<ShopProduct>().price != 0)
        {
            price.text = "����: " + product.GetComponent<ShopProduct>().price;
        }
    }

    // ������� ���������� � ������ ��� �������� � ���� �������.
    public void DescriptionOnMouseExit(GameObject product)
    {
        Text description = GameObject.Find("Description").GetComponent<Text>();
        description.text = "��������:";
        Text price = GameObject.Find("Price").GetComponent<Text>();
        price.text = "����:";
    }

    // ����������� ������ ������ � �������.
    public void ShopOnClick(GameObject source)
    {
        bool isEmpty = false;
        int i = 0;
        Image sourceImg = source.GetComponent<Image>();
        Image resultImg;
        do
        {
            resultImg = GameObject.Find(playerCells[i++]).GetComponent<Image>();  // ������� ����, ��� �������� �����������.
            if (resultImg.sprite == null)
            {
                isEmpty = true;
            }
        }
        while (!isEmpty && i < 8);
        if (isEmpty)
        {
            resultImg.sprite = sourceImg.sprite;  // ���� �������� ���, �� ����� ����� ������ � ��������� ��� ���� � �������� � ���������.
            GameObject result = GameObject.Find(playerCells[i - 1]);
            result.GetComponent<ShopProduct>().title = source.GetComponent<ShopProduct>().title;
            result.GetComponent<ShopProduct>().price = source.GetComponent<ShopProduct>().price;
            result.GetComponent<ShopProduct>().description = source.GetComponent<ShopProduct>().description;
        }
    }

    public void DeleteOnClick(GameObject selfObject)
    {
        Image resultImg = selfObject.GetComponent<Image>();
        resultImg.sprite = null;
        selfObject.GetComponent<ShopProduct>().title = "";
        selfObject.GetComponent<ShopProduct>().price = 0;
        selfObject.GetComponent<ShopProduct>().description = "";
        Text description = GameObject.Find("Description").GetComponent<Text>();
        description.text = "��������:";
        Text price = GameObject.Find("Price").GetComponent<Text>();
        price.text = "����:";
    }

    public void DeleteAllOnClick()
    {
        if (GameStats.budget >= summ)
        {
            GameStats.budget -= summ;
            GameObject inventory = GameObject.Find("PlayerInventory");
            for (int i = 0; i < inventory.transform.childCount; i++)
            {
                Transform child = inventory.transform.GetChild(i);
                if (child.gameObject.GetComponent<ShopProduct>().title != "")
                {
                    Inventory.AddItem(child.gameObject.GetComponent<ShopProduct>().title);
                }
                child.GetComponent<Image>().sprite = null;
                child.GetComponent<ShopProduct>().price = 0;
                child.GetComponent<ShopProduct>().description = "";
            }
        }
    }
}
