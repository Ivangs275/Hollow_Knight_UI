using DG.Tweening;
using System.Collections;
using UnityEngine;

public class GroupTween : MonoBehaviour
{


    void Start()
    {
        foreach (Transform child in transform)
        {
            StartCoroutine(DelayAnimation(child));

        }
    }

        //DoTween interpreteerd elke regel als een animatie die tegelijk uitgevoerd moet worden.
        IEnumerator DelayAnimation(Transform child)
    {
             yield return new WaitForSeconds(Random.Range(0.1f,0.8f));

            float randomTime = Random.Range(0.1f, 0.4f);
            child.DOLocalMoveY(400f, randomTime).SetEase(Ease.OutBounce);
            child.DORotate(new Vector3(0, 0, 360), randomTime, RotateMode.LocalAxisAdd).SetEase(Ease.OutQuart);
        
    }
}
