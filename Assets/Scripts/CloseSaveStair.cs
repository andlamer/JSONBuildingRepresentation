using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseSaveStair : MonoBehaviour
{
	public GameObject UpStair;
	public GameObject DownStair;
	public GameObject UpFloor;
	public GameObject DownFloor;
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
		Stair newStair = new Stair();
		newStair.id = UIController.stairId ++;
		newStair.NextFloorId = int.Parse(UpFloor.GetComponent<InputField>().text);
		newStair.PrevFloorId = int.Parse(DownFloor.GetComponent<InputField>().text);
		newStair.NextStairId = int.Parse(UpStair.GetComponent<InputField>().text);
		newStair.PrevStairId = int.Parse(DownStair.GetComponent<InputField>().text);
		newStair.placement = UIController.objectPosition;
		UIController.CurrentFloor.StairList.Add(newStair);
		Destroy(UIController.CurrentPanel);
		UIController.gm.SetActive(true);
		UIController.HideLines(false);
	}
}
