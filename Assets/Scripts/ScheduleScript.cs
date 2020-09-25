using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScheduleScript : MonoBehaviour
{
	public GameObject m_number;
	public GameObject m_day;
	public GameObject m_group;
	public GameObject m_teacher;
	public GameObject m_name;
	
	private int m_scheduleNumber;
	private string m_scheduleDay;
	private string m_scheduleGroup;
	private string m_scheduleTeacher;
	private string m_scheduleName;
	
    // Start is called before the first frame update
    void Start()
    {
        m_scheduleDay = m_day.GetComponent<Dropdown>().options[m_day.GetComponent<Dropdown>().value].text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onNumberUpdate() {
		m_scheduleNumber = int.Parse(m_number.GetComponent<InputField>().text);
	}
	
	public void onDayUpdate() {
		Dropdown dropdown = m_day.GetComponent<Dropdown>();
		m_scheduleDay = dropdown.options[dropdown.value].text;
	}
	
	public void onGroupUpdate() {
		m_scheduleGroup = m_group.GetComponent<InputField>().text;
	}
	
	public void onTeacherUpdate() {
		m_scheduleTeacher = m_teacher.GetComponent<InputField>().text;
	}
	public void onNameUpdate() {
		m_scheduleName = m_name.GetComponent<InputField>().text;
	}
	public int getNumber() {
		return m_scheduleNumber;
	}
	
	public string getDay() {
		return m_scheduleDay;
	}
	public string getGroup() {
		return m_scheduleGroup;
	}
	public string getTeacher() {
		return m_scheduleTeacher;
	}
	public string getName() {
		return m_scheduleName;
	}
}
