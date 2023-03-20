using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitThenLoadMainScene());
    }

    IEnumerator WaitThenLoadMainScene()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Main");
    }
}