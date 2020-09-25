using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Building
{
	public int id = 0;
	public string name = "";
	public int floorsNumber = 0;
	public string description = "";
	public List<Floor> floorList = new List<Floor>();
}
