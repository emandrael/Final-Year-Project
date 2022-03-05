using Scriptable_Object_Scripts;
using SimpleSQL;

namespace DatabaseScripts
{
    public class ExerciseDatabaseObject
    {
        [PrimaryKey] public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        public BodyPart BodyPart { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public int WarmUpRestTimer { get; set; }
        public int RealRestTimer { get; set; }
    }
}
