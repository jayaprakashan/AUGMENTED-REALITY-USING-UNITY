using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class SceneviewcameraTest : MonoBehaviour
{
   [MenuItem("Test/Move Scene view Camera")]
   static public void MoveSceneViewCamera()
    {
        Vector3 position = SceneView.lastActiveSceneView.pivot;
        position.z -= 10.0f;

        SceneView.lastActiveSceneView.pivot = position;
        SceneView.lastActiveSceneView.Repaint();

    }
}
