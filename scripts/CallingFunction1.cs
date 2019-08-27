using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingFunction1 : MonoBehaviour {
	
	public ColorChanger1 _ColorChanger1;

	void OnMouseDown()
	{
		_ColorChanger1.SwapTexture ();
			}
}
