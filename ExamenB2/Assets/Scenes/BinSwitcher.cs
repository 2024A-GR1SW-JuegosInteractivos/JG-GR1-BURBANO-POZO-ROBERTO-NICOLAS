using UnityEngine;

public class BinSwitcher : MonoBehaviour
{
    public SpriteRenderer binRenderer; // Reference to the SpriteRenderer component of the trash bin
    public Sprite[] binSprites; // Array of sprites corresponding to different waste categories

    private int currentBinIndex = 0;

    void Start()
    {
        binRenderer.sprite = binSprites[currentBinIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SwitchBin();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SwitchBin(-1);
        }
    }

    void SwitchBin(int r = 1)
    {
        if (currentBinIndex + r<0){
            currentBinIndex = binSprites.Length;
        }
        currentBinIndex = (currentBinIndex + r) % binSprites.Length;
        binRenderer.sprite = binSprites[currentBinIndex];
    }
}
