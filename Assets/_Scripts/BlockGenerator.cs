using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public List<GameObject> smallBlocks;
    public List<GameObject> largeBlocks;

    public int blocksToGenerate=12;
    int blockNumber = 1;
    System.Random rand = new System.Random();

    private void Awake()
    {

        for (int i=0;i<blocksToGenerate;i++)
        {
            int smallBlockToGenerate = rand.Next(0,smallBlocks.Count);
            GameObject smallBlock = GameObject.Instantiate(smallBlocks[smallBlockToGenerate]); 
            smallBlock.GetComponent<Block>().SetBlockNumberAndSpawn(blockNumber,transform,true);

            int largeBlockToGenerate = rand.Next(0,largeBlocks.Count);
            GameObject largeBlock = GameObject.Instantiate(largeBlocks[largeBlockToGenerate]); 
            largeBlock.GetComponent<Block>().SetBlockNumberAndSpawn(blockNumber,transform,false);

            blockNumber++;

        }
    }
}
