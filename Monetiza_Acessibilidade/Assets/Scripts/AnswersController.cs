using UnityEngine;

public class AnswersController : MonoBehaviour
{
    public void CheckAnswer(bool rightOrWrong)
    {
        if (rightOrWrong)
            Debug.Log($"Resposta certa!");
        else
            Debug.Log($"Resposta errada!");
    }
}
