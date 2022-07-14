-- SQLite
INSERT INTO Character (Attack, CriticalChance, CriticalMultiplier, Defense, Discriminator, Gold, HP, IconID, Level, MP, MagicAttack, MagicDefense, Name, Speed,Experience)
VALUES
--Att, CC, CM, Def, Disc, Gold, HP, IconID, Level, MP, MAtt, MDef, Name, Speed
(10,25,2,10,'Profession',100,100,1,1,50,0,10,'Warrior',10,0),
(15,35,2.5,5,'Profession',100,100,2,1,50,0,5,'Thief',15,0),
(15,25,2,5,'Profession',100,50,3,1,50,0,5,'Archer',15,0),
(5,25,2,3,'Profession',100,50,4,1,100,10,20,'Mage',10,0),
(5,25,2,2,'Enemy',NULL,50,5,1,0,0,5,'Goblin',20,0),
(5,25,2,5,'Enemy',NULL,50,6,1,0,0,10,'Orc',10,0),
(5,25,2,0,'Enemy',NULL,50,7,1,0,0,20,'Slime',15,0)
