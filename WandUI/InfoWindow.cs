using UnityEngine;

namespace SNMagicalWand.WandUI
{
    internal class InfoWindow 
    {

 
        public static void Render()
        {
            GUI.color = Color.black;
            WandUIBase.Window("SNMagicalWand", new Rect(0, 10, 200, 100));
            GUI.Label(new Rect(10, 25, 200, 100), "<color=gray>v.2.1 by xcar</color>");

            GUI.Label(new Rect(10, 45, 100, 100), "<color=yellow>[F1]</color> - <color=cyan>FullBright</color>");
            GUI.Label(new Rect(10, 65, 200, 100), "<color=yellow>[Insert]</color> - <color=cyan>HideCheat</color>");
            GUI.Label(new Rect(10, 85, 200, 100), "<color=yellow>[F2]</color> - <color=cyan>HideUI</color>");
        }
    }
}
