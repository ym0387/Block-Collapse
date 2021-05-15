using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ClearUI;
    public GameObject GameOverUI;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Player").Length;

        if (count == 0)
        {
            // ClearUIをアクティブにする
            ClearUI.SetActive(true);

            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);

            if (Input.GetMouseButton(0))
            {
                Restart();
            }
        }

        if (count1 == 0)
        {
            //GameOverUIをアクティブにする
            GameOverUI.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                Restart();
            }
        }

    }

    //シーンを再読み込みする
    private void Restart()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);



    }
}
