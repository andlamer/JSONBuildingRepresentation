using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseSavePlace : MonoBehaviour
{
	public GameObject name;
	public GameObject description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void SaveAndClose()
	{
		Place newPlace = new Place();
		newPlace.id = UIController.placeId ++;
		newPlace.name = name.GetComponent<InputField>().text;
		newPlace.description = description.GetComponent<InputField>().text;
		newPlace.placement = UIController.objectPosition;
		UIController.CurrentFloor.PlaceList.Add(newPlace);
		Destroy(UIController.CurrentPanel);
		UIController.gm.SetActive(true);
		UIController.HideLines(false);
	}
}
