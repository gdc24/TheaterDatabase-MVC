-- all clubs inserts
ALTER SEQUENCE "clubs_intClubID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Footlighters', 'Kathleen Horvath', 'UMB');
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Players Theatre Group', 'David Vegh', 'UMB');

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
INSERT INTO members ("strName") VALUES ('Audrey Zhu');
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
INSERT INTO members ("strName") VALUES ('Kristal Scott');
INSERT INTO members ("strName") VALUES ('Zoe Perrier');  -- 90
INSERT INTO members ("strName") VALUES ('Joe Thiel');
INSERT INTO members ("strName") VALUES ('Jacob Davis');
INSERT INTO members ("strName") VALUES ('Ryan Buechele');
INSERT INTO members ("strName") VALUES ('Brian Liu');
INSERT INTO members ("strName") VALUES ('Jessica Kwok');  -- 95
INSERT INTO members ("strName") VALUES ('Ashley Roverson');
INSERT INTO members ("strName") VALUES ('Maxwell Bertram Lowery');
INSERT INTO members ("strName") VALUES ('Muayed Shahin');
INSERT INTO members ("strName") VALUES ('Joshua Adams');
INSERT INTO members ("strName") VALUES ('Morgan Fox');  -- 100
INSERT INTO members ("strName") VALUES ('Nicholas Strawn');
INSERT INTO members ("strName") VALUES ('Thomas Lipker');
INSERT INTO members ("strName") VALUES ('Daniel Warner');
INSERT INTO members ("strName") VALUES ('Ryan Karpuszka');
INSERT INTO members ("strName") VALUES ('David Suignard');  -- 105
INSERT INTO members ("strName") VALUES ('Caleb Middlebrook');
INSERT INTO members ("strName") VALUES ('Nick Chu');
INSERT INTO members ("strName") VALUES ('Ivan Suner');
INSERT INTO members ("strName") VALUES ('Cher Yuan');
INSERT INTO members ("strName") VALUES ('Dallas McDonald');  -- 110
INSERT INTO members ("strName") VALUES ('Langdon Caldwell');
INSERT INTO members ("strName") VALUES ('Jacob Shaw');
INSERT INTO members ("strName") VALUES ('Maryann Veyon');
INSERT INTO members ("strName") VALUES ('Maggie McClarren');
INSERT INTO members ("strName") VALUES ('Christian Troelstrup');  -- 115
INSERT INTO members ("strName") VALUES ('Kyle Rickert');
INSERT INTO members ("strName") VALUES ('Marc Franquesa');
INSERT INTO members ("strName") VALUES ('Aman Shankardass');
INSERT INTO members ("strName") VALUES ('Trey Costales');
INSERT INTO members ("strName") VALUES ('Olivia McNee');  -- 120
INSERT INTO members ("strName") VALUES ('Ethan Kinstler');
INSERT INTO members ("strName") VALUES ('Johnathan Sequeira');
INSERT INTO members ("strName") VALUES ('Kegan Sulamoyo');
INSERT INTO members ("strName") VALUES ('Kehley Coleman');
INSERT INTO members ("strName") VALUES ('Alex Lenhart');  -- 125
INSERT INTO members ("strName") VALUES ('Harue Suzuki');
INSERT INTO members ("strName") VALUES ('Dana DOrlando');
INSERT INTO members ("strName") VALUES ('Tyler Burleyson');
INSERT INTO members ("strName") VALUES ('Dan Tomazin');
INSERT INTO members ("strName") VALUES ('Allison Seikmann');  -- 130
INSERT INTO members ("strName") VALUES ('Tim Orlando');
INSERT INTO members ("strName") VALUES ('Johanna Fritzinger');
INSERT INTO members ("strName") VALUES ('Nick Pogharian');

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
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Flute/Piccolo', 34, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Clarinet', 89, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bassoon', 90, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Horn', 91, 1);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Horn', 2, 92, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Trumpet', 93, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Piano', 94, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Synthesizer', 50, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Violin', 95, 1);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Violin', 2, 96, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Viola', 97, 1);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Viola', 2, 98, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Cello', 99, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bass', 100, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Percussion', 101, 1);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Reed', 102, 3);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Reed', 2, 103, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Trumpet', 104, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Viola', 105, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Cello', 106, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Guitar', 108, 3);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Keyboard', 2, 107, 3);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Guitar', 2, 109, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Drums', 110, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Percussion', 111, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Violin', 95, 3);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Violin', 2, 98, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Keyboard', 54, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Reed', 5, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bass', 50, 3);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Keyboard', 112, 2);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Keyboard', 2, 94, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Tenor Saxophone/Baritone Saxophone', 35, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Trumpet', 113, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Drums', 114, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Guitar', 115, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bass', 50, 2);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bassoon', 90, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Trumpet', 93, 4);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Trumpet', 2, 125, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bass Trombone', 99, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Flute/Piccolo', 126, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Oboe/English Horn', 127, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Clarinet', 89, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('French Horn', 128, 4);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('French Horn', 2, 129, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Flute/Clarinet', 103, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Clarinet/Bass Clarinet', 37, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Drums', 110, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Percussion', 111, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Violin', 130, 4);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Violin', 2, 131, 4);
INSERT INTO pits ("strInstrument", "intSeat", "intMemberID", "intShowID") VALUES ('Violin', 3, 95, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Cello', 104, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Bass', 66, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Keyboard', 132, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Synthesizer', 50, 4);
INSERT INTO pits ("strInstrument", "intMemberID", "intShowID") VALUES ('Tenor Trombone', 133, 4);


ALTER SEQUENCE "exec_intExecID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 1, 4, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 1, 5, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 1, 2, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 1, 3, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 2, 4, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 2, 5, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 4, 2, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 4, 3, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Treasurer', 5, 4, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Treasurer', 5, 5, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Treasurer', 5, 2, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Treasurer', 5, 3, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('PR Manager', 6, 4, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('PR Manager', 6, 5, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 7, 4, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 7, 5, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 12, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 13, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 14, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('PR Manager', 15, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('PR Manager', 16, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 17, 6, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 24, 2, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 24, 3, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Secretary', 24, 1, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('President', 25, 1, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Treasurer', 26, 1, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('Vice President', 27, 1, 1);
INSERT INTO exec ("strPosition", "intMemberID", "intDateID", "intClubID") VALUES ('PR Manager', 28, 1, 1);

-- cast inserts
ALTER SEQUENCE "casts_intCastID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Bass', 'Narrator', 66, 1);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Mezzo Soprano', 'Cinderella', 67, 1);
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
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Jeremy Heere', 78, 2);
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
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Elizabeth', 11, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Josh', 116, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Lucas', 79, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Stephen', 65, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Elena', 2, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Kate', 51, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Anne', 8, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'David', 20, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 88, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 6, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 7, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 21, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 78, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 14, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 117, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 118, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES (NULL, 'Ensemble', 119, 3);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Alice Nutting/Edwin Drood', 11, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Clive Paget/John Jasper', 116, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Angela Prysock/Princess Puffer', 120, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Chairperson/Mayor Sapsea', 14, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Soprano', 'Deirdre Peregrine/Rosa Bud', 8, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Victor Grinstead/Neville Landless', 117, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Cedric Moncrieffe/Reverend Crisparkle', 12, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Janet Conover/Helena Landless', 88, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Baritone', 'Phillip Bax/Bazzard', 121, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Nick Cricker Sr/Durdles', 122, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Tenor', 'Nick Cricer Jr/Deputy', 123, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Florence Gill', 13, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Beatrice', 124, 4);
INSERT INTO casts ("strVoicePart", "strRole", "intMemberID", "intShowID") VALUES ('Alto', 'Stage Manager/Wendy', 38, 4);
