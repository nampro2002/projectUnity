using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public int bananaCount;
    public int appleCount;
    public int bombCount;
    public int bananaPoint;
    public int applePoint;
    public int bombPoint;
    public int totalPoint;
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Text textElement;
    void Start()
    {
        bananaCount = 0;
        appleCount = 0;
        bombCount = 0;
        bananaPoint = 10 ;
      applePoint =5;
      bombPoint = -20;
        totalPoint = 0;
        textElement.text = "Banana: " + bananaCount.ToString() + "\nApple: " + appleCount.ToString()
              + "\nBomb: " + bombCount.ToString()
                 + "\nTotal: " + totalPoint.ToString(); ;
    }

    // Update is called once per frame
    void Update()
    {
        if(totalPoint < 0)
        {
            Time.timeScale = 0;
        }
    }
    public void UpdateBanana()
    {
        bananaCount++;
        UpdatePoint();
        textElement.text = "Banana: " + bananaCount.ToString() + "\nApple: "
            + appleCount.ToString() + "\nBomb: " + bombCount.ToString()
            + "\nTotal: " + totalPoint.ToString();
            ;
    }
    public void UpdateBomb()
    {
        bombCount++;
        UpdatePoint();
        textElement.text = "Banana: " + bananaCount.ToString() + "\nApple: " + appleCount.ToString()
            + "\nBomb: " + bombCount.ToString()
               + "\nTotal: " + totalPoint.ToString();
        ;
    }
    public void UpdateAplle()
    {
        appleCount++;
        UpdatePoint();
        textElement.text = "Banana: " + bananaCount.ToString() + "\nApple: " + appleCount.ToString() 
            + "\nBomb: " + bombCount.ToString()
               + "\nTotal: " + totalPoint.ToString();
        ;
    }
    public void UpdatePoint(){ 
        totalPoint = appleCount * applePoint + bombCount * bombPoint + bananaCount * bananaPoint;
    }
}
