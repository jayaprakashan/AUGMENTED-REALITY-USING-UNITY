using UnityEngine;
using System.Collections;

public class ColorChanger1 : MonoBehaviour {
	public Texture[] textures;
	public int currentTexture;
	public int Color1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void SwapTexture() 
	{ 
		Debug.Log ("Texture is swaped!!!!!!");
		currentTexture++;
		currentTexture %= textures.Length;
        GetComponent<Renderer>().material.mainTexture = textures[Color1]; 
	}
}
