using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleList : MonoBehaviour
{
    [SerializeField] private List<Person> people;
    [SerializeField] private GameObject personPrefab;
    [SerializeField] private GameObject personPanel;

    [SerializeField] private GameObject person;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<people.Count;i++)
        {
            person = Instantiate(personPrefab);
            person.GetComponent<PersonInstance>().SetPersonData(people[i].profilePicture,people[i].name);
            person.transform.parent = personPanel.transform;
            person.transform.localScale = Vector3.one * 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
