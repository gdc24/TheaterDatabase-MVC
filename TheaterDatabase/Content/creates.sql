CREATE TABLE "shows" (
  "intShowID" SERIAL PRIMARY KEY,
  "strName" varchar NOT NULL,
  "strAuthor" varchar NOT NULL,
  "intBudget" int NOT NULL,
  "ysnIsMusical" boolean NOT NULL,
  "intClubID" int NOT NULL,
  "intDateID" int NOT NULL
);

CREATE TABLE "clubs" (
  "intClubID" SERIAL PRIMARY KEY,
  "strClubName" varchar NOT NULL,
  "strAdvisor" varchar NOT NULL,
  "strUmbrellaOrg" varchar NOT NULL
);

CREATE TABLE "members" (
  "intMemberID" SERIAL PRIMARY KEY,
  "strName" varchar UNIQUE NOT NULL
);

CREATE TABLE "staff" (
  "intStaffID" SERIAL PRIMARY KEY,
  "strPosition" varchar NOT NULL,
  "intMemberID" int NOT NULL,
  "intShowID" int NOT NULL
);

CREATE TABLE "pits" (
  "intPitID" SERIAL PRIMARY KEY,
  "intMemberID" int NOT NULL,
  "strInstrument" varchar NOT NULL,
  "intSeat" int NOT NULL DEFAULT 1,
  "intShowID" int NOT NULL
);

CREATE TABLE "dates" (
  "intDateID" SERIAL PRIMARY KEY,
  "strSemester" varchar NOT NULL,
  "intYear" int NOT NULL
);

CREATE TABLE "exec" (
  "intExecID" SERIAL PRIMARY KEY,
  "strPosition" varchar NOT NULL,
  "intMemberID" int NOT NULL,
  "intDateID" int NOT NULL
);

CREATE TABLE "casts" (
  "intCastID" SERIAL PRIMARY KEY,
  "strVoicePart" varchar,
  "strRole" varchar NOT NULL,
  "intMemberID" int NOT NULL,
  "intShowID" int NOT NULL
);

ALTER TABLE "shows" ADD FOREIGN KEY ("intClubID") REFERENCES "clubs" ("intClubID");

ALTER TABLE "shows" ADD FOREIGN KEY ("intDateID") REFERENCES "dates" ("intDateID");

ALTER TABLE "staff" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "staff" ADD FOREIGN KEY ("intShowID") REFERENCES "shows" ("intShowID");

ALTER TABLE "pits" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "pits" ADD FOREIGN KEY ("intShowID") REFERENCES "shows" ("intShowID");

ALTER TABLE "exec" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "exec" ADD FOREIGN KEY ("intDateID") REFERENCES "dates" ("intDateID");

ALTER TABLE "casts" ADD FOREIGN KEY ("intMemberID") REFERENCES "members" ("intMemberID");

ALTER TABLE "casts" ADD FOREIGN KEY ("intShowID") REFERENCES "shows" ("intShowID");
