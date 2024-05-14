using UnityEngine;

namespace SNMagicalWand.WandUI
{
    internal class InfoWindow 
    {

 
        public static void Render()
        {
            GUI.color = Color.black;
            WandUIBase.Window("SNMagicalWand", new Rect(0, 10, 200, 100));
            GUI.Label(new Rect(10, 25, 200, 100), "<color=gray>v.2.1 by Aimstar</color>");

            GUI.Label(new Rect(10, 45, 100, 100), "<color=blue>[F1]</color> - <color=red>WidacWhuj</color>");
            GUI.Label(new Rect(10, 65, 200, 100), "<color=blue>[Insert]</color> - <color=red>OffajTeCheaty</color>");
            GUI.Label(new Rect(10, 85, 200, 100), "<color=blue>[F2]</color> - <color=red>SchowajUI</color>");
        }
    }
}
