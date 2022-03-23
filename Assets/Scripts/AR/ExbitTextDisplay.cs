using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExbitTextDisplay : MonoBehaviour
{
    public Text exhibitText;



    public int x=0;

    public void SetText()
    {

        if (x == 0) {
            exhibitText.text = "High Park has 399 acres of land with forested areas, creeks and the largest pond in Toronto. A wide variety of wildlife live in High Park including birds, fish, mammals, amphibians and reptiles. ";
            x++;
        }
        else if (x == 1) {
            exhibitText.text = "Over 150 species of birds are seen in the park throughout the year. Migrating birds stop here during the spring and fall seasons. The most species of birds High Park has seen is over 260. ";
            x++;
        }
        else if (x == 2)
        {
            exhibitText.text = "Some species include Ring-billed Gulls, Mallards, Mute Swans, Canada Geese, Starlings, House Sparrows, Rock Pigeons, Mourning Doves and Crows. ";
            x++; 
        }
        else if (x == 3) { 
            exhibitText.text = "In December 2021 an annual High Park Christmas Bird count was held which recorded a total of 46 species and 3,961 individuals. A northern Mockingbird was sighted which was the first one for this count area since 2011. ";
        x++;
        }
        else if (x == 4)
        {
            exhibitText.text = "There have been at least 71 species of butterflies spotted in High Park since the 1980s. Many adult butterflies get nectar from a black oak savannah and use it to host plants for the caterpillars.";
            x++;
        }
        else if (x == 5)
        {
            exhibitText.text = "Some of the species found here are Delaware and Crossline Skippers, Eastern Tiger Swallowtail and Spicebush Swallowtail, Banded Hairstreak and Edwards Hairstreak, Northern Cloudywing, Eastern Tailed-Blue and Silvery Checkerspot. ";
            x++;
        }
        else if (x == 6)
        {
            exhibitText.text = "The ornamental gardens are filled with butterflies during late summer and fall such as migrating Monarchs, Red Admirals, Question Marks and Painted Ladies because of the nectar-rich sources like butterfly bush.";
            x++;
        }
        else if (x == 7)
        {
            exhibitText.text = "Thanks For Coming!";
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



