using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChooseCharacterButtons : MonoBehaviour,IPointerClickHandler
{
    public Sprite bacground;

    public GameObject characterDescription;

    private GameObject backgroundobj;

    public void Start()
    {
        backgroundobj = gameObject.transform.parent.transform.GetChild(0).gameObject;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        backgroundobj.GetComponent<UnityEngine.UI.Image>().sprite = bacground;
        Debug.Log("sadsd");
    }
}
