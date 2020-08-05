using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Al_Palandrome_Manager : MonoBehaviour
{
    public GameObject cube_PREFAB;
    public Text cube_txt;
    string LETTERS = "xa3";
    public string STRING_GENERATION;
    int LETTER_AMOUNT;
    public int count = 0, atleastPlaindrome = 0;
    void Start()
    {
        atleastPlaindrome = Random.Range(3, 11);
        stringGeneration();
    }
    public void stringGeneration()
    {
        LETTER_AMOUNT = Random.Range(9, 16);
        for (int i = 0; i < LETTER_AMOUNT; i++)
        {
            STRING_GENERATION += LETTERS[Random.Range(0, LETTERS.Length)];
        }
        if (isPalindrome(STRING_GENERATION))
        {
            count++;
            cube_PREFAB.tag = "collectible";
            GameObject.Find("PLAYER").GetComponent<Al_Player_controller>().PALINDROMES_TOTAL++;
        }
        else
        {
            count++;
            cube_PREFAB.tag = "notcollectible";
        }
        if (GameObject.Find("PLAYER").GetComponent<Al_Player_controller>().PALINDROMES_TOTAL < atleastPlaindrome)
        {
            if (count >= 7)
            {
                atleastThreePalindrome();
                count++;
                cube_PREFAB.tag = "collectible";
                GameObject.Find("PLAYER").GetComponent<Al_Player_controller>().PALINDROMES_TOTAL++;
            }
            else
            {
                stringGeneration();
            }
        }
    }
    bool isPalindrome(string checkstring)
    {
        int first = 0;
        int last = checkstring.Length - 1;
        while (last > first)
        {
            if (checkstring[first++] != checkstring[last--])
            {
                return false;
            }
        }
        return true;
    }
    void atleastThreePalindrome()
    {
        string alphabets = "xa3";
        int charAmount = Random.Range(9, 16);
        string mstring = "";
        string reverse = "";
        if (charAmount % 2 == 0)
        {
            for (int i = 0; i < charAmount / 2; i++)
            {
                mstring += alphabets[Random.Range(0, alphabets.Length)];
            }
            int Length = (charAmount / 2) - 1;
            while (Length >= 0)
            {
                reverse = reverse + mstring[Length];
                Length--;
            }
            STRING_GENERATION = mstring + reverse;
        }
        else
        {
            for (int i = 0; i <= charAmount / 2; i++)
            {
                mstring += alphabets[Random.Range(0, alphabets.Length)];
            }
            int Length = (charAmount / 2) - 1;
            while (Length >= 0)
            {
                reverse = reverse + mstring[Length];
                Length--;
            }
            STRING_GENERATION = mstring + reverse;
        }
    }
    void Update()
    {
        cube_txt.text = STRING_GENERATION;
    }
}
