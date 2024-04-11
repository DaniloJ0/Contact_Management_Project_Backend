-- Declarar variables para los IDs de usuarios
DECLARE @UserId1 UNIQUEIDENTIFIER = 'F45D0431-6F80-4812-9A53-53636BC94AD0';
DECLARE @UserId2 UNIQUEIDENTIFIER = '68E6913D-AF97-4EE1-B1FD-7886208F517C';
DECLARE @UserId3 UNIQUEIDENTIFIER = '75863EEB-D777-40F2-B1FA-B71CDFA43305';

-- Declarar variables para los IDs de contactos
DECLARE @ContactId1 UNIQUEIDENTIFIER, @ContactId2 UNIQUEIDENTIFIER, @ContactId3 UNIQUEIDENTIFIER, @ContactId4 UNIQUEIDENTIFIER, @ContactId5 UNIQUEIDENTIFIER;

-- Generar entre 2 a 5 contactos para el primer usuario
SET @ContactId1 = NEWID();
SET @ContactId2 = NEWID();
SET @ContactId3 = NEWID();
SET @ContactId4 = NEWID();
SET @ContactId5 = NEWID();
INSERT INTO Contacts (Id, Name, Email, PhoneNumber, Address, Company, Note, UserId)
VALUES 
    (@ContactId1, 'John Smith', 'john.smith@example.com', '123456789', '123 Main Street', 'ABC Inc.', 'Met John at conference', @UserId1),
    (@ContactId2, 'Emma Johnson', 'emma.johnson@example.com', '234567890', '456 Elm Street', 'XYZ Corp.', 'Best client, great partnership', @UserId1),
    (@ContactId3, 'Michael Williams', 'michael.williams@example.com', '345678901', '789 Oak Avenue', 'Acme Corporation', 'Old friend from college', @UserId1),
    (@ContactId4, 'Sarah Davis', 'sarah.davis@example.com', '456789012', '1010 Pine Road', 'Tech Innovations', 'Lead from recent marketing campaign', @UserId1);

-- Generar entre 2 a 5 contactos para el segundo usuario
SET @ContactId1 = NEWID();
SET @ContactId2 = NEWID();
SET @ContactId3 = NEWID();
INSERT INTO Contacts (Id, Name, Email, PhoneNumber, Address, Company, Note, UserId)
VALUES 
    (@ContactId1, 'David Brown', 'david.brown@example.com', '567890123', '222 Maple Lane', 'Global Industries', 'Follow up after trade show', @UserId2),
    (@ContactId2, 'Jennifer Lee', 'jennifer.lee@example.com', '678901234', '333 Cedar Avenue', 'Innovate Solutions', 'Introduced by mutual friend', @UserId2),
    (@ContactId3, 'Daniel Garcia', 'daniel.garcia@example.com', '789012345', '444 Birch Street', 'Tech Startup Co.', 'Interested in partnership opportunity', @UserId2);

-- Generar entre 2 a 5 contactos para el tercer usuario
SET @ContactId1 = NEWID();
SET @ContactId2 = NEWID();
INSERT INTO Contacts (Id, Name, Email, PhoneNumber, Address, Company, Note, UserId)
VALUES 
    (@ContactId1, 'Laura Taylor', 'laura.taylor@example.com', '890123456', '555 Walnut Drive', 'Innovative Solutions', 'Potential investor, needs follow-up', @UserId3),
    (@ContactId2, 'James Martinez', 'james.martinez@example.com', '901234567', '666 Oak Street', 'Digital Ventures Inc.', 'Client from previous job', @UserId3);
