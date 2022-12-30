SET FOREIGN_KEY_CHECKS=0;

delete
from adapters
where true;

delete
from audio_cables
where true;

delete
from cable_ends
where true;

delete
from cable_has_ends_jt
where true;

delete
from cables
where true;

delete
from charging_cables
where true;

delete
from e_connection_type
where true;

delete
from electronics
where true;

delete
from hubs
where true;

delete
from places
where true;

delete
from roles
where true;

delete
from special_cables
where true;

delete
from things
where true;

delete
from trunk_cables
where true;

delete
from user_has_roles_jt
where true;

delete
from users
where true;

delete
from video_cables
where true;


insert into things (thing_id, place_id)
VALUES (1, 1),
       (2, 2),
       (3, 2),
       (4, 2),
       (5, 2),
       (6, 2),
       (7, 3),
       (8, 1),
       (9, 1),
       (10, 1),
       (11, 1),
       (12, 1),
       (13, 1),
       (14, 1),
       (15, 4),
       (16, 1),
       (17, 4),
       (18, 1),
       (19, 1),
       (20, 4),
       (21, 4),
       (22, 1),
       (23, 5),
       (24, 5),
       (25, 1),
       (26, 4),
       (27, 4),
       (28, 1),
       (29, 5),
       (30, 5),
       (31, 5),
       (32, 5),
       (33, 1),
       (34, 1),
       (35, 5),
       (36, 5),
       (37, 5),
       (38, 5),
       (39, 5),
       (40, 5),
       (41, 5),
       (42, 5),
       (43, 5),
       (44, 5),
       (45, 1),
       (46, 1),
       (47, 1),
       (48, 1),
       (49, 1),
       (50, 5),
       (51, 5),
       (52, 1),
       (53, 5),
       (54, 4),
       (55, 3),
       (56, 3),
       (57, 3),
       (58, 3),
       (59, 3),
       (60, 3),
       (61, 3),
       (62, 3),
       (63, 3),
       (64, 3),
       (65, 3),
       (66, 3),
       (67, 3),
       (68, 3);

insert into cables (thing_id, length)
VALUES (1, 150),
       (2, 10000),
       (3, 20000),
       (4, 1000),
       (5, 2000),
       (6, 1200),
       (7, 1500),
       (8, 150),
       (9, 150),
       (10, 150),
       (11, 150),
       (12, 150),
       (13, 150),
       (14, 150),
       (15, 1000),
       (16, 300),
       (17, 300),
       (18, 150),
       (19, 150),
       (20, 50),
       (21, 50),
       (22, 150),
       (23, 500),
       (24, 500),
       (25, 150),
       (26, 200),
       (27, 200),
       (28, 1000),
       (29, 1000),
       (30, 10000),
       (31, 10000),
       (32, 1000),
       (33, 30),
       (34, 30),
       (35, 5000),
       (36, 5000),
       (37, 2000),
       (38, 500),
       (39, 500),
       (40, 500),
       (41, 500),
       (42, 2000),
       (43, 1000),
       (44, 1000),
       (45, 300),
       (46, 500),
       (47, 1000),
       (48, 500),
       (49, 700),
       (50, 300),
       (51, 1000),
       (52, 500),
       (53, 1000),
       (54, 2000),
       (55, 1000),
       (56, 1000),
       (57, 1000),
       (58, 1000),
       (59, 1000),
       (60, 500),
       (61, 1500),
       (62, 1000),
       (63, 1200),
       (64, 1200),
       (65, 800),
       (66, 1000),
       (67, 500),
       (68, 1000);

insert into e_connection_type (value)
VALUES ('USB TYPE A'),
       ('USB TYPE B'),
       ('USB TYPE C'),
       ('USB Micro TYPE A'),
       ('USB Micro TYPE B'),
       ('USB Mini TYPE A'),
       ('USB Mini TYPE B'),
       ('Lightning'),
       ('CINCH'),
       ('SAT'),
       ('S-Video'),
       ('C14 Strom'),
       ('230V Netzstecker'),
       ('Ethernet'),
       ('HDMI'),
       ('Display Port'),
       ('Optisches Digital Audio'),
       ('Micro HDMI'),
       ('COM1'),
       ('undefined');

insert into cable_ends (CABLE_END_ID, IS_MALE, CONNECTION_TYPE)
VALUES (1, true, 'USB TYPE A'),
       (2, false, 'USB TYPE C'),
       (3, true, 'CINCH'),
       (4, true, 'CINCH'),
       (5, true, 'CINCH'),
       (6, true, 'SAT'),
       (7, true, 'SAT'),
       (8, true, 'S-VIDEO'),
       (9, true, 'S-VIDEO'),
       (10, true, 'C14-Strom'),
       (11, true, '230V Netzstecker'),
       (12, true, 'USB TYPE C'),
       (13, true, 'USB Micro TYPE A'),
       (14, false, 'USB TYPE A'),
       (15, true, 'USB Mini TYPE B'),
       (16, true, 'USB Micro TYPE B'),
       (17, false, 'Ethernet'),
       (18, false, 'Ethernet'),
       (19, true, 'HDMI'),
       (20, true, 'HDMI'),
       (21, false, 'HDMI'),
       (22, true, 'Display Port'),
       (23, true, 'USB TYPE B'),
       (24, true, 'Optisches Digital Audio'),
       (25, true, 'Optisches Digital Audio'),
       (26, true, 'USB TYPE A'),
       (27, true, 'Micro HDMI'),
       (28, false, 'Micro HDMI'),
       (29, true, 'Ethernet'),
       (30, true, 'Ethernet'),
       (31, true, 'USB TYPE C'),
       (32, true, 'COM1'),
       (33, true, 'COM1'),
       (34, false, 'COM1'),
       (35, true, 'undefined'),
       (36, false, 'C13 Strom'),
       (37, false, 'C5 Strom'),
       (38, true, 'C6 Strom'),
       (39, false, 'C7 Strom'),
       (40, true, 'C8 Strom');

insert into cable_has_ends_jt (cable_id, end_id)
VALUES (1, 1),(1, 2),
       (2, 3),(2, 4),
       (3, 3),(3, 4),(3, 5),
       (4, 6),(4, 7),
       (5, 8),(5, 9),
       (6, 3),(6, 4),
       (7, 10),(7, 11),
       (8, 1),(8, 12),
       (9, 1),(9, 12),
       (10, 1),(10, 12),
       (11, 1),(11, 12),
       (12, 1),(12, 12),
       (13, 1),(13, 12),
       (14, 14),(14, 13),
       (15, 14),(15, 1),
       (16, 15),(16, 1),
       (17, 14),(17, 1),
       (18, 15),(18, 1),
       (19, 16),(19, 1),
       (20, 17),(20, 18),
       (21, 17),(21, 18),
       (22, 13),(22, 14),
       (23, 19),(23, 20),
       (24, 19),(24, 20),
       (25, 21),(25, 22),
       (26, 1),(26, 14),
       (27, 1),(27, 14),
       (28, 1),(28, 23),
       (29, 24),(29, 25),
       (30, 19),(30, 20),
       (31, 19),(31, 20),
       (32, 1),(32, 26),
       (33, 20),(33, 28),
       (34, 21),(34, 27),
       (35, 29),(35, 30),
       (36, 29),(36, 30),
       (37, 29),(37, 30),
       (38, 29),(38, 30),
       (39, 29),(39, 30),
       (40, 29),(40, 30),
       (41, 29),(41, 30),
       (42, 29),(42, 30),
       (43, 29),(43, 30),
       (44, 29),(44, 30),
       (45, 1),(45, 13),
       (46, 1),(46, 13),
       (47, 1),(47, 13),
       (48, 1),(48, 13),
       (49, 1),(49, 13),
       (50, 12),(50, 31),
       (51, 1),(51, 26),
       (52, 1),(52, 15),
       (53, 32),(53, 33),
       (54, 32),(54, 34),
       (55, 35),(55, 36),
       (56, 11),(56, 35),
       (57, 11),(57, 35),
       (58, 10),(58, 11),
       (59, 1),(59, 35),
       (60, 1),(60, 35),
       (61, 11),(61, 35),
       (62, 11),(62, 13),
       (63, 11),(63, 35),
       (64, 11),(64, 35),
       (65, 37),(65, 35),
       (66, 38),(66, 11),
       (67, 39),(67, 35),
       (68, 40),(68, 11);

insert into electronics (thing_id)
VALUES (1),(2),(3),(4),(5),(6),(7),
       (8),(9),(10),(11),(12),(13),
       (14),(15),(16),(17),(18),(19),
       (20),(21),(22),(23),(24),(25),
       (26),(27),(28),(29),(30),(31),
       (32),(33),(34),(35),(36),(37),
       (38),(39),(40),(41),(42),(43),
       (44),(45),(46),(47),(48),(49),
       (50),(51),(52),(53),(54),(55),
       (56),(57),(58),(59),(60),(61),
       (62),(63),(64),(65),(66),(67);

insert into places (place_id, description, room, place_column, place_row)
VALUES (1, 'ADAPTER-BOX', null, null, null),
       (2, 'VIDEO/AUDIO-BOX', null, null, null),
       (3, 'NETZTEIL-BOX', null, null, null),
       (4, 'VERLÄNGERUNGS-BOX', null, null, null),
       (5, 'VERBINGUNGS-KABEL-BOX', null, null, null);

insert into adapters (thing_id)
VALUES (1),(8),(9),(10),(11),(12),(13),
       (14),(16),(18),(19),(20),(21),(22),
       (25),(26),(33),(34),(45),(46),(47),
       (48),(49),(52);

insert into audio_cables (thing_id)
VALUES (2),(3),(4),(5),(6);

insert into charging_cables (thing_id, ampere, voltage, watt)
VALUES (7, null, null, null),
       (55, 5, 12, null),
       (56, 2.5, 12, null),
       (57, 1.2, 5, null),
       (58, null, null, null),
       (59, null, null, null),
       (60, null, null, null),
       (61, 1.5, 2, null),
       (62, 0.55, 4.75, null),
       (63, 0.8, 5.7, null),
       (64, 0.3, 9, null),
       (65, 4, 12, null),
       (66, null, null, null),
       (67, 4, 15, null),
       (68, null, null, null);

/*insert into hubs (thing_id)
VALUES ();*/

/*insert into special_cables (thing_id)
VALUES ();*/

insert into trunk_cables (thing_id)
VALUES (23),(24),(29),(30),(31),(32),
       (35),(36),(37),(38),(39),(40),
       (41),(42),(43),(44),(50),(51),
       (53);

insert into video_cables (thing_id)
VALUES (4),(5);

SET FOREIGN_KEY_CHECKS=1;