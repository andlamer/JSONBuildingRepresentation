using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stair
{
	public int id = 0;
	public int NextFloorId = 0;
	public int PrevFloorId = 0;
	public int NextStairId = 0;
	public int PrevStairId = 0;
	public Vector2 placement = new Vector2 ();
	
}
