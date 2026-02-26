using UnityEngine;
using DG.Tweening;
public class PopIn : MonoBehaviour
{
    void Start()
    {
        Invoke("DelayAnimation", Random.Range(0.1f,0.8f));
    }

    //DoTween interpreteerd elke regel als een animatie die tegelijk uitgevoerd moet worden.
    void DelayAnimation()
    {
        float randomTime = Random.Range(0.1f, 0.4f);
        transform.DOLocalMoveY(400f, randomTime).SetEase(Ease.OutBounce);
        transform.DORotate(new Vector3(0, 0, 360), randomTime, RotateMode.LocalAxisAdd).SetEase(Ease.OutQuart);
    }

    

}
