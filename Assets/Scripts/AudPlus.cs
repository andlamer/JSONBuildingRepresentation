using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudPlus : MonoBehaviour
{
	public GameObject m_lessonItem;
	public Transform m_content;
	public static List<GameObject> myList = new List<GameObject>();
	public static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void AddLesson(){
		if (i < 36) {
			GameObject plus = Instantiate(m_lessonItem) as GameObject;
			plus.transform.SetParent(m_content,false);
			plus.SetActive(true);
			myList.Add(plus);
			i++;
		}
	}
}