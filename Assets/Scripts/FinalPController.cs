using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Added to use SceneManager

public class FinalPController : MonoBehaviour
{
    private List<int> inputValues = new List<int>();
    private int[] code = { 3, 5, 2, 1 };


    public void ButtonClicked(int buttonNumber)
    {
        inputValues.Add(buttonNumber);

        if (inputValues.Count == code.Length && CheckCode())
        {
            SwitchToEndScene();
        }
    }

    private bool CheckCode()
    {
        for (int i = 0; i < code.Length; i++)
        {
            if (inputValues[i] != code[i])
            {
                inputValues.Clear();
                return false;
            }
        }

        inputValues.Clear();
        return true;
    }

    private void SwitchToEndScene()
    {
        SceneManager.LoadScene("End");
    }
}
