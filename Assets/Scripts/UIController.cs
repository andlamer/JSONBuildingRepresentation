using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
	public static GameObject CurrentPanel;
	public static Floor CurrentFloor;
	public static GameObject PlanePanel;
	public static GameObject gm;
	public static int roomId = 0;
	public static int floorId = 0;
	public static int placeId = 0;
	public static int scheduleId = 0;
	public static int stairId = 0;
	public static int currentfloor = 0;
	public static Building building = new Building();
	public static Vector2 objectPosition = new Vector2();
	public static List<LineRenderer> newLine = new List<LineRenderer>();
	public static List<GameObject> allobj = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
		building.id = 1;
		building.floorsNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public static void HideLines(bool quest)
	{
		if (quest == true)
		{
			foreach (LineRenderer line in newLine)
			{
				line.SetWidth(0f,0f);
			}
		}
		else
		{
			foreach (LineRenderer line in newLine)
			{
				line.SetWidth(15f,15f);
			}
		}
		
	}
}
