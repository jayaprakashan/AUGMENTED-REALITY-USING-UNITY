using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clickObject : MonoBehaviour
{
    private Text label;
    // Start is called before the first frame update
    void Start()
    {
        label = GameObject.Find("Label Name").GetComponent<Text>();
        label.text = "";

    }

    private void OnMouseOver()
    {
        label.text = gameObject.name.ToString();
    }

}
