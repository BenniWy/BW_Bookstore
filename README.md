# BW_Bookstore

In order to view the data, it needs to be manually entered into the database.

INSERT INTO "Genre" ("Id", "GenreName") VALUES (1, 'Romance');
INSERT INTO "Genre" ("Id", "GenreName") VALUES (2, 'Action');
INSERT INTO "Genre" ("Id", "GenreName") VALUES (3, 'Thriller');
INSERT INTO "Genre" ("Id", "GenreName") VALUES (4, 'Crime');
INSERT INTO "Genre" ("Id", "GenreName") VALUES (5, 'SelfHelp');
INSERT INTO "Genre" ("Id", "GenreName") VALUES (6, 'Programming');

-- Inserting rows for Romance genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('Pride and Prejudice', 'Jane Austen', 12.99, 1, 'book1.png'),
('The Notebook', 'Nicholas Sparks', 11.99, 1, 'book4.png'),
('Outlander', 'Diana Gabaldon', 14.99, 1, 'book2.png'),
('Me Before You', 'Jojo Moyes', 10.99, 1, 'book5.png'),
('The Fault in Our Stars', 'John Green', 9.99, 1, 'book3.png');

-- Inserting rows for Action genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('The Bourne Identity', 'Robert Ludlum', 14.99, 2, 'book6.png'),
('Die Hard', 'Roderick Thorp', 13.99, 2, 'book1.png'),
('Jurassic Park', 'Michael Crichton', 15.99, 2, 'book4.png'),
('The Da Vinci Code', 'Dan Brown', 12.99, 2, 'book3.png'),
('The Hunger Games', 'Suzanne Collins', 11.99, 2, 'book2.png');

-- Inserting rows for Thriller genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('Gone Girl', 'Gillian Flynn', 11.99, 3, 'book5.png'),
('The Girl with the Dragon Tattoo', 'Stieg Larsson', 10.99, 3, 'book6.png'),
('The Silence of the Lambs', 'Thomas Harris', 12.99, 3, 'book1.png'),
('Before I Go to Sleep', 'S.J. Watson', 9.99, 3, 'book3.png'),
('The Girl on the Train', 'Paula Hawkins', 13.99, 3, 'book2.png');

-- Inserting rows for Crime genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('The Godfather', 'Mario Puzo', 13.99, 4, 'book5.png'),
('The Girl with the Dragon Tattoo', 'Stieg Larsson', 12.99, 4, 'book4.png'),
('The Cuckoo''s Calling', 'Robert Galbraith', 14.99, 4, 'book2.png'),
('In Cold Blood', 'Truman Capote', 11.99, 4, 'book1.png'),
('The Silence of the Lambs', 'Thomas Harris', 15.99, 4, 'book3.png');

-- Inserting rows for SelfHelp genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('The 7 Habits of Highly Effective People', 'Stephen R. Covey', 9.99, 5, 'book3.png'),
('How to Win Friends and Influence People', 'Dale Carnegie', 8.99, 5, 'book2.png'),
('Atomic Habits', 'James Clear', 10.99, 5, 'book5.png'),
('The Subtle Art of Not Giving a F\*ck', 'Mark Manson', 7.99, 5, 'book1.png'),
('You Are a Badass', 'Jen Sincero', 11.99, 5, 'book4.png');

-- Inserting rows for Programming genre
INSERT INTO "Book" ("BookName", "AuthorName", "Price", "GenreId", "Image")
VALUES
('Clean Code', 'Robert C. Martin', 19.99, 6, 'book2.png'),
('Design Patterns', 'Erich Gamma', 17.99, 6, 'book4.png'),
('Code Complete', 'Steve McConnell', 21.99, 6, 'book6.png'),
('The Pragmatic Programmer', 'Andrew Hunt', 18.99, 6, 'book5.png'),
('Head First Design Patterns', 'Eric Freeman', 20.99, 6, 'book1.png');
