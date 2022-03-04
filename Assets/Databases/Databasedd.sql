BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Workouts" (
	"WorkoutID"	INTEGER NOT NULL UNIQUE,
	"WorkoutName"	TEXT NOT NULL,
	PRIMARY KEY("WorkoutID","WorkoutName")
);
CREATE TABLE IF NOT EXISTS "SetHistory" (
	"WorkoutID"	INTEGER NOT NULL,
	"ExerciseID"	INTEGER NOT NULL,
	"SetID"	INTEGER NOT NULL,
	"DateTime"	TEXT,
	"SetValue"	REAL,
	"SetRepetitions"	INTEGER,
	PRIMARY KEY("SetID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Exercises" (
	"ExerciseID"	INTEGER NOT NULL,
	"ExerciseName"	TEXT NOT NULL,
	"BodyPart"	INTEGER NOT NULL,
	"ExerciseType"	INTEGER NOT NULL,
	"WarmUpRestTimer"	INTEGER NOT NULL,
	"RealRestTimer"	INTEGER NOT NULL,
	PRIMARY KEY("ExerciseID" AUTOINCREMENT)
);
INSERT INTO "Workouts" VALUES (0,'Push');
INSERT INTO "Workouts" VALUES (1,'Pull');
INSERT INTO "Workouts" VALUES (2,'Legs');
INSERT INTO "Exercises" VALUES (1,'EE',0,0,0,0);
INSERT INTO "Exercises" VALUES (2,'ff',0,0,0,0);
INSERT INTO "Exercises" VALUES (3,'ffff',0,0,0,0);
INSERT INTO "Exercises" VALUES (4,'ff',0,0,0,0);
INSERT INTO "Exercises" VALUES (5,'44',0,0,0,0);
COMMIT;