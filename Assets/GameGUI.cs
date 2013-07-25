using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

    public int leftScore;
    public int rightScore;
    public GUIStyle leftScoreStyle;
    public GUIStyle rightScoreStyle;

    void OnGUI () {
        // Left Score 
        GUIContent leftContent = new GUIContent(leftScore.ToString());
        GUI.Label(new Rect(120,20,100,20), leftContent, leftScoreStyle);

        // Right Score 
        GUIContent rightContent = new GUIContent(rightScore.ToString());
        GUI.Label(new Rect((Screen.width - 120),20,100,20), rightContent, rightScoreStyle);
    }
}
