using System.Collections;
using UnityEngine;
using System;

public class DataAnimatedCurve : MonoBehaviour {
    [SerializeField] AnimationCurve animationCurve;
    //[SerializeField] GameObject character;
    [SerializeField] GameObject go;
    [SerializeField] TextAsset dataFileAsset;

    private float curveDeltaTime;
    private int iEndTime;
    //private FaceController FC;

    void Start() {
        //FC = character.GetComponent<FaceController>();

        curveDeltaTime = 0f;

        Debug.Assert(dataFileAsset != null);
        var dataLines = dataFileAsset.text.Split('\n'); // Split also works with simple arguments, no need to pass char[]
        int iTime = 0;
        float fValue = 0;
        for (int i = 1; i < dataLines.Length; i++) { // assuming we have a header
            if (dataLines[i].Length > 0) {
                var data = dataLines[i].Split(',');
                iTime = Convert.ToInt16(data[0]);
                fValue = Convert.ToSingle(data[1]);
                animationCurve.AddKey(iTime, fValue);
//                Debug.Log("iEndTime: " + iEndTime + " Value: " + fValue);
                iEndTime = iTime;
            }
        }
    }

    
    public void StartDataPlayback() {
        Debug.Log("StartAnimationCurve");
        StartCoroutine(RunAnimationCurve());
    }

    private IEnumerator RunAnimationCurve() {
        while (curveDeltaTime < iEndTime) {
            curveDeltaTime += Time.deltaTime;
            float fValue = animationCurve.Evaluate(curveDeltaTime);
            //Debug.Log("Time " + curveDeltaTime + " value: " + fValue);
            fValue /= 100f;
            //TEMP FC.setCategoricalEmotion("Anger", fValue);
            go.transform.localScale = new Vector3(fValue, fValue, fValue);

            yield return null;
        }
    }




}