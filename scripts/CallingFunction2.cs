using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingFunction2 : MonoBehaviour {
	
	public ColorChanger2 _ColorChanger2;

	void OnMouseDown()
	{
		_ColorChanger2.SwapTexture ();
			}
}
