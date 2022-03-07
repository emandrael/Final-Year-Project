
namespace Scriptable_Object_Scripts
{


    public enum SetType : int
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

        public SetObject(SetType setType, float weight, int reps)
        {
            _SetType = setType;
            _Weight = weight;
            _Reps = reps;
        }
    }
}