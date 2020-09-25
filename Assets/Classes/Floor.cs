using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Floor
{
	public int id = 0;
	public int num = 0;
	public List<Vector2> WallPoints = new List<Vector2>();
	public Vector2 grid = new Vector2 (100,100);
	public int scale = 15;
	public List<Room> RoomList = new List<Room>();
	public List<Stair> StairList = new List<Stair>();
	public List<Place> PlaceList = new List<Place>();
}
