using UnityEngine;

[System.Serializable]
public struct ItemData
{
    [SerializeField]
    public string name;
    [SerializeField]
    public string description;
    [SerializeField]
    public Sprite sprite;
    [SerializeField]
    public int quantity;


    public override bool Equals(object obj)
    {
        if (!(obj is ItemData))
            return false;

        ItemData data = (ItemData)obj;

        return name.Equals(data.name);

    }
}
