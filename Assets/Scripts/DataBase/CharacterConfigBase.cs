using UnityEngine;

public class CharacterConfigBase : MonoBehaviour
{
    [SerializeField] private SkinConfig[] _skinConfigs;

    public int GetLength() => _skinConfigs.Length;

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
            $" ������� {index} �� ����������");

        return _skinConfigs[0];
    }
}
