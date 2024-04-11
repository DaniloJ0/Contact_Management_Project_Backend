DECLARE @UserId1 UNIQUEIDENTIFIER = 'F45D0431-6F80-4812-9A53-53636BC94AD0';
DECLARE @UserId2 UNIQUEIDENTIFIER = '68E6913D-AF97-4EE1-B1FD-7886208F517C';
DECLARE @UserId3 UNIQUEIDENTIFIER = '75863EEB-D777-40F2-B1FA-B71CDFA43305';

-- Insertar los usuarios con los mismos IDs
INSERT INTO Users (Id, Name, Email)
VALUES 
    (@UserId1, 'John Doe', 'john.doe@example.com'),
    (@UserId2, 'Jane Smith', 'jane.smith@example.com'),
    (@UserId3, 'Alice Johnson', 'alice.johnson@example.com');