using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameScene : MonoBehaviour {

    public Vector2 scrollPosition = Vector2.zero;

    // Use this for initialization
    void Start() {

    }

    void OnGUI() {
        GUI.Box(new Rect(0, 0, commonS.ScreenWidth, commonS.ScreenHeight), "");
        scrollPosition = GUI.BeginScrollView(new Rect(0, 0, commonS.scrollWidth, commonS.scrollHeight),
            scrollPosition, new Rect(0, 0, commonS.scrollWidth, commonS.scrollHeight));
        GUI.TextArea(new Rect(0, 0, commonS.scrollWidth, commonS.scrollHeight), commonS.info);
        GUI.EndScrollView();

        if ( GUI.Button(new Rect(commonS.scrollWidth * 1.1f, commonS.ScreenHeight * 0.1f,
            commonS.normalButtonWidth, commonS.normalButtonHeight), "About TaiDou") ) {
            commonS.info = commonS.info_shequ;
        }
        if ( GUI.Button(new Rect(commonS.scrollWidth * 1.1f, commonS.ScreenHeight * 0.3f,
            commonS.normalButtonWidth, commonS.normalButtonHeight), "About Taikr") ) {
            commonS.info = commonS.info_tak;
        }
        if ( GUI.Button(new Rect(commonS.scrollWidth * 1.1f, commonS.ScreenHeight * 0.5f,
            commonS.normalButtonWidth, commonS.normalButtonHeight), "About taikredu") ) {
            commonS.info = commonS.info_edu;
        }

        if ( GUI.Button(new Rect(commonS.scrollWidth * 1.1f, commonS.ScreenHeight * 0.7f,
            commonS.normalButtonWidth, commonS.normalButtonHeight), "Back Menu") ) {
            SceneManager.LoadScene("mainMenu");
        }
    }

}
