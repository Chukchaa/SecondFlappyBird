using UnityEngine;

public class CharacterConfigBase : MonoBehaviour
{
    [SerializeField] private SkinConfig[] _skinConfigs;

    public SkinConfig GetConfig(int index)
    {
        foreach (SkinConfig skinConfig in _skinConfigs)
        {
            if(skinConfig.Index == index)
            {
                return skinConfig;
            }
        }

        Debug.LogError($"{nameof(CharacterConfigBase)}. {nameof(GetConfig)}." +
            $" Индекса {index} не существует");

        return _skinConfigs[0];
    }
}
