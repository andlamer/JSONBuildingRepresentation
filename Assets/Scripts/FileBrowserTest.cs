using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using SimpleFileBrowser;
using Newtonsoft.Json;
using System.IO;

public class FileBrowserTest : MonoBehaviour
{
	// Warning: paths returned by FileBrowser dialogs do not contain a trailing '\' character
	// Warning: FileBrowser can only show 1 dialog at a time

	public void OnLoadButtonClick()
	{
		if (UIController.currentfloor < UIController.building.floorsNumber)
		{
			if (UIController.currentfloor != 0) UIController.building.floorList.Add(UIController.CurrentFloor);
			UIController.currentfloor ++;
			Floor newFloor = new Floor();
			newFloor.id = UIController.floorId++;
			newFloor.num = UIController.currentfloor;
			UIController.CurrentFloor = newFloor;
			
			FileBrowser.SetFilters( true, new FileBrowser.Filter( "Images", ".jpg", ".png" ));
			FileBrowser.SetDefaultFilter( ".jpg" );
			FileBrowser.SetExcludedExtensions( ".lnk", ".tmp", ".zip", ".rar", ".exe" );
			FileBrowser.AddQuickLink( "Users", "C:\\Users", null );
			StartCoroutine( ShowLoadDialogCoroutine() );
			foreach (var obj in UIController.allobj)
			{
				Destroy(obj);
			}
			DrawLines.points.Clear();
			DrawLines.lines.Clear();
			DrawLines.newLine.Clear();
			UIController.newLine.Clear();
			UIController.allobj.Clear();
			DrawLines.i = 0;
		}
		else
		{
			UIController.building.floorList.Add(UIController.CurrentFloor);
			string name = UIController.building.name + ".json";
			//StreamWriter writer = new StreamWriter(name, true);
			string json = JsonConvert.SerializeObject(UIController.building, Formatting.Indented);
			System.IO.File.WriteAllText(@name, json);
			//writer.Write(json);
			Debug.Log(json);
		}
	}

	IEnumerator ShowLoadDialogCoroutine()
	{
		yield return FileBrowser.WaitForLoadDialog( false, null, "Load File", "Load" );
		Debug.Log( FileBrowser.Success );
		string pathF = "";
		if( FileBrowser.Success )
		{
			Texture2D texture;
			//string result = System.Text.Encoding.UTF8.GetString(FileBrowser.Result[0]);
			texture = new Texture2D(4, 4, TextureFormat.DXT1, false);
			string path = "file:///" + FileBrowser.Result;
			WWW www = new WWW(path);
			www.LoadImageIntoTexture(texture);
			Sprite spr = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
			UIController.PlanePanel.GetComponent<Image>().sprite = spr;
		
		}
	}
}