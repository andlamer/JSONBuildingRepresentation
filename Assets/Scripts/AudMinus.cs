using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudMinus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void DelLesson() {
		if (AudPlus.i == 0 ) {
			
		} else {	
			Destroy(AudPlus.myList[AudPlus.myList.Count - 1]);
			AudPlus.myList.RemoveAt(AudPlus.myList.Count - 1);
			AudPlus.i -= 1;
		}
	}
}
