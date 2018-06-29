using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
	public GameObject MenuCanvas , SettingCanvas ;
	void Start () {
		MenuCanvas.SetActive(true);
		SettingCanvas.SetActive(false);
	}
	public void LoadLevel(int a){
		SceneManager.LoadScene(a);
	}
	public void Quit(){
		Application.Quit();
	}
	public void Setting(){
		MenuCanvas.SetActive(false);
		SettingCanvas.SetActive(true);
	}
	public void Settings_backButton(){
		MenuCanvas.SetActive(true);
		SettingCanvas.SetActive(false);
	}
}
