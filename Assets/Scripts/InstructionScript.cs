using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{
	public GameObject InstructionPanel;
	public GameObject MainPanel;
	private  GameObject panel;
	private bool panelExistance = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnInstrClick()
	{
		panel = Instantiate(InstructionPanel, MainPanel.transform);
		panel.SetActive(true);
		panelExistance = true;
		UIController.CurrentPanel = panel;
	}
}
