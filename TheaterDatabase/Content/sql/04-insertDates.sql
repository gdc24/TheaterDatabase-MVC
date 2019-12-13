-- all dates inserts
ALTER SEQUENCE "dates_intDateID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2017);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2018);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2018);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2019);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2019);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2020);