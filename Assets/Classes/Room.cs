using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Room
{
	public int id = 0;
	public string name = "";
	public string description = "";
	public Vector2 placement = new Vector2 ();
	public List<Schedule> ScheduleList = new List<Schedule>();
}
