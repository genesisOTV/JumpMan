using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyAudio : MonoBehaviour {

    private static DontDestroyAudio instance = null;

    Scene currentScene;
    string sceneName;

	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static DontDestroyAudio Instance
    {
        get
        {
            return instance;
        }
    }

	/*void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("music");
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);         
    }*/

    void Awake()
	{
        GameObject[] obj = GameObject.FindGameObjectsWithTag("music");
        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
	}
}
