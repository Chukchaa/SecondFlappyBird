using UnityEngine;
using VContainer;

public class AnimationController : MonoBehaviour
{
    private int _characterConfigLength;

    public Animator BirdAnimator { get; set; }

    [Inject]
    public void Construct(CharacterConfigBase characterConfig)
    {
        _characterConfigLength = characterConfig.GetLength();
    }

    public void PlayAnimation(int index)
    {
        BirdAnimator.enabled = true;

        if (BirdAnimator.isActiveAndEnabled == true)
        {
            switch (index)
            {
                case 0:
                    BirdAnimator.SetTrigger("DefaultBird");
                    break;
                case 1:
                    BirdAnimator.SetTrigger("YellowBird");
                    break;
                case 2:
                    BirdAnimator.SetTrigger("BrownBird");
                    break;
                case 3:
                    BirdAnimator.SetTrigger("BlueBird");
                    break;
                case 4:
                    BirdAnimator.SetTrigger("GrayBird");
                    break;
                case 5:
                    BirdAnimator.SetTrigger("GreenBird");
                    break;
                case 6:
                    BirdAnimator.SetTrigger("PinkBird");
                    break;
                default:
                    Debug.LogError($"{nameof(AnimationController)}. {nameof(PlayAnimation)}. " +
                        $"Данного индекса не существует");
                    break;
            }
        }
        else
        {
            Debug.LogError($"{nameof(AnimationController)}. {nameof(PlayAnimation)}. Аниматор отключен");
        }
    }
}
