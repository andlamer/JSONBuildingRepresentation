using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanPanel : MonoBehaviour
{
	public GameObject plan;
    // Start is called before the first frame update
    void Start()
    {
        UIController.PlanePanel = plan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
