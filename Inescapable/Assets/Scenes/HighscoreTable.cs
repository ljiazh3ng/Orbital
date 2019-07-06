using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HighscoreTable : MonoBehaviour
{

    private Transform entryContainer;
    private Transform entryTemplate;
    private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {

        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");
        entryTemplate.gameObject.SetActive(false);
        highscoreEntryList = new List<HighscoreEntry>() {
            new HighscoreEntry{ score = 129846, name = "AAA"} ,
            new HighscoreEntry{ score = 29846, name = "zhou"} ,
            new HighscoreEntry{ score = 1249846, name = "xin"} ,
            new HighscoreEntry{ score = 116846, name = "wei"} ,
            new HighscoreEntry{ score = 12346, name = "lua"} ,
            new HighscoreEntry{ score = 01822426, name = "jiz"} ,


        };


        //sort the list by score

        for (int i = 0; i < highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscoreEntryList.Count; j++)
            {
                if (highscoreEntryList[j].score > highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscoreEntryList[i];
                    highscoreEntryList[i] = highscoreEntryList[j];
                    highscoreEntryList[j] = tmp;

                }

            }


        }

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);

        }

    }

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 50f;
        Transform entryTransform = Instantiate(entryTemplate, entryContainer);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(5, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);
        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        entryTransform.Find("rankingText").GetComponent<TMP_Text>().text = rankString;

        int score = highscoreEntry.score;
        string name = highscoreEntry.name;

        entryTransform.Find("nameText").GetComponent<TMP_Text>().text = name;
        entryTransform.Find("scoreText").GetComponent<TMP_Text>().text = score.ToString();

        transformList.Add(entryTransform);
    }





    /*
     * Represents a single high score entry. 
     */
    private class HighscoreEntry
    {

        public int score;
        public string name;


    }

}

