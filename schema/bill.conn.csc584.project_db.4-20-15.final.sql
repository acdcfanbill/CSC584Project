-- Bill.Conn@usd.edu
-- Database and test data for the Electric Utility Service Desk Project
--  for team Sioux Falls.

-- First setup DB
CREATE DATABASE IF NOT EXISTS ElectricUtility;
use ElectricUtility;

-- Let's drop all the tables so we are starting fresh
DROP TABLE IF EXISTS ItemsUsed, Schedule, Ticket, Customer, TechExpertise,
    Expertise, Status, Priority, Tech, ItemTable;

-- Let's drop all views as well
DROP VIEW IF EXISTS TechDailyTicket;


-- Create all the tables
-- Create Customer Table
CREATE TABLE IF NOT EXISTS Customer(
    customerId  INTEGER         NOT NULL AUTO_INCREMENT,
    name        VARCHAR(256)    NOT NULL,
    address1    VARCHAR(25)     NOT NULL,
    address2    VARCHAR(25),
    cityState   VARCHAR(25)     NOT NULL,
    phone       VARCHAR(20)     NOT NULL,
    PRIMARY KEY (customerId)
    ) ENGINE=InnoDB;

-- Create Status Table
CREATE TABLE IF NOT EXISTS Status(
    statusId    INTEGER         NOT NULL AUTO_INCREMENT,
    name        VARCHAR(25)     NOT NULL,
    PRIMARY KEY (statusId)
    ) ENGINE=InnoDB;

-- Create Priority Table
CREATE TABLE IF NOT EXISTS Priority(
    priorityId  INTEGER         NOT NULL AUTO_INCREMENT,
    name        VARCHAR(25)     NOT NULL,
    PRIMARY KEY (priorityId)
    ) ENGINE=InnoDB;

-- Create Ticket Table
CREATE TABLE IF NOT EXISTS Ticket(
    ticketId    INTEGER         NOT NULL AUTO_INCREMENT,
    customerId  INTEGER         NOT NULL,
    name        VARCHAR(15),
    description VARCHAR(255),
    notes       TEXT,
    priorityId  INTEGER         NOT NULL,
    statusId    INTEGER         NOT NULL,
    PRIMARY KEY (ticketId),
    FOREIGN KEY (customerId)
        REFERENCES Customer(customerId),
    FOREIGN KEY (priorityId)
        REFERENCES Priority(priorityId),
    FOREIGN KEY (statusId)
        REFERENCES Status(statusId)
    ) ENGINE=InnoDB;

-- Create Tech Table
CREATE TABLE IF NOT EXISTS Tech(
    techId      INTEGER         NOT NULL AUTO_INCREMENT,
    name        VARCHAR(255)    NOT NULL,
    PRIMARY KEY (techId)
    ) ENGINE=InnoDB;

-- Create Expertise Table
CREATE TABLE IF NOT EXISTS Expertise(
    expertiseId INTEGER         NOT NULL AUTO_INCREMENT,
    job         VARCHAR(32)     NOT NULL,
    description VARCHAR(255)    NOT NULL,
    PRIMARY KEY (expertiseId)
    ) ENGINE=InnoDB;

-- Create TechExpertise Table
CREATE TABLE IF NOT EXISTS TechExpertise(
    id          INTEGER         NOT NULL AUTO_INCREMENT,
    techId      INTEGER         NOT NULL,
    expertiseId INTEGER         NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (techId)
        REFERENCES Tech(techId),
    FOREIGN KEY (expertiseId)
        REFERENCES Expertise(expertiseId)
    ) ENGINE=InnoDB;

-- Create Schedule Table
CREATE TABLE IF NOT EXISTS Schedule(
    id          INTEGER         NOT NULL AUTO_INCREMENT,
    techId      INTEGER         NOT NULL,
    ticketId    INTEGER         NOT NULL,
    onDate      DATE            NOT NULL,
    am          BOOLEAN,
    pm          BOOLEAN,
    PRIMARY KEY (id),
    FOREIGN KEY (techId)
        REFERENCES Tech(techId),
    FOREIGN KEY (ticketId)
        REFERENCES Ticket(ticketId)
    ) ENGINE=InnoDB;

-- Create Item Table
CREATE TABLE IF NOT EXISTS ItemTable(
    itemId      INTEGER         NOT NULL AUTO_INCREMENT,
    name        VARCHAR(255)    NOT NULL,
    description VARCHAR(255),
    price       DECIMAL(10,2)    NOT NULL,
    PRIMARY KEY (itemId)
    ) ENGINE=InnoDB;

-- Create ItemsUsed Table
CREATE TABLE IF NOT EXISTS ItemsUsed(
    id          INTEGER         NOT NULL AUTO_INCREMENT,
    ticketId    INTEGER         NOT NULL,
    itemId      INTEGER         NOT NULL,
    techId      INTEGER         NOT NULL,
    quantity    INTEGER         NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (ticketId)
        REFERENCES Ticket(ticketId),
    FOREIGN KEY (itemId)
        REFERENCES ItemTable(itemId),
    FOREIGN KEY (techId)
        REFERENCES Tech(techId)
    ) ENGINE=InnoDB;

-- Create needed Views
-- Create TechApp views
CREATE VIEW TechDailyTicket (ticketId, descriptions, priority, status, AM,
    PM, techId, onDate)
    AS SELECT s.ticketId AS ticketId, t.description AS description,
        p.name AS priority, st.name AS status, AM, PM, techId, onDate
        FROM Schedule s JOIN Priority p JOIN Status st JOIN Ticket t
        WHERE s.ticketId = t.ticketId AND t.priorityId = p.priorityId
        AND t.statusId = st.statusId;

DROP VIEW IF EXISTS TicketInfo;
CREATE VIEW TicketInfo
    AS SELECT ticketId, ticket.customerId, statusId, customer.name, address1,
            address2, cityState, notes
        FROM Ticket join Customer
        WHERE ticket.customerId = customer.customerId;

DROP VIEW IF EXISTS PerTicket;
CREATE VIEW PerTicket
    AS SELECT t.ticketId, it.itemId, it.name, iu.quantity
        FROM Ticket t JOIN ItemsUsed iu JOIN ItemTable it
        WHERE t.ticketId = iu.ticketId AND iu.itemId = it.itemId;

-- Create DeskApp views
DROP VIEW IF EXISTS TechSpeciality;
CREATE VIEW TechSpeciality
    AS SELECT description, name
        FROM expertise e JOIN techexpertise te ON e.expertiseId = te.expertiseId
        JOIN tech t ON t.techId = te.techId;

DROP VIEW IF EXISTS CustomerDetails;
CREATE VIEW CustomerDetails AS
SELECT name, address1, address2, cityState, phone FROM customer;


-- Create Schedule views
DROP VIEW IF EXISTS ScheduleView;
CREATE VIEW ScheduleView (ticketId, techName, AM, PM)
    AS SELECT t.ticketId AS ticketId, tc.name AS techName, s.AM, s.PM
        FROM Ticket t JOIN Schedule s JOIN Tech tc
        WHERE t.ticketId = s.ticketId AND s.techId = tc.techId;


-- Add some test data
-- Add preset Status's and Priorities
INSERT INTO Status VALUES(0,'New');
INSERT INTO Status VALUES(0,'In-Process');
INSERT INTO Status VALUES(0,'Rescheduled');
INSERT INTO Status VALUES(0,'Completed');
INSERT INTO Status VALUES(0,'Billing');
INSERT INTO Status VALUES(0,'Finished');
INSERT INTO Priority VALUES(0,'Low');
INSERT INTO Priority VALUES(0,'Medium');
INSERT INTO Priority VALUES(0,'High');

-- Add Customer's
INSERT INTO Customer
    VALUES (0,'John Doe','123 left lane',NULL,'Vermillion, SD 57123',
        '605-123-4567');
INSERT INTO Customer
    VALUES (0,'Jane Doe','456 right drive',NULL,'Vermillion, SD 57123',
        '605-123-8901');
INSERT INTO Customer
    VALUES(0,'Tyrion Lannister','#3 Tower of the Hand','The Red Keep',
        'King\'s Landing, Westeros','123-456-7890');

-- Add some Techs
INSERT INTO Tech VALUES(0,'Mike Jones');
INSERT INTO Tech VALUES(0,'Peter Jason');
INSERT INTO Tech VALUES(0,'Jon Snow');
INSERT INTO Tech VALUES(0,'Jack Burton');

-- Add some Expertise
INSERT INTO Expertise VALUES(0,'High Voltage','Works High Voltage Jobs');
INSERT INTO Expertise VALUES(0,'AC','Knows AC power');
INSERT INTO Expertise VALUES(0,'DC','Knows DC power');

-- Give our Tech's some expertise
INSERT INTO TechExpertise VALUES(0,4,1);
INSERT INTO TechExpertise VALUES(0,4,2);
INSERT INTO TechExpertise VALUES(0,4,3);
INSERT INTO TechExpertise VALUES(0,1,1);
INSERT INTO TechExpertise VALUES(0,1,2);
INSERT INTO TechExpertise VALUES(0,2,1);
INSERT INTO TechExpertise VALUES(0,3,1);

-- Add some items to our ItemTable
INSERT INTO ItemTable
    VALUES(0,'Small Widget','This is a smaller widget','12.02');
INSERT INTO ItemTable
    VALUES(0,'Medium Widget','This is a medium widget','24.29');
INSERT INTO ItemTable
    VALUES(0,'Small Transformer','This is a small transformer','88.99');
INSERT INTO ItemTable
    VALUES(0,'Large Transformer','This is a large transformer','599.99');
INSERT INTO ItemTable
    VALUES(0,'HVAC Transformer','This is a Huge Transformer','12000.00');
INSERT INTO ItemTable
    VALUES(0,'ACDC Converter','This is a smaller ACDC converter','45.35');
INSERT INTO ItemTable
    VALUES(0,'240V Cable','This is 10 ft of 240V cable','5.72');

-- Create some tickets
INSERT INTO Ticket
    VALUES(0,3,'Power Failure','User is complaining of a lack of power',
        NULL,3,1);
INSERT INTO Ticket
    VALUES(0,2,'No DC Power','User is complaining of a lack of DC power',
        NULL,1,1);
INSERT INTO Ticket
    VALUES(0,1,'Transformer Out','Transformer is dead for the customer',
        NULL,2,1);

-- Create a Schedule
-- id, techId, ticketId, onDate, am, pm,
INSERT INTO Schedule
    VALUES(0,2,1,'2015-03-11',true,true);
INSERT INTO Schedule
    VALUES(0,3,2,'2015-03-12',true,false);
INSERT INTO Schedule
    VALUES(0,4,3,'2015-03-12',true,true);
INSERT INTO Schedule
    VALUES(0,4,3,'2015-03-13',true,true);
INSERT INTO Schedule
    VALUES(0,1,2,'2015-03-15',true,false);

-- Create an ItemsUsed entry
-- id, ticketId, itemId, techId, quantity
INSERT INTO ItemsUsed
    VALUES(0,3,5,4,1);
