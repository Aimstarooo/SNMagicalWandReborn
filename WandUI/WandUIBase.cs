using UnityEngine;

namespace SNMagicalWand.WandUI
{
    struct Size
    {
        public int width { get; set; }
        public int height { get; set; }
        public Size(int w,int h)
        {
            width = w;
            height = h;
        }
    }
    internal class WandUIBase
    {
        private static Rect currentWindowPosition;
        private static Rect currentButtonPosition;
  
        public static Size NormalButtonSize = new Size(100, 30);
        public static Size ThickButtonSize = new Size(100, 50);
        private static Size lastSize;
      
        //  100, 50 thick btn
        //space for thick 55
        public static void Window(string name,Rect r)
        {
            currentWindowPosition = r;
        
            GUI.Box(currentWindowPosition, name,GUISkin.current.window);
            
        }
      
        internal static bool Button(Rect position, string o)
        {
            var c = GUIContent.Temp(o.Contains("</color>") ? o : "<color=cyan>" + o + "</color>");
                int controlID = GUIUtility.GetControlID(GUI.s_ButonHash, FocusType.Passive, position);
                return Draw(position, controlID,c, GUISkin.current.button);
           
        }
        public static void Space()
        {
            currentButtonPosition.x = currentWindowPosition.x-lastSize.width+5;
            currentButtonPosition.y = currentButtonPosition.y +lastSize.height+25;
        }
        public static  bool FirstButton(string o,Size size)
        {
            lastSize = size;
            currentButtonPosition = new Rect(currentWindowPosition.x+10, currentWindowPosition.y + 20, size.width,size.height);
            return Button(currentButtonPosition,o);
        }
        public static bool NextVerticalButton(string o,Size size)
        {
            lastSize = size;
            currentButtonPosition = new Rect(currentButtonPosition.x, currentButtonPosition.y +size.height+ 5, size.width, size.height);
            return Button(currentButtonPosition, o);
        }
        public static bool NextHorizontalButton(string o, Size size)
        {
            lastSize = size;
            currentButtonPosition = new Rect(currentButtonPosition.x + size.width+5, currentButtonPosition.y, size.width, size.height);
            return Button(currentButtonPosition, o);
        }
        internal static bool Draw(Rect position, int id, GUIContent content, GUIStyle style)
        {
            
           
                bool ispointing = position.Contains(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y));
                if (Event.current.type == EventType.Repaint)
                    style.Draw(position, content, id, ispointing, ispointing);


            return Input.GetMouseButtonDown(0) && ispointing;
        }
    }
}
