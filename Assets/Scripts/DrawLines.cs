using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
	public Transform baseDot;
	public Transform baseDoor;
	public Transform baseStair;
	public Transform baseElevator;
	public Transform basePlace;
	public KeyCode mouseLeft;
	public KeyCode connect;
	public KeyCode door;
	public KeyCode place;
	public KeyCode elevator;
	public KeyCode stair;
	public KeyCode delete;
	public GameObject panel;
	public GameObject Mainpanel;
	public GameObject AuditPanel;
	public GameObject StairPanel;
	public GameObject PlacePanel;
	public GameObject gm;
	public static string toolType;
	public static int i = 0;
	public static List<Vector2> points = new List<Vector2>();
	public static List<GameObject> lines = new List<GameObject>();
	public static List<LineRenderer> newLine = new List<LineRenderer>();
	Color c1 = new Color(1, 0, 0, 1);
    Color c2 = new Color(1, 0, 0, 1);
	Transform current;
    // Start is called before the first frame update
    void Start()
    {
        UIController.gm = gm;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
		Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		if (Input.GetKeyDown(mouseLeft))
		{
			if (i == 0) 
			{
				var point = Instantiate(baseDot, panel.transform);
				point.transform.position = objPosition;
				points.Add(objPosition);
				UIController.allobj.Add(point.gameObject);
				i++;
				Debug.Log(i);
				current = point;
			} 
			else {
				if (objPosition.x <= points[points.Count - 1].x + 60 && objPosition.x >= points[points.Count - 1].x - 60) {
					objPosition.x = points[points.Count - 1].x;
				} else if (objPosition.y <= points[points.Count - 1].y + 60 && objPosition.y >= points[points.Count - 1].y - 60) {
					objPosition.y = points[points.Count - 1].y;
				}
				var point = Instantiate(baseDot, panel.transform);
				point.transform.position = objPosition;
				points.Add(objPosition);
				UIController.allobj.Add(point.gameObject);
				GameObject line = new GameObject();
				newLine.Add(line.AddComponent<LineRenderer>());
				newLine[i-1].SetWidth(9f, 9f);
				newLine[i-1].material = new Material(Shader.Find("Sprites/Default"));
				newLine[i-1].SetColors(c1, c2);
				newLine[i-1].SetPosition(0, points[i-1]);
                newLine[i-1].SetPosition(1, points[i]);
				UIController.newLine.Add(newLine[i-1]);
				UIController.allobj.Add(line);
				i++;
			}
		} else if (Input.GetKeyDown(connect)) {
				/*if (points[points.Count - 1].x <= points[0].x + 60 && points[points.Count - 1].x >= points[0].x - 60) 
				{
					var point = new Vector2 (points[0].x, points[points.Count - 1].y);
					points[points.Count - 1] = point;
				} else if (points[points.Count - 1].y <= points[0].y + 60 && points[points.Count - 1].y >= points[0].y - 60) {
					var point = new Vector2 (points[points.Count - 1].x, points[0].y);
					points[points.Count - 1] = point;
				} */
				GameObject line = new GameObject();
				newLine.Add(line.AddComponent<LineRenderer>());
				newLine[i-1].SetWidth(15f, 15f);
				newLine[i-1].material = new Material(Shader.Find("Sprites/Default"));
				newLine[i-1].SetColors(c1, c2);
				newLine[i-1].SetPosition(0, points[i-1]);
                newLine[i-1].SetPosition(1, points[0]);
				UIController.newLine.Add(newLine[i-1]);
				UIController.allobj.Add(line);
				foreach (Vector2 point in points)
				{
					UIController.CurrentFloor.WallPoints.Add(point);
				}
				i++;
		} else if (Input.GetKeyDown(door)) {
			UIController.HideLines(true);
			var point = Instantiate(baseDoor, panel.transform);
			point.transform.position = objPosition;
			UIController.allobj.Add(point.gameObject);
			UIController.objectPosition = objPosition;
			UIController.CurrentPanel = Instantiate(AuditPanel,Mainpanel.transform);
			UIController.gm.SetActive(false);				
		} else if (Input.GetKeyDown(stair)) {
			UIController.HideLines(true);
			var point = Instantiate(baseStair, panel.transform);
			point.transform.position = objPosition;
			UIController.allobj.Add(point.gameObject);
			UIController.objectPosition = objPosition;
			UIController.CurrentPanel = Instantiate(StairPanel,Mainpanel.transform);
			UIController.gm.SetActive(false);
		} else if (Input.GetKeyDown(elevator)) {
			var point = Instantiate(baseElevator, panel.transform);
			point.transform.position = objPosition;
		} else if (Input.GetKeyDown(place)) {
			UIController.HideLines(true);
			var point = Instantiate(basePlace, panel.transform);
			point.transform.position = objPosition;
			UIController.allobj.Add(point.gameObject);
			UIController.objectPosition = objPosition;
			UIController.CurrentPanel = Instantiate(PlacePanel,Mainpanel.transform);
			UIController.gm.SetActive(false);
		} else if (Input.GetKeyDown(delete)) {
		} 
    }
}
