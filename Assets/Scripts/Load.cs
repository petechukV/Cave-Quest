using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour {

    public int sceneID;
    public Image loadImg;
    public Text progressText;
	
	void Start ()
    {
        StartCoroutine(SLoad());
	}

    IEnumerator SLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loadImg.fillAmount = progress;
            progressText.text = string.Format("{0:0.0}%", progress * 100);
            yield return null;
        }
    }
}
