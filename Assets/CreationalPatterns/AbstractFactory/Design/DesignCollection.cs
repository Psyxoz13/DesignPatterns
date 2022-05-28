using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Design Collection")]
public class DesignCollection : ScriptableObject
{
    [SerializeField] private DesignCollectionItem[] _designCollectionItems;

    private Dictionary<string, Sprite> _designCollection = new Dictionary<string, Sprite>();

    private void OnEnable()
    {
        for (int i = 0; i < _designCollectionItems.Length; i++)
        {
            var item = _designCollectionItems[i];

            _designCollection.Add(item.Name, item.DesignSprite);
        }
    }

    public Sprite GetDesign(string name)
    {
        return _designCollection[name];
    }
}

[System.Serializable]
public struct DesignCollectionItem
{
    public string Name;
    public Sprite DesignSprite;
}