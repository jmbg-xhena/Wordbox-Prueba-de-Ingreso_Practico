using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonInstance : MonoBehaviour
{
    [SerializeField]private Image profilePicture;
    [SerializeField]private TextMeshProUGUI name;

    public void SetPersonData(Sprite pp, string _name)
    {
        profilePicture.sprite = pp;
        name.text = _name;
    }
}
