using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
public class popup : MonoBehaviour
{
    private Text Label;

    // Start is called before the first frame update
    void Start()
    {

        Label l2 = new Label();
        Label = GameObject.Find("LabelName").GetComponent<Text>();
        Label.text = "";

        l2.text = "This is Yamaha ";
    }
    private void OnMouseOver()
    {
        Label.text = gameObject.name.ToString();
    }

}
