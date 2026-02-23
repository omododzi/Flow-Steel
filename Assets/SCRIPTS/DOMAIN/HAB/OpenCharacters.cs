using UnityEngine;
using System;
using System.Collections.Generic;

public class OpenCharacters : MonoBehaviour
{
    public List<GameObject> allCharacters = new List<GameObject>();
    public List<GameObject> openedCharacters = new List<GameObject>();

    public void Start()
    {
        if(openedCharacters.Count > 0)
        {
            for (int i = 0; i< openedCharacters.Count; i++)
            { 
                GameObject pers = Instantiate(openedCharacters[i]);
                pers.transform.SetParent(gameObject.transform);
            }
        }
    }

}
