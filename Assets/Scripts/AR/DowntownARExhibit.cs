using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DowntownARExhibit : MonoBehaviour
{
    public Text exhibitTextTower;



    public int x = 0;

    public void SetText()
    {

        if (x == 0)
        {
            exhibitTextTower.text = "Construction of the CN Tower started in 1973 and was opened to the public in 1976. In total it took 40 months to build and involved more than 1,500 workers.";
            x++;
        }
        else if (x == 1)
        {
            exhibitTextTower.text = "The CN Tower is 1,815 feet (553 meters) tall. It was the tallest building in the world for 32 years (1975 – 2007). ";
            x++;
        }
        else if (x == 2)
        {
            exhibitTextTower.text = "The CN Tower was privately owned by the Canadian National Railway company until 1995 when it was transferred to the Canadian government to be made a public company. Now the Canadian Lands Company owns and manages it. ";
            x++;
        }
        else if (x == 3)
        {
            exhibitTextTower.text = "The Canadian National Railway company built the CN Tower as a radio tower to solve communication issues. It provided Toronto with the clearest reception for radio, television, and communication waves in North America. ";
            x++;
        }
        else if (x == 4)
        {
            exhibitTextTower.text = "The antenna on the very top of the CN Tower was built in 44 pieces. They used the Sikorsky S-64 Skycrane helicopter to bring each piece up to the top. ";
            x++;
        }
        else if (x == 5)
        {
            exhibitTextTower.text = "They placed a time capsule in the wall of the building’s LookOut level during the grand opening in 1976. Inside of the time capsule there are copies of three local newspapers, Canadian coins, letters from children, and a letter from then-Canadian Prime Minister Pierre Trudeau. It will be opened in 2076. ";
            x++;
        }
        else if (x == 6)
        {
            exhibitTextTower.text = "Thanks For Coming!";
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}



