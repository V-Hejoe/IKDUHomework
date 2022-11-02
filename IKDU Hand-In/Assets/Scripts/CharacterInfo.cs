using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public string characterName;
    private int characterLevel = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(characterName);
        Debug.Log(PrintCharacterInfo(characterName,characterLevel));
    }

    ///This method takes a character name and a character level and prints it using Debug.Log and return the level with 10 added to it.
    public int PrintCharacterInfo(string characterName, int characterLevel)
    {
        Debug.Log(characterName + ": Lv. " + characterLevel);
        return characterLevel += 10;
    }
}