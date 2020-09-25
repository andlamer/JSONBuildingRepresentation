using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
	public GameObject nameInp;
	public GameObject numberInp;
	public GameObject descriptionInp;
    // Start is called before the first frame update
    void Start()
    {
		UIController.gm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnContinueClick()
	{
		UIController.building.name = nameInp.GetComponent<InputField>().text;
		UIController.building.floorsNumber = int.Parse(numberInp.GetComponent<InputField>().text);
		UIController.building.description = descriptionInp.GetComponent<InputField>().text;
		Destroy(UIController.CurrentPanel);
		UIController.gm.SetActive(true);
	}
}
