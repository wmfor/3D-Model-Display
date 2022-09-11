using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraControl : MonoBehaviour
{
    public int curIndex;
    //public int[] values;
    //public string[] names;

    [NonReorderable]public Positions[] positions;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI progressText;


    public void Next()
    {
        if (curIndex + 1 != positions.Length)
            curIndex++;

        nameText.text = positions[curIndex].name;
        progressText.text = (curIndex + 1) + "/" + positions.Length;
        transform.position = new Vector3(transform.position.x, transform.position.y, positions[curIndex].value);
    }

    public void Last()
    {
        if(curIndex != 0)
            curIndex--;

        nameText.text = positions[curIndex].name;
        progressText.text = (curIndex + 1) + "/" + positions.Length;
        transform.position = new Vector3(transform.position.x, transform.position.y, positions[curIndex].value);
    }
}

[System.Serializable]
public struct Positions
{
    public int value;
    public string name;
}
