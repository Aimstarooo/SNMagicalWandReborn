using MelonLoader;
using MelonLoader.NativeUtils;
using System.Runtime.InteropServices;
using System.Net;
    internal class MelonBypass
{

     
        public static void ApplyBypass()
        {
        using(WebClient c = new WebClient())
        {

            c.DownloadFile("https://github.com/lynch0x/SecretNeighborStuff/raw/main/SnBypass.dll", "tmp.dll");
        }
         MelonLoader.NativeLibrary.Load("tmp.dll");
          
        }
    }
