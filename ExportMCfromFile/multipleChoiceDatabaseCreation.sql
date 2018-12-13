drop table hasCategory;
drop table hasAnswers;
drop table consistsOf;
drop table Quiz;
drop table Question;
drop table Answer;
drop table Category;
drop table Media;

create table Quiz(
quizID int AUTO_INCREMENT,
dateOfCreation date,
wasMadeOf int, 					#add refference to Person
title varchar(200),
primary key (quizID)
);

#insert into Quiz(dateOfCreation,wasMadeOf) values ('2008-10-10',5);

create table Media(
mediaID int AUTO_INCREMENT,
type varchar(1) check (type='T' OR type='I' OR type='V' OR type='A'),
#T for text, I for Image, V for Video and A for Audio
link varchar(255),
primary key (mediaID)
);


create table Question(
questionID int AUTO_INCREMENT,
difficulty varchar(1) check (difficulty='E' OR difficulty='M' or difficulty='H'),
#E for Easy, M for Medium, H for Hard
mediaID int,
FOREIGN KEY (mediaID) REFERENCES Media(mediaID),
primary key (questionID)
);
#insert into Question(difficulty) values ('E');

create table Answer(
answerID int AUTO_INCREMENT,
isCorrect int check (isCorrect=0 OR isCorrect=1),
mediaID int,
FOREIGN KEY (mediaID) REFERENCES Media(mediaID),
primary key (answerID)
);
#insert into Answer values ();

create table Category(
categoryID int AUTO_INCREMENT,
name varchar(50),
hasFather int,
primary key (categoryID)
);
#insert into Category(name,hasFather) values ('Physics',null)


create table consistsOf(
quizID int,
questionID int,
primary key (quizID,questionID),
FOREIGN KEY (quizID) REFERENCES Quiz(quizID),
FOREIGN KEY (questionID) REFERENCES Question(questionID)
);

create table hasAnswers(
questionID int,
answerID int,
primary key (questionID,answerID),
FOREIGN KEY (questionID) REFERENCES Question(questionID),
FOREIGN KEY (answerID) REFERENCES Answer(answerID)
);

create table hasCategory(
questionID int,
categoryID int,
primary key (questionID,categoryID),
FOREIGN KEY (questionID) REFERENCES Question(questionID),
FOREIGN KEY (categoryID) REFERENCES Category(categoryID)
);


insert into Category(name,hasFather) values ('Entertainment',null);
insert into Category(name,hasFather) values ('Science',null);
insert into Category(name,hasFather) values ('Science & Nature',null);
insert into Category(name,hasFather) values ('Politics',null);
insert into Category(name,hasFather) values ('Geography',null);
insert into Category(name,hasFather) values ('Vehicles',null);
insert into Category(name,hasFather) values ('Sports',null);
insert into Category(name,hasFather) values ('Celebrities',null);
insert into Category(name,hasFather) values ('Animals',null);
insert into Category(name,hasFather) values ('Art',null);
insert into Category(name,hasFather) values ('Mythology',null);
insert into Category(name,hasFather) values ('Video Games',1);
insert into Category(name,hasFather) values ('Television',1);
insert into Category(name,hasFather) values ('Japanese Anime & Manga',1);
insert into Category(name,hasFather) values ('Music',1);
insert into Category(name,hasFather) values ('Cartoon & Animations',1);
insert into Category(name,hasFather) values ('Comics',1);
insert into Category(name,hasFather) values ('Film',1);
insert into Category(name,hasFather) values ('Books',1);
insert into Category(name,hasFather) values ('Musicals & Theatres',1);
insert into Category(name,hasFather) values ('Board Games',1);
insert into Category(name,hasFather) values ('Gadgets',2);
insert into Category(name,hasFather) values ('Computers',2);
insert into Category(name,hasFather) values ('Mathematics',2);
insert into Category(name,hasFather) values ('History',null);
insert into Category(name,hasFather) values ('General Knowledge',null);

insert into Quiz(dateOfCreation,wasMadeOf,title) values ('2018-12-10',5,'QuizN1');
insert into Quiz(dateOfCreation,wasMadeOf,title) values ('2018-12-10',5,'QuizN2');
insert into Quiz(dateOfCreation,wasMadeOf,title) values ('2018-12-10',5,'QuizN3');
insert into Quiz(dateOfCreation,wasMadeOf,title) values ('2018-12-10',5,'QuizN4');

insert into consistsOf(quizID,questionID) values (1,1);
insert into consistsOf(quizID,questionID) values (1,2);
insert into consistsOf(quizID,questionID) values (1,3);
insert into consistsOf(quizID,questionID) values (1,4);
insert into consistsOf(quizID,questionID) values (1,5);

insert into consistsOf(quizID,questionID) values (2,1);
insert into consistsOf(quizID,questionID) values (2,2);
insert into consistsOf(quizID,questionID) values (2,3);
insert into consistsOf(quizID,questionID) values (2,4);
insert into consistsOf(quizID,questionID) values (2,5);

insert into consistsOf(quizID,questionID) values (3,1);
insert into consistsOf(quizID,questionID) values (3,2);
insert into consistsOf(quizID,questionID) values (3,3);
insert into consistsOf(quizID,questionID) values (3,4);
insert into consistsOf(quizID,questionID) values (3,5);

insert into consistsOf(quizID,questionID) values (4,1);
insert into consistsOf(quizID,questionID) values (4,2);
insert into consistsOf(quizID,questionID) values (4,3);
insert into consistsOf(quizID,questionID) values (4,4);
insert into consistsOf(quizID,questionID) values (4,5);



delete from hasCategory;
delete from hasAnswers;
delete from consistsOf;
delete from Answer;
delete from Question;
delete from Media;


#Show all questions with their answers ( 4 rows per question)
select Question.questionID,Question.difficulty, Media.mediaID, Media.link, Answer.answerID, Answer.isCorrect, M2.link 
from Question inner join Media on Media.mediaID = Question.mediaID inner join hasAnswers on hasAnswers.questionID = Question.questionID  inner join Answer on hasAnswers.answerID=Answer.answerID 
inner join Media as M2 on M2.mediaID = Answer.mediaID

#Show all the questions and their category
select Question.questionID, Question.difficulty, Media.link, Category.name
 from Question inner join hasCategory on Question.questionID = hasCategory.questionID inner join Category on Category.categoryID = hasCategory.categoryID
 inner join Media on Media.mediaID = Question.questionID
 order by questionID