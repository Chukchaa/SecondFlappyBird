using UnityEngine;

[CreateAssetMenu(fileName = "SkinConfig", menuName = "FlappyBird/SkinConfig")]
public class SkinConfig : ScriptableObject
{
    public int Index;
    public int Price;
    public Sprite Sprite;
}
