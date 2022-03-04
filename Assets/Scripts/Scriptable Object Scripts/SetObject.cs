
namespace Scriptable_Object_Scripts
{


    public enum SetType
    {
        WarmUp,
        Real
    }
    
    [System.Serializable]
    public class SetObject
    {
        public SetType _SetType;
        public float _Weight;
        public int _Reps;
    }
}