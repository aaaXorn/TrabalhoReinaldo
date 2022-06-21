using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    private Image img;
    [SerializeField]
    private Text txt;

    private void Start()
    {
        StartCoroutine(LoadAsync(StaticVars.next_scene));
    }

    private IEnumerator LoadAsync(string sceneIndex)
    {
        //faz o load scene de forma assincrona
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        //enquanto o load scene nao acaba
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            //mostra o progresso da operacao
            img.fillAmount = progress;
            txt.text = progress * 100f + "%";

            yield return null;
        }

        yield break;
    }
}
