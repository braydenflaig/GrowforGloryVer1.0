using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotStats2 : MonoBehaviour
{
    public int plotScore;
    public Text plotTotal;


    // Start is called before the first frame update
    void Start()
    {
        //sets the score of the plot to zero at the start
        plotScore = 0;
        //grabs the text compenet of the prot_total_2 game object
        plotTotal = GameObject.Find("plot_total_2").GetComponent<Text>();
        // sets the plot total text
        plotTotal.text = plotScore.ToString();
    }

    public void multiplyTotal(int multVal)
    {
        plotScore = (plotScore * multVal);
    }

    // Update is called once per frame
    void Update()
    {
        //sets the plot total text to display the plot score
        plotTotal.text = plotScore.ToString();
    }
    public void IncreaseTotal(int increase)
    {
        //increments the plot score so by the entered amount 
        plotScore = (plotScore + increase);
    }

    public int getPlotScore()
    {
        return plotScore;
    }
}