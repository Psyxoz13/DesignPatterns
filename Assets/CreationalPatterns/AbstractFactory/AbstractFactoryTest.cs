using UnityEngine;

public class AbstractFactoryTest : MonoBehaviour
{
    [SerializeField] private NPC _npcPrefab;
    [SerializeField] private DesignCollection _npcDesignCollection;

    private void Start()
    {
        var npcCowboy = Instantiate(
            _npcPrefab,
            Vector3.left * 5f,
            Quaternion.identity,
            transform);
        npcCowboy.Init(new JumpingCowboyNPC(_npcDesignCollection));

        var npcBird = Instantiate(
            _npcPrefab,
            Vector3.right * 5f,
            Quaternion.identity,
            transform);
        npcBird.Init(new LoopStreifBirdNPC(_npcDesignCollection));
    }
}
