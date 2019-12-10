-- all clubs inserts
ALTER SEQUENCE "clubs_intClubID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Footlighters', 'Kathleen Horvath', 'Media Board');
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Players Theatre Group', 'David Vegh', 'Media Board');

-- all dates inserts
ALTER SEQUENCE "dates_intDateID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2017);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2018);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2018);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2019);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Fall', 2019);
INSERT INTO dates ("strSemester", "intYear") VALUES ('Spring', 2020);

-- all shows inserts
ALTER SEQUENCE "shows_intShowID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Into the Woods', 'Stephen Sondheim', 10520, TRUE, 1, 1);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Be More Chill', 'Joe Tracz', 11150, TRUE, 1, 2);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('If/Then', 'Brian Yorkey', 19500, TRUE, 1, 3);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('The Mystery of Edwin Drood', 'Charles Dickens', 19985, TRUE, 1, 4);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('She Loves Me', 'Joe Masteroff', 19935, TRUE, 1, 5);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Head Over Heels', 'Jeff Whitty', 16490, TRUE, 1, 6);

-- all members inserts
ALTER SEQUENCE "members_intMemberID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO members ("strName") VALUES ('Ryan Arvizu');
INSERT INTO members ("strName") VALUES ('Amy Titus');
INSERT INTO members ("strName") VALUES ('Giuliana Conte');
INSERT INTO members ("strName") VALUES ('Paulina Martz');
INSERT INTO members ("strName") VALUES ('Hannah Swanson'); -- 5
INSERT INTO members ("strName") VALUES ('Anna Skelton');
INSERT INTO members ("strName") VALUES ('Kathryn Medrow');
INSERT INTO members ("strName") VALUES ('Jennifer Newton');
INSERT INTO members ("strName") VALUES ('Blake Aschenbrener');
INSERT INTO members ("strName") VALUES ('Jaafar Bennani'); -- 10
INSERT INTO members ("strName") VALUES ('Marissa Lahr');
INSERT INTO members ("strName") VALUES ('Dylan Kulbacki');
INSERT INTO members ("strName") VALUES ('Emily Locker');
INSERT INTO members ("strName") VALUES ('Riley Bursh');
INSERT INTO members ("strName") VALUES ('Ruth Cavano'); -- 15
INSERT INTO members ("strName") VALUES ('Anna Pogharian');
INSERT INTO members ("strName") VALUES ('Emma Burke');
INSERT INTO members ("strName") VALUES ('Kegan Sulamoyo');
INSERT INTO members ("strName") VALUES ('Milo Cassarino');
INSERT INTO members ("strName") VALUES ('Shaun Furter');  -- 20
INSERT INTO members ("strName") VALUES ('Casey Lockridge');
INSERT INTO members ("strName") VALUES ('Lauren Pearman');
INSERT INTO members ("strName") VALUES ('Camille Witt');
INSERT INTO members ("strName") VALUES ('Taylor Smith');
INSERT INTO members ("strName") VALUES ('Amy Weaver'); -- 25
INSERT INTO members ("strName") VALUES ('Richard Pannullo');
INSERT INTO members ("strName") VALUES ('Alice Li');
INSERT INTO members ("strName") VALUES ('Aaron Magid');
INSERT INTO members ("strName") VALUES ('Jack OBrien');
INSERT INTO members ("strName") VALUES ('Jess Dickson');  -- 30
INSERT INTO members ("strName") VALUES ('Dan Mottern');
INSERT INTO members ("strName") VALUES ('Erik Espinposa');
INSERT INTO members ("strName") VALUES ('Beca Dennis');
INSERT INTO members ("strName") VALUES ('Annika Chura');
INSERT INTO members ("strName") VALUES ('Jon OBrien');  -- 35
INSERT INTO members ("strName") VALUES ('Gan Xiong');
INSERT INTO members ("strName") VALUES ('Eli Weiskirch');
INSERT INTO members ("strName") VALUES ('Keri Wood');
INSERT INTO members ("strName") VALUES ('Noah Listgarten');
INSERT INTO members ("strName") VALUES ('Maddy Yankell');  -- 40
INSERT INTO members ("strName") VALUES ('Aidan Klemm');
INSERT INTO members ("strName") VALUES ('Samantha Vatev Chrin');
INSERT INTO members ("strName") VALUES ('Ruchi Kale');
INSERT INTO members ("strName") VALUES ('Ann Wang');
INSERT INTO members ("strName") VALUES ('Kevin Kwok');  -- 45
INSERT INTO members ("strName") VALUES ('Courtney Capra');
INSERT INTO members ("strName") VALUES ('Mary Schroeder');
INSERT INTO members ("strName") VALUES ('Bri Litchholt');
INSERT INTO members ("strName") VALUES ('Michelle Rackish');
INSERT INTO members ("strName") VALUES ('Mori Nagai');  -- 50
INSERT INTO members ("strName") VALUES ('Brittany Stern');
INSERT INTO members ("strName") VALUES ('Matt Canel');
INSERT INTO members ("strName") VALUES ('Harper Case');
INSERT INTO members ("strName") VALUES ('Ryan Saathoff');
INSERT INTO members ("strName") VALUES ('Sarah Parr');  -- 55
INSERT INTO members ("strName") VALUES ('Maddie Burhenn');
INSERT INTO members ("strName") VALUES ('Maggie Tyma');
INSERT INTO members ("strName") VALUES ('Emma Halfin');
INSERT INTO members ("strName") VALUES ('Adam Steel');
INSERT INTO members ("strName") VALUES ('Katie Hart');  -- 60
INSERT INTO members ("strName") VALUES ('Alyse Ostojic');
INSERT INTO members ("strName") VALUES ('Kathryn Lemoine');
INSERT INTO members ("strName") VALUES ('Brian Gould');
INSERT INTO members ("strName") VALUES ('Caroline Vieira');
INSERT INTO members ("strName") VALUES ('Nathan Waniorek');  -- 65
INSERT INTO members ("strName") VALUES ('Steve Kerby');
INSERT INTO members ("strName") VALUES ('Amanda Rulis');
INSERT INTO members ("strName") VALUES ('Cindy Dong');
INSERT INTO members ("strName") VALUES ('Alec Frye');
INSERT INTO members ("strName") VALUES ('Bessie Bulman');  -- 70
INSERT INTO members ("strName") VALUES ('Ben Baierl');
INSERT INTO members ("strName") VALUES ('Jay Lee');
INSERT INTO members ("strName") VALUES ('Alex Meltsner');
INSERT INTO members ("strName") VALUES ('Ashlen Trapalis');
INSERT INTO members ("strName") VALUES ('Madi Hillyard');  -- 75
INSERT INTO members ("strName") VALUES ('Emma Wyckoff');
INSERT INTO members ("strName") VALUES ('Nicole Coury');
INSERT INTO members ("strName") VALUES ('Jack Petito');
INSERT INTO members ("strName") VALUES ('Luke Dotson');
INSERT INTO members ("strName") VALUES ('Katrina Claflin');  -- 80
INSERT INTO members ("strName") VALUES ('Abigail McAllister');
INSERT INTO members ("strName") VALUES ('Emma Risley');
INSERT INTO members ("strName") VALUES ('Cassandra Knaggs');
INSERT INTO members ("strName") VALUES ('Victoria Radcliffe');
INSERT INTO members ("strName") VALUES ('Jacob Erney');  -- 85
INSERT INTO members ("strName") VALUES ('Jonah Larson');
INSERT INTO members ("strName") VALUES ('Sam Armm');
INSERT INTO members ("strName") VALUES ('Morgan McCommon');

-- all staff inserts
ALTER SEQUENCE "staff_intStaffID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 1, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 1, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 1, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 1, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 3, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Stage Manager', 3, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 3, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 4, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 4, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 4, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 4, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 4, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 4, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 9, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 9, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Lighting Designer', 10, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 20, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 20, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 20, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Master Carpenter', 20, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 21, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Costume Designer', 21, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Stage Manager', 21, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 22, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 23, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Master Carpenter', 27, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 27, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 29, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Master Carpenter', 29, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Scenic Designer', 29, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 29, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 29, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Master Carpenter', 30, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 30, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Tech Director', 30, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 30, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 31, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Stage Manager', 32, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 33, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Pit Director', 34, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Pit Director', 35, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Pit Director', 36, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Pit Director', 37, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Vocal Director', 38, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 39, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Vocal Director', 40, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Vocal Director', 41, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Stage Manager', 42, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 43, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Rehearsal Pianist', 44, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Rehearsal Pianist', 45, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 46, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 46, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Pit Director', 47, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Costume Designer', 48, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Props Master', 49, 1);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Rehearsal Pianist', 50, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Rehearsal Pianist', 50, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 51, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 52, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Costume Designer', 53, 2);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Rehearsal Pianist', 54, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Choreographer', 55, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 25, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Props Master', 56, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Costume Designer', 57, 3);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 58, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Assistant Stage Manager', 59, 4);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Director', 60, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Stage Manager', 61, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 62, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Sound Designer', 63, 6);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Props Master', 63, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Props Master', 64, 5);
INSERT INTO staff ("strPosition", "intMemberID", "intShowID") VALUES ('Costume Designer', 65, 6);

-- all pits inserts
ALTER SEQUENCE "pits_intPitID_seq" RESTART WITH 1 INCREMENT BY 1;


ALTER SEQUENCE "exec_intExecID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 1, 4);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 1, 5);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 1, 2);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 1, 3);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 2, 4);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 2, 5);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 4, 2);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 4, 3);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Treasurer', 5, 4);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Treasurer', 5, 5);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Treasurer', 5, 2);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Treasurer', 5, 3);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('PR Manager', 6, 4);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('PR Manager', 6, 5);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 7, 4);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 7, 5);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 12, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 13, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 14, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('PR Manager', 15, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('PR Manager', 16, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 17, 6);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 24, 2);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 24, 3);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Secretary', 24, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('President', 25, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Treasurer', 26, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('Vice President', 27, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID") VALUES ('PR Manager', 28, 1);

ALTER SEQUENCE "casts_intCastID_seq" RESTART WITH 1 INCREMENT BY 1;
-- cast inserts

INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Narrator', 66, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Cinderella', 67, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Rapunzel/Cinderellas Mother', 68, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Baker', 69, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Bakers Wife', 70, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Jack', 71, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Bass', 'Cinderellas Prince/Wolf', 72, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Rapunzels Prince/Mysterious Man', 73, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Milky White/Granny/Steward', 74, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Cinderellas Stepmother', 75, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Florinda/Sleeping Beauty', 76, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Lucinda/Snow White', 77, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Witch', 2, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Little Red Ridinghood', 51, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Jacks Mother', 55, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Jeremy Heere', 78, 2)
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Michael Mell', 79, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Christine Canigula', 80, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Squip', 81, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Jenna Rolan', 82, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Chloe Valentine', 83, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Brooke Lohst', 84, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Rich Goranski', 85, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Jake Dillinger', 86, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Jeremys Dad/Mr Reyes/Scary Stockboy', 87, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 88, 2);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 65, 2);