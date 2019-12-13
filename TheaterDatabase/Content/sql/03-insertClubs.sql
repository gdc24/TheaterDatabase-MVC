-- all clubs inserts
ALTER SEQUENCE "clubs_intClubID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Footlighters', 'Kathleen Horvath', 'UMB');
INSERT INTO clubs ("strClubName", "strAdvisor", "strUmbrellaOrg") VALUES ('Players Theatre Group', 'David Vegh', 'UMB');