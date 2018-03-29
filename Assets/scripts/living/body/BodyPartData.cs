using UnityEngine;

[System.Serializable]
public struct BodyPartData
{
    [SerializeField]
    public string name;
    [SerializeField]
    public string description;
    [SerializeField]
    public int startingHealth;
    [SerializeField]
    public Sprite sprite;
    [SerializeField]
    public Transform attachPoint;
}
