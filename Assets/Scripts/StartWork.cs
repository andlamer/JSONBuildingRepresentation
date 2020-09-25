using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWork : MonoBehaviour
{
	public GameObject StartPanel;
	public GameObject BuildingPanel;
	public GameObject Menu;
	public GameObject PlanePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void OnDestroyCilck ()
	{
		Destroy(StartPanel);
		UIController.PlanePanel = PlanePanel;
		UIController.CurrentPanel = Instantiate(BuildingPanel, Menu.transform);
	}
}
