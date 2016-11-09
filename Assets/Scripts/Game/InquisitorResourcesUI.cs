using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InquisitorResourcesUI : MonoBehaviour
{
    public InquisitorResources Resources;
    public Text GoldText;
    public Text InfluenceText;
    public Text SanityText;
    void Start()
    {
        lastGold = Resources.Gold - 1;
        lastInfluence = Resources.Influence - 1;
        lastSanity = Resources.Sanity - 1;
    }
    public int lastGold;
    public int lastInfluence;
    public int lastSanity;
    void Update()
    {
        if (Resources.Gold != lastGold)
        {
            GoldText.text = Resources.Gold.ToString();
            lastGold = Resources.Gold;
        }
        if (Resources.Influence != lastInfluence)
        {
            InfluenceText.text = Resources.Influence.ToString();
            lastInfluence = Resources.Influence;
        }
        if (Resources.Sanity != lastSanity)
        {
            SanityText.text = Resources.Sanity.ToString();
            lastSanity = Resources.Sanity;
        }
    }
}
