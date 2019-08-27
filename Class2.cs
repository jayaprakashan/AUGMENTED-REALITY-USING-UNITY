using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Class2 : MonoBehaviour
{

      void Start()
        {
            Label l2 = new Label();
            l2.Text = "This is a new Label";
            l2.BorderStyle = BorderStyle.Solid;
            Page.Controls.Add(l2);
        }
       
    
}