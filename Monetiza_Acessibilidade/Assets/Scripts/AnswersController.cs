using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswersController : MonoBehaviour
{
    [SerializeField] GameObject feedback;
    private Animator anim;

    void Start()
    {
        anim = feedback.GetComponent<Animator>();

        anim.SetTrigger("FadeIn");
    }

    public void CheckAnswer(bool rightOrWrong)
    {
        if (rightOrWrong == true)
        {
            //Resposta Certa
            StartCoroutine(RightAwnser());
        }
        else
        {
            anim.SetTrigger("Wrong");
        }
    }

    IEnumerator RightAwnser()
    {
        anim.SetTrigger("Right");
        Debug.Log("Tentando");

        yield return new WaitForSeconds(0.5f);

        anim.SetTrigger("FadeOut");

        yield return new WaitForSeconds(0.5f);

        int curScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curScene + 1);
    }
}
