
-- all shows inserts
ALTER SEQUENCE "shows_intShowID_seq" RESTART WITH 1 INCREMENT BY 1;
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Into the Woods', 'Stephen Sondheim', 10520, TRUE, 1, 1);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Be More Chill', 'Joe Tracz', 11150, TRUE, 1, 2);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('If/Then', 'Brian Yorkey', 19500, TRUE, 1, 3);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('The Mystery of Edwin Drood', 'Charles Dickens', 19985, TRUE, 1, 4);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('She Loves Me', 'Joe Masteroff', 19935, TRUE, 1, 5);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Head Over Heels', 'Jeff Whitty', 16490, TRUE, 1, 6);

-- PTG shows
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('The Glass Menagerie', 'Tennessee Williams', 500, FALSE, 2, 5);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Revolt She Said Revolt Again', 'Alice Birch', 250, FALSE, 2, 5);
INSERT INTO shows ("strName", "strAuthor", "intBudget", "ysnIsMusical", "intClubID", "intDateID") VALUES ('Beware of Falling Deer', 'Adam Steel', 500, FALSE, 2, 5);