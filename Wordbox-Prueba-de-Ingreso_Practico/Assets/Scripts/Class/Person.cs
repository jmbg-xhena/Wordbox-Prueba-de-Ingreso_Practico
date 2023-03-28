using System.Net.Mail;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Person",menuName = "ScriptableObjects/Person")]
public class Person : ScriptableObject
{
    public Sprite profilePicture;
    public string eMail;
    public string name;
    public string gender;
    public string age;
    public string city;
}
