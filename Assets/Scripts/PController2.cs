using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController2 : MonoBehaviour
{
    private List<int> inputValues = new List<int>();
    private int[] code = { 2, 0, 0, 1 };

    [SerializeField] private GameObject objectToDisable;

    public void ButtonClicked(int buttonNumber)
    {
        inputValues.Add(buttonNumber);

        if (inputValues.Count == code.Length && CheckCode())
        {
            objectToDisable.SetActive(false);
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
}
