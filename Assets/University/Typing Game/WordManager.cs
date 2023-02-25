using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public static int countWords = 0;
    public int location;

    public WordSpawner wordSpawner;
    public FailedGame failedGame;
    public WinGame winGame;

    private bool hasActiveWord;
    private Word activeWord;

    private void Update()
    {
        GameOver();
        GameWin();
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
            failedGame.Setup(countWords);
            if (Input.GetKeyDown(KeyCode.F))
                SceneManager.LoadScene(location);
        }
    }

    public void GameWin()
    {
        if (countWords == 15)
        {
            winGame.Setup(countWords);
            if (Input.GetKeyDown(KeyCode.F))
                SceneManager.LoadScene(location);
        }
    }
}
