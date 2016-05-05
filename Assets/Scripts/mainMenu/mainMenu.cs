using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    [SerializeField]
    private Texture background;

    private GUIStyle style;

    private int screenWidth;
    private int screenheight;

    void Awake() {
        commonS.ScreenWidth = Screen.width;
        commonS.ScreenHeight = Screen.height;

        style = new GUIStyle();
        style.fontSize = 100;
		style.normal.textColor = Color.blue;
    }
    void OnGUI() {
        GUI.DrawTexture(new Rect(0, 0, commonS.ScreenWidth, commonS.ScreenHeight), background,ScaleMode.ScaleToFit);
        GUI.Box(new Rect((commonS.ScreenWidth - "TaiDou".Length*style.fontSize/2) / 2, commonS.ScreenHeight * 0.1f, commonS.ScreenWidth, commonS.ScreenHeight), "TaiDou", style);
        if(GUI.Button(new Rect((commonS.ScreenWidth - commonS.normalButtonWidth) / 2, commonS.ScreenHeight * 0.4f, commonS.normalButtonWidth,commonS.normalButtonHeight),"Let's go")){
            SceneManager.LoadScene("game");
        }
        if ( GUI.Button(new Rect((commonS.ScreenWidth - commonS.normalButtonWidth) / 2, commonS.ScreenHeight * 0.6f, commonS.normalButtonWidth, commonS.normalButtonHeight), "Quit") ) {
            Application.Quit();
        }
    }
}
