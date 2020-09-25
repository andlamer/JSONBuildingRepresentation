using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BuildingPublic
{
    public int m_id = 0;
	public string m_name = "";
	public int m_floorsNumber = 0;
	public string m_description = "";
	public List<Floor> floorList = new List<Floor>();
}
