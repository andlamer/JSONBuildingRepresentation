using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseSaveAud : MonoBehaviour
{
	public GameObject num;
	public GameObject name;
	public GameObject description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void SaveAndClose()
	{
		Room newRoom = new Room();
		newRoom.id = UIController.roomId++;
		newRoom.name = name.GetComponent<InputField>().text;
		newRoom.description = description.GetComponent<InputField>().text;
		newRoom.placement = UIController.objectPosition;
		
		ScheduleScript[] lessonList = UIController.CurrentPanel.GetComponentsInChildren<ScheduleScript>();
		foreach (ScheduleScript lesson in lessonList) {
			Schedule newLesson = new Schedule();
			newLesson.id = UIController.scheduleId++;
			newLesson.num = lesson.getNumber();
			newLesson.name = lesson.getName();
			newLesson.day = lesson.getDay();
			newLesson.group = lesson.getGroup();
			newLesson.teacher = lesson.getTeacher();
			newRoom.ScheduleList.Add(newLesson);
		}
		
		UIController.CurrentFloor.RoomList.Add(newRoom);
		Destroy(UIController.CurrentPanel);
		UIController.gm.SetActive(true);
		UIController.HideLines(false);
		AudPlus.i = 0;
	}
}
