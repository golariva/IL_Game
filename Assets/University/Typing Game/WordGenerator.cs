using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "асимптота", "шкала", "уровень", "определение", "дифференциал", "функция", "ряд", "теорема", "аксиома", "ось", "уравнение", "свойство", "цифра", "неравенство", "тригонометрия", "интеграл", "вектор", "геометрия", "слагаемое", "частное", "произведение", "сумма", "разность", "знаменатель", "числитель", "правило", "математика", "логарифм", "пропорция", "график", "парабола", "гипербола", "эллипс", "значение", "производная", "порядок" };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
