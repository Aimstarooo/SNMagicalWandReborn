using UnityEngine;

namespace SNMagicalWand
{
    internal class ObjectsCache
    {
        private static readonly Dictionary<Type, MonoBehaviour> scripts = new Dictionary<Type, MonoBehaviour>();
        public static T GetObject<T>() where T: MonoBehaviour
        {
            if (scripts.ContainsKey(typeof(T)))
            {
                return (T)scripts[typeof(T)];
            }
            T t = GameObject.FindObjectOfType<T>();
            scripts.Add(typeof(T), t);
            return t;
        }
        private static readonly Dictionary<Type, MonoBehaviour[]> scripts2 = new Dictionary<Type, MonoBehaviour[]>();
        public static T[] GetObjects<T>() where T : MonoBehaviour
        {
            try
            {
                var objects = scripts2.Where(x => x.Key == typeof(T)).First();
                int len = objects.Value.Length;
                if (len > 0)
                {
                    T[] values = new T[len];
                    for (int i = 0; i < len; i++)
                    {
                        values[i] = (T)objects.Value[i];
                    }
                    return values;
                }
            }
            catch (Exception)
            {
                var ob = GameObject.FindObjectsOfType<T>();
                MonoBehaviour[] ar = new MonoBehaviour[ob.Count];
                for (int i = 0; i < ob.Length; i++)
                {
                    ar[i] = ob[i];
                }
                scripts2.Add(typeof(T), ar);

                return ob;
            }
            return new T[0];
        }
        public static void CleanUp()
        {
            scripts.Clear();
            scripts2.Clear();
        }
    }
}
