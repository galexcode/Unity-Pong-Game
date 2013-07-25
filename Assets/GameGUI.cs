using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

    public GUIStyle leftScoreStyle;
    public GUIStyle rightScoreStyle;

    private int leftScore = 0;
    private int rightScore = 0;

    void OnGUI () {
        int textBoxSize = 20;
        int screenTopMargin = 80;
        int screenSideMargin = 240;
        // Left Score 
        GUIContent leftContent = new GUIContent(leftScore.ToString());
        GUI.Label(
            new Rect(
                screenSideMargin,
                screenTopMargin,
                textBoxSize,
                textBoxSize),
            leftContent,
            leftScoreStyle);

        // Right Score 
        GUIContent rightContent = new GUIContent(rightScore.ToString());
        GUI.Label(
            new Rect(
                (Screen.width - screenSideMargin - textBoxSize),
                screenTopMargin,
                textBoxSize,
                textBoxSize),
            rightContent,
            rightScoreStyle);
    }

    public void IncLeftScore () {
        leftScore += 1;
    }

    public void IncRightScore () {
        rightScore += 1;
    }
}
