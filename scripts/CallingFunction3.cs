using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingFunction3 : MonoBehaviour {
	
	public ColorChanger3 _ColorChanger3;

	void OnMouseDown()
	{
		_ColorChanger3.SwapTexture ();
			}
}
