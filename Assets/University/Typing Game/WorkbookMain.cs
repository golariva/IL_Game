using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class WorkbookMain : MonoBehaviour
{
    public List<Word> words;

    public static int countWords = 0;
    public int location;

    public WordSpawner wordSpawner;
    public FailedGame failedGame;
    public WinGame winGame;
    public CountWords countW;

    private bool hasActiveWord;
    private Word activeWord;
    public static bool isPlayed = false;

    private void Start()
    {
        countWords = 0;
        WordCollider.isFailed = false;
    }

    private void Update()
    {
        GameOver();
        GameWin();
        CountPoints();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            countWords++;
        }
    }

    public void GameOver()
    {
        if (WordCollider.isFailed)
        {
            words.Clear();
            failedGame.Setup(countWords);
            if (Input.GetButton("Fire1"))
            {
                isPlayed = true;
                GameStats.rating += 13;
                if (GameStats.rating >= 50)
                    GameStats.rating = 50;
                SceneManager.LoadScene(location);
            }
        }
    }

    public void GameWin()
    {
        if (countWords == 15)
        {
            words.Clear();
            winGame.Setup(countWords);
            if (Input.GetButton("Fire1"))
            {
                isPlayed = true;
                GameStats.rating -= 13;
                if (GameStats.rating <= 1)
                    GameStats.rating = 1;
                SceneManager.LoadScene(location);
            }
        }
    }

    public void CountPoints()
    {
        if (countWords < 15 && !WordCollider.isFailed)
            countW.Setup(countWords);
        else
            countW.DisableText();
    }
}
