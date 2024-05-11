using Il2Cpp;
using Il2CppHoloNetwork.NetworkObjects;
using UnityEngine;

namespace SNMagicalWand
{
    static class StaticMethods
    {
        public static void SendGlobalMessage(Object1PublicObVoObUnique msg)
        {
            ObjectPublicDoBoObBoUnique.Method_Public_Static_Void_Object1PublicObVoObUnique_EnumPublicSealedva5v1_0(msg);
        }
        public static void DestroyHolo(this HoloNetObject holo)
        {
            StaticMethods.SendGlobalMessage(
                             Object2Public31ObVo31Ob31Ob31Ob31Unique.Method_Public_Static_Object2Public31ObVo31Ob31Ob31Ob31Unique_ValueTypePublicSealedObauUIobBoObBoObBoUnique_PDM_0(holo.oid));
        }

        public static void SendHoloMessage(this HoloNetObject o, Object1PublicObBoObUnique msg)
        {
            msg.field_Public_ValueTypePublicSealedObauUIobBoObBoObBoUnique_0 = o.oid;
            o.Method_Public_Void_Object1PublicObBoObUnique_EnumPublicSealedva5v1_0(msg);
        }
        public static void EndMatch(EnumPublicSealedvaALBATIQU5vUnique reason)
        {
            SendGlobalMessage(Object2Public47ObVo47Ob47Ob47Ob470.Method_Public_Static_Object2Public47ObVo47Ob47Ob47Ob470_EnumPublicSealedvaALBATIQU5vUnique_0(reason));
        }
        public static void ForceStart()
        {
            SendGlobalMessage(Object2PublicObVoObObObObObObObOb4.Method_Public_Static_Object2PublicObVoObObObObObObObOb4_PDM_0());
        }
        public static void SetHost(ObjectPublicObInBoStBoHaStObInHaUnique photonPlayer)
        {
            ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.Method_Public_Static_Boolean_ObjectPublicObInBoStBoHaStObInHaUnique_PDM_1(
             photonPlayer);
        }
        public static void SetHostMe()
        {
            SetHost(ObjectPublicAbstractSealedObInObSeBoObSiDoSiBoUnique.prop_ObjectPublicObInBoStBoHaStObInHaUnique_0);
        }
        public static void Kill(HoloNetObject ob)
        {
            ob.SendHoloMessage(Object2Public50ObVo50Ob50Ob50Ob50Unique.Method_Public_Static_Object2Public50ObVo50Ob50Ob50Ob50Unique_EnumPublicSealedvaNEKNBARE5vUnique_PDM_0(EnumPublicSealedvaNEKNBARE5vUnique.NEIGHBOR_KILL));
        }
        public static void Teleport(HoloNetObject ob, Vector3 vector)
        {
            ob.SendHoloMessage(Object2PublicVeObVoVeObVeObVeObVe4.Method_Public_Static_Object2PublicVeObVoVeObVeObVeObVe4_Vector3_PDM_0(vector));
        }
        public static string Decrypt(this ValueTypePublicSealedObBy_sVoStVoByVoUnique str)
        {
            if (str == null) return string.Empty;
            return ObjectPublicAbstractSealedStObStOb0.Method_Public_Static_String_ValueTypePublicSealedObBy_sVoStVoByVoUnique_PDM_0(str);
        }
        public static ValueTypePublicSealedObBy_sVoStVoByVoUnique Encrypt(this string str)
        {
            return new ValueTypePublicSealedObBy_sVoStVoByVoUnique(str);
        }
        public static void ApplyBuff(HoloNetObject o, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique buff)
        {
            o.SendHoloMessage(Object2PublicSeUnique.Method_Public_Static_Object2PublicSeUnique_EnumPublicSealedvaSTCAGLCADITODIKNSLUnique_Il2CppReferenceArray_1_Object_0(buff, null));
        }
        public static void DeBuff(HoloNetObject o, EnumPublicSealedvaSTCAGLCADITODIKNSLUnique buff)
        {
            o.SendHoloMessage(Object2PublicInObUnique.Method_Public_Static_Object2PublicInObUnique_EnumPublicSealedvaSTCAGLCADITODIKNSLUnique_PDM_0(buff));
        }
    }
}
