using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject feedback;
    private Animator anim;

    void Start()
    {
        anim = feedback.GetComponent<Animator>();

        anim.SetTrigger("FadeIn");
    }

    public void Play()
    {
        StartCoroutine(PlayGame());
    }

    public void Exit()
    {
        StartCoroutine(ExitGame());
    }

    IEnumerator PlayGame()
    {
        anim.SetTrigger("FadeOut");

        yield return new WaitForSeconds(0.5f);

        int curScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curScene + 1);
    }

    IEnumerator ExitGame()
    {
        anim.SetTrigger("FadeOut");

        yield return new WaitForSeconds(0.5f);

        Application.Quit();
    }
}
